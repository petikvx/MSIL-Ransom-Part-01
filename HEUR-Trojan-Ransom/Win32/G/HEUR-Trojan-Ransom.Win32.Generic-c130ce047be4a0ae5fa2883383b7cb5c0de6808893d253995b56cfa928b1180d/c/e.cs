using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace c;

internal static class e
{
	internal sealed class g
	{
		private const int m_b = 0;

		private const int f = 1;

		private const int i = 2;

		private const int v = 3;

		private const int a = 4;

		private const int r = 5;

		private const int w = 6;

		private const int m_t = 7;

		private const int l = 8;

		private const int j = 9;

		private const int k = 10;

		private const int e = 11;

		private const int p = 12;

		private static readonly int[] w;

		private static readonly int[] m_s;

		private static readonly int[] d;

		private static readonly int[] p;

		private int d;

		private int m_g;

		private bool v;

		private m m_g;

		private l m_g;

		private b m_g;

		private v l;

		private v w;

		private l.u y = new l.u();

		public g(byte[] byte_0)
		{
			this.m_g = new m();
			this.m_g = new l();
			d = 2;
			this.m_g.f(byte_0, 0, byte_0.Length);
		}

		static g()
		{
			int[] x = global::c.l.x;
			int num = 4;
			while (true)
			{
				int num2 = -135360576;
				while (true)
				{
					uint num3;
					int[] array_2;
					int[] array_3;
					switch ((num3 = (uint)num2 ^ 0xCFD327A6u) % 9u)
					{
					case 8u:
					{
						int[] array_4 = new int[30];
						global::c.e.g.smethod_0((Array)array_4, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
						global::c.e.g.d = array_4;
						num2 = -2047682138;
						continue;
					}
					case 7u:
						goto IL_002e;
					case 6u:
						switch (num)
						{
						case 2:
							break;
						case 3:
							goto IL_002e;
						default:
							goto IL_0069;
						case 1:
							goto IL_0070;
						case 0:
						case 4:
							goto IL_0082;
						}
						goto case 8u;
					case 0u:
						goto IL_0070;
					case 4u:
						goto IL_0082;
					case 5u:
						num2 = ((int)num3 * -1713299013) ^ -1203417432;
						continue;
					case 1u:
					{
						int[] array_ = new int[29];
						global::c.e.g.smethod_0((Array)array_, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
						global::c.e.g.m_s = array_;
						num2 = (int)(num3 * 1604169310) ^ -459220176;
						continue;
					}
					default:
						return;
					case 2u:
						break;
					case 3u:
						return;
						IL_0082:
						array_2 = new int[29];
						global::c.e.g.smethod_0((Array)array_2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
						global::c.e.g.w = array_2;
						num2 = -1609355634;
						continue;
						IL_0070:
						num = x[22] - 24269;
						num2 = -1520435682;
						continue;
						IL_0069:
						num2 = -1874637976;
						continue;
						IL_002e:
						array_3 = new int[30];
						global::c.e.g.smethod_0((Array)array_3, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
						p = array_3;
						num2 = -1223264586;
						continue;
					}
					break;
				}
			}
		}

		private bool b()
		{
			int[] x = global::c.l.x;
			char[] array = default(char[]);
			int num9 = default(int);
			int num5 = default(int);
			int num4 = default(int);
			int num7 = default(int);
			int num3 = default(int);
			while (true)
			{
				int num = -146888863;
				while (true)
				{
					uint num2;
					int num12;
					switch ((num2 = (uint)num ^ 0xDD159FA8u) % 9u)
					{
					case 8u:
						num3 = 9;
						num = ((int)num2 * -2074258462) ^ 0x6382FB08;
						continue;
					case 7u:
						num12 = 11;
						goto IL_0022;
					case 6u:
						switch (d)
						{
						case 7:
							goto IL_0056;
						case 8:
							goto IL_0063;
						case 9:
							goto IL_0072;
						case 10:
							goto IL_0081;
						}
						num = -1891588801;
						continue;
					default:
						goto IL_0056;
					case 5u:
						num3 = x[4] - 53299;
						num = ((int)num2 * -2095025395) ^ 0x17F9529B;
						continue;
					case 3u:
						array = global::c.e.e.k;
						num = ((int)num2 * -1461021363) ^ 0x5D11D405;
						continue;
					case 2u:
						goto IL_00ba;
					case 1u:
						while (true)
						{
							switch (num3)
							{
							case 23:
								break;
							case 9:
								goto IL_00ba;
							case 28:
								num3 = ((this.m_g <= 0) ? (x[106] - 18211) : (array[339] - 32098));
								continue;
							case 27:
								num9 -= y.l;
								d = 7;
								num3 = x[146] - 49117;
								continue;
							case 0:
								if (((num5 = l.a(this.m_g)) & -256) == 0)
								{
									num3 = 26;
									goto case 16;
								}
								num3 = array[197] - 36790;
								continue;
							case 16:
							case 26:
								this.m_g.v(num5);
								if (--num9 >= 258)
								{
									num3 = 0;
									goto case 0;
								}
								num3 = x[177] - 10695;
								continue;
							case 25:
							{
								int num8 = global::c.e.g.d[num5];
								y.b = num8;
								goto case 20;
							}
							case 20:
								this.m_g = p[num5];
								num3 = 22;
								goto case 22;
							case 22:
								num3 = ((this.m_g <= 0) ? (x[87] - 21965) : (x[91] - 7728));
								continue;
							case 24:
								if (num5 >= 0)
								{
									num3 = x[286] - 23169;
									continue;
								}
								num3 = 18;
								goto case 18;
							case 21:
								d = 9;
								num3 = array[74] - 1215;
								continue;
							case 17:
								num5 = w.a(this.m_g);
								if (num5 < 0)
								{
									num3 = x[268] - 7424;
									continue;
								}
								num3 = 25;
								goto case 25;
							case 15:
							{
								this.m_g.a(this.m_g);
								int num11 = y.b + num4;
								y.b = num11;
								num3 = 7;
								goto case 7;
							}
							case 7:
								this.m_g.p(y.l, y.b);
								num3 = x[127] - 306;
								continue;
							case 14:
							{
								this.m_g.a(this.m_g);
								int num10 = y.l + num7;
								y.l = num10;
								num3 = array[510] - 62365;
								continue;
							}
							case 12:
								num3 = ((num9 >= 258) ? (array[417] - 2694) : (x[266] - 60458));
								continue;
							case 11:
								num3 = 12;
								goto case 12;
							case 10:
								this.m_g = global::c.e.g.m_s[num5 - 257];
								num3 = 28;
								goto case 28;
							case 6:
								d = 8;
								num7 = this.m_g.p(this.m_g);
								if (num7 >= 0)
								{
									num3 = x[98] - 54154;
									continue;
								}
								num3 = 19;
								goto case 4;
							case 5:
							{
								int num6 = global::c.e.g.w[num5 - 257];
								y.l = num6;
								num3 = x[214] - 11813;
								continue;
							}
							case 3:
								if (num5 < 257)
								{
									num3 = array[508] - 25417;
									continue;
								}
								num3 = 5;
								goto case 5;
							case 2:
								d = 10;
								num4 = this.m_g.p(this.m_g);
								if (num4 >= 0)
								{
									num3 = x[337] - 60882;
									continue;
								}
								num3 = 30;
								goto case 30;
							default:
								goto IL_0464;
							case 1:
								w = null;
								l = null;
								d = 2;
								return true;
							case 8:
								return true;
							case 13:
								return false;
							case 4:
							case 19:
								return false;
							case 18:
								return false;
							case 29:
								return true;
							case 30:
								return false;
							}
							break;
						}
						goto case 6u;
					case 0u:
						break;
						IL_0464:
						num = -546203797;
						continue;
						IL_00ba:
						num9 = this.m_g.s();
						num = -1798189753;
						continue;
						IL_0081:
						num12 = 22;
						goto IL_0022;
						IL_0072:
						num12 = x[151] - 15438;
						goto IL_0022;
						IL_0063:
						num12 = x[194] - 5254;
						goto IL_0022;
						IL_0056:
						num12 = array[10] - 38279;
						goto IL_0022;
						IL_0022:
						num3 = num12;
						num = -1931427400;
						continue;
					}
					break;
				}
			}
		}

		private bool t()
		{
			char[] array = global::c.e.e.k;
			int[] x = global::c.l.x;
			int num6 = default(int);
			int num4 = default(int);
			int num9 = default(int);
			int num3 = default(int);
			while (true)
			{
				int num = 1345571619;
				while (true)
				{
					uint num2;
					int num11;
					switch ((num2 = (uint)num ^ 0x2E949414u) % 7u)
					{
					case 6u:
						num3 = 10;
						num = ((int)num2 * -1358523853) ^ -1136034798;
						continue;
					case 5u:
						num11 = array[462] - 38574;
						goto IL_0033;
					case 4u:
						switch (d)
						{
						case 2:
							goto IL_0085;
						case 3:
							goto IL_0091;
						case 4:
							goto IL_009d;
						case 5:
							goto IL_00a1;
						case 6:
							goto IL_00b0;
						case 7:
							goto IL_00b7;
						case 8:
							goto IL_00be;
						case 9:
							goto IL_00c5;
						case 10:
							goto IL_00d7;
						case 11:
							goto IL_00de;
						case 12:
							goto IL_00e4;
						}
						num = 491890297;
						continue;
					default:
						goto IL_0085;
					case 3u:
						while (true)
						{
							switch (num3)
							{
							case 10:
								break;
							case 32:
							{
								int num7 = (num6 = this.m_g.p(16));
								y.t = num7;
								num3 = array[177] - 40211;
								continue;
							}
							case 27:
								switch (num4 >> 1)
								{
								case 0:
									goto IL_0148;
								case 1:
									goto IL_03ae;
								case 2:
									goto IL_03d5;
								}
								num3 = x[232] - 42306;
								continue;
							case 26:
								if (num6 < 0)
								{
									num3 = x[266] - 60465;
									continue;
								}
								num3 = 29;
								goto case 29;
							case 20:
								v = true;
								num3 = array[294] - 36123;
								continue;
							case 18:
								this.m_g.t();
								d = 3;
								num3 = x[41] - 32952;
								continue;
							case 16:
								this.m_g.a(3);
								if (((uint)num4 & (true ? 1u : 0u)) != 0)
								{
									num3 = x[130] - 28455;
									continue;
								}
								num3 = 27;
								goto case 27;
							case 14:
								if (!m_g.w(this.m_g))
								{
									num3 = x[335] - 50433;
									continue;
								}
								num3 = 2;
								goto case 2;
							case 13:
							{
								int num5 = x[104];
								global::c.e.e.k[115] = (char)((global::c.e.e.k[115] | global::c.e.e.k[287]) & '\u001a');
								num3 = num5 - 24090;
								continue;
							}
							case 11:
								num4 = this.m_g.p(3);
								if (num4 < 0)
								{
									num3 = x[332] - 61255;
									continue;
								}
								num3 = 16;
								goto case 16;
							case 4:
								goto IL_0259;
							default:
								goto IL_0315;
							case 0:
								return false;
							case 3:
								return false;
							case 9:
								num3 = 8;
								goto case 8;
							case 8:
								return false;
							case 12:
								d = 12;
								return false;
							case 2:
							case 5:
								l = m_g.v();
								w = m_g.d();
								num3 = 1;
								goto case 1;
							case 1:
								d = 7;
								num3 = 17;
								goto case 17;
							case 17:
								return b();
							case 6:
								l = global::c.e.v.p;
								w = global::c.e.v.k;
								d = 7;
								num3 = 25;
								goto case 25;
							case 28:
								return false;
							case 29:
								this.m_g.a(16);
								d = 4;
								num3 = 30;
								goto case 30;
							case 30:
							{
								int num8 = this.m_g.p(16);
								if (num8 < 0)
								{
									num3 = 34;
									goto case 34;
								}
								num3 = 24;
								goto case 24;
							}
							case 24:
								this.m_g.a(16);
								d = 5;
								num3 = 21;
								goto case 21;
							case 21:
								num9 = this.m_g.x(this.m_g, y.t);
								num3 = 7;
								goto case 7;
							case 7:
							{
								int num10 = y.t - num9;
								y.t = num10;
								goto case 23;
							}
							case 23:
								num3 = 15;
								goto case 15;
							case 15:
								if (y.t == 0)
								{
									num3 = 19;
									goto case 19;
								}
								num3 = 33;
								goto case 33;
							case 19:
								d = 2;
								return true;
							case 31:
								m_g = new b();
								d = 6;
								num3 = 25;
								goto case 25;
							case 25:
								return true;
							case 33:
								return !this.m_g.n;
							case 34:
								return false;
							case 22:
							case 35:
								{
									return false;
								}
								IL_0148:
								num3 = array[31] - 10381;
								continue;
								IL_03d5:
								num3 = 31;
								goto case 31;
								IL_03ae:
								num3 = 6;
								goto case 6;
							}
							break;
							IL_0259:
							num3 = ((!v) ? (x[240] - 46421) : (x[188] - 15077));
						}
						goto case 4u;
					case 2u:
						num = (int)(num2 * 96708196) ^ -90816805;
						continue;
					case 0u:
						break;
						IL_0315:
						num = 907389843;
						continue;
						IL_00e4:
						num11 = 3;
						goto IL_0033;
						IL_00de:
						num11 = 8;
						goto IL_0033;
						IL_00d7:
						num11 = 17;
						goto IL_0033;
						IL_00c5:
						num11 = array[592] - 5340;
						goto IL_0033;
						IL_00be:
						num11 = 17;
						goto IL_0033;
						IL_00b7:
						num11 = 17;
						goto IL_0033;
						IL_00b0:
						num11 = 14;
						goto IL_0033;
						IL_00a1:
						num11 = array[373] - 54453;
						goto IL_0033;
						IL_009d:
						num11 = 30;
						goto IL_0033;
						IL_0091:
						num11 = x[35] - 15026;
						goto IL_0033;
						IL_0085:
						num11 = x[95] - 48768;
						goto IL_0033;
						IL_0033:
						num3 = num11;
						num = 1807749043;
						continue;
					}
					break;
				}
			}
		}

		public int s(byte[] byte_0, int int_0, int int_1)
		{
			char[] array = global::c.e.e.k;
			int[] x = global::c.l.x;
			int num6 = default(int);
			int num5 = default(int);
			int num3 = default(int);
			while (true)
			{
				int num = 1652299727;
				while (true)
				{
					uint num2;
					int num4;
					int num7;
					switch ((num2 = (uint)num ^ 0x200B4199u) % 10u)
					{
					case 9u:
						while (true)
						{
							switch (num3)
							{
							case 11:
								num6 = this.m_g.k(byte_0, int_0, int_1);
								int_0 += num6;
								num3 = x[347] - 60217;
								continue;
							case 9:
								break;
							case 2:
								goto IL_0046;
							case 1:
								goto IL_0074;
							case 0:
								num5 += num6;
								int_1 -= num6;
								if (int_1 != 0)
								{
									num3 = 9;
									break;
								}
								num3 = 7;
								goto case 7;
							default:
								goto end_IL_00a8;
							case 8:
								goto IL_00ee;
							case 6:
							case 10:
								goto IL_0111;
							case 3:
							case 4:
							case 5:
								return num5;
							case 7:
								return num5;
							}
							if (!t())
							{
								num3 = 2;
								goto IL_0046;
							}
							num3 = 8;
							goto IL_00ee;
							IL_0074:
							if (d == 11)
							{
								num3 = array[464] - 24641;
								continue;
							}
							num3 = 8;
							goto IL_00ee;
							IL_0046:
							num3 = ((this.m_g.w() <= 0) ? (x[148] - 20922) : (array[355] - 37110));
							continue;
							end_IL_00a8:
							break;
						}
						num = 510899935;
						continue;
					case 5u:
						goto IL_00ee;
					case 4u:
						goto IL_0111;
					default:
						num4 = array[247] - 18185;
						goto IL_0128;
					case 6u:
						num3 = 8;
						num = (int)(num2 * 1190478561) ^ -229309426;
						continue;
					case 3u:
						num4 = 11;
						goto IL_0128;
					case 2u:
						num3 = 6;
						num = (int)(num2 * 1013259451) ^ -208585918;
						continue;
					case 1u:
						num = (int)((num2 * 1101113683) ^ 0x2BA4D651);
						continue;
					case 0u:
						num = ((int)num2 * -121327527) ^ -1045593754;
						continue;
					case 8u:
						break;
						IL_0128:
						num3 = num4;
						num = 1713556095;
						continue;
						IL_0111:
						num5 = 0;
						num = 898242709;
						continue;
						IL_00ee:
						if (d == 11)
						{
							num = 686192562;
							num7 = 686192562;
						}
						else
						{
							num = 2141270376;
							num7 = 2141270376;
						}
						continue;
					}
					break;
				}
			}
		}

		static void smethod_0(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
		{
			RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
		}
	}

	internal sealed class m
	{
		private int g;

		private uint l;

		private n.u m_n = new n.u();

		public int v => this.m_n.f;

		public int d
		{
			get
			{
				int num = g;
				int num2 = this.m_n.s;
				global::c.e.e.k[363] = (char)((global::c.e.e.k[363] - global::c.e.e.k[151]) & 'â');
				return num - num2 + (this.m_n.f >> 3);
			}
		}

		public bool n => this.m_n.s == g;

		public int p(int int_0)
		{
			int[] x = global::c.l.x;
			char[] k = default(char[]);
			int num4 = default(int);
			while (true)
			{
				int num = -1910624241;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0xCF886FC2u) % 7u)
					{
					case 6u:
						num4 = 6;
						num = ((int)num2 * -675391557) ^ -555800931;
						continue;
					case 5u:
						k = global::c.e.e.k;
						num = ((int)num2 * -249746472) ^ -939502414;
						continue;
					case 4u:
					{
						int num12;
						if (this.m_n.f >= int_0)
						{
							num = -28362650;
							num12 = -28362650;
						}
						else
						{
							num = -1778025817;
							num12 = -1778025817;
						}
						continue;
					}
					case 3u:
						num3 = 8;
						goto IL_005f;
					case 1u:
						while (true)
						{
							switch (num4)
							{
							case 6:
								break;
							case 8:
								goto IL_0067;
							default:
								goto IL_00bf;
							case 2:
								return -1;
							case 5:
							case 7:
							{
								uint num5 = l;
								byte[] array = this.m_n.t;
								int num6;
								int num7 = (num6 = this.m_n.s) + 1;
								this.m_n.s = num7;
								int num8 = array[num6] & 0xFF;
								byte[] array2 = this.m_n.t;
								int num9;
								int num10 = (num9 = this.m_n.s) + 1;
								this.m_n.s = num10;
								l = num5 | (uint)((num8 | ((array2[num9] & 0xFF) << 8)) << this.m_n.f);
								goto case 1;
							}
							case 1:
								num4 = 3;
								goto case 3;
							case 3:
							case 4:
							{
								int num11 = this.m_n.f + 16;
								this.m_n.f = num11;
								num4 = 0;
								goto case 0;
							}
							case 0:
								return (int)(l & ((1 << int_0) - 1));
							}
							break;
							IL_0067:
							num4 = ((this.m_n.s != g) ? (k[296] - 47734) : (x[103] - 65051));
						}
						goto case 4u;
					default:
						num3 = x[304] - 65428;
						goto IL_005f;
					case 2u:
						break;
						IL_00bf:
						num = -1237402506;
						continue;
						IL_005f:
						num4 = num3;
						num = -138517051;
						continue;
					}
					break;
				}
			}
		}

		public void a(int int_0)
		{
			l >>= int_0;
			int num = this.m_n.f - int_0;
			this.m_n.f = num;
		}

		public void t()
		{
			int num = 2;
			while (true)
			{
				int num2 = 1642837853;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num2 ^ 0x34241904u) % 7u)
					{
					case 5u:
						num2 = ((int)num3 * -1789007274) ^ -1222258455;
						continue;
					case 4u:
					{
						int num4 = this.m_n.f & -8;
						this.m_n.f = num4;
						num2 = 665036680;
						continue;
					}
					case 3u:
						switch (num)
						{
						case 0:
						case 3:
							break;
						default:
							goto IL_0052;
						case 1:
							goto IL_0059;
						case 2:
						case 4:
							goto IL_0062;
						}
						goto case 4u;
					case 2u:
						goto IL_0059;
					case 1u:
						goto IL_0062;
					default:
						return;
					case 0u:
						break;
					case 6u:
						return;
						IL_0062:
						l >>= this.m_n.f & 7;
						num2 = 1942410841;
						continue;
						IL_0059:
						num = 0;
						num2 = 1384561546;
						continue;
						IL_0052:
						num2 = 1780265302;
						continue;
					}
					break;
				}
			}
		}

		public int p(byte[] byte_0, int int_0, int int_1)
		{
			int[] x = global::c.l.x;
			char[] k = global::c.e.e.k;
			int num = 10;
			int num6 = default(int);
			int num5 = default(int);
			while (true)
			{
				int num2 = -1865195975;
				while (true)
				{
					uint num3;
					int num4;
					int num10;
					int num11;
					switch ((num3 = (uint)num2 ^ 0x8E91A9A6u) % 15u)
					{
					case 14u:
						num = k[425] - 40472;
						num2 = ((int)num3 * -182860403) ^ -420936607;
						continue;
					case 13u:
						int_1--;
						num2 = -1633755314;
						continue;
					case 12u:
						goto IL_0045;
					case 11u:
						goto IL_0052;
					case 10u:
						num2 = ((int)num3 * -1047284925) ^ -1272037485;
						continue;
					case 9u:
						goto IL_0070;
					case 7u:
						while (true)
						{
							switch (num)
							{
							case 9:
								break;
							case 10:
								goto IL_0045;
							case 4:
								goto IL_0052;
							case 7:
								goto IL_0070;
							case 18:
							{
								byte[] array = this.m_n.t;
								int num7;
								int num8 = (num7 = this.m_n.s) + 1;
								this.m_n.s = num8;
								l = array[num7] & 0xFFu;
								goto case 11;
							}
							case 11:
								num = k[358] - 34873;
								continue;
							case 17:
							{
								int num9 = this.m_n.s + int_1;
								this.m_n.s = num9;
								goto case 13;
							}
							case 13:
								num = 6;
								goto case 6;
							case 6:
								if (((uint)(this.m_n.s - g) & (true ? 1u : 0u)) != 0)
								{
									num = 18;
									goto case 18;
								}
								num = k[211] - 22005;
								continue;
							case 16:
								u((Array)this.m_n.t, this.m_n.s, (Array)byte_0, int_0, int_1, (short)907, 'υ');
								num = k[554] - 43431;
								continue;
							case 15:
								goto IL_0177;
							case 12:
								num6 = g - this.m_n.s;
								if (int_1 > num6)
								{
									num = 2;
									goto case 2;
								}
								num = 16;
								goto case 16;
							case 2:
								int_1 = num6;
								num = 16;
								goto case 16;
							case 3:
								if (int_1 == 0)
								{
									num = x[68] - 40596;
									continue;
								}
								num = 12;
								goto case 12;
							default:
								goto IL_022d;
							case 5:
								goto IL_0237;
							case 8:
								goto IL_0261;
							case 0:
								return num5;
							case 14:
								this.m_n.f = 8;
								num = 1;
								goto case 1;
							case 1:
								return num5 + int_1;
							}
							break;
							IL_0177:
							num = ((int_1 > 0) ? (k[74] - 1224) : (x[240] - 46429));
						}
						goto case 13u;
					case 1u:
						goto IL_0237;
					case 2u:
						goto IL_0261;
					case 6u:
						num5++;
						num2 = ((int)num3 * -1418865391) ^ 0x36425576;
						continue;
					case 5u:
						num2 = ((int)num3 * -737707171) ^ 0x21C5A333;
						continue;
					case 4u:
						num = x[323] - 28387;
						num2 = (int)((num3 * 1204060731) ^ 0xA7CDE8B);
						continue;
					case 3u:
						num4 = 15;
						goto IL_02ca;
					default:
						num4 = x[329] - 17640;
						goto IL_02ca;
					case 8u:
						break;
						IL_02ca:
						num = num4;
						num2 = -647662168;
						continue;
						IL_0261:
						byte_0[int_0++] = (byte)l;
						num = x[162] - 4692;
						num2 = -1865195975;
						continue;
						IL_0237:
						if (this.m_n.f > 0)
						{
							num2 = -1741548042;
							num10 = -1741548042;
						}
						else
						{
							num2 = -560209904;
							num10 = -560209904;
						}
						continue;
						IL_022d:
						num2 = -2012475527;
						continue;
						IL_0070:
						l >>= 8;
						num11 = this.m_n.f - 8;
						this.m_n.f = num11;
						num2 = -235831317;
						continue;
						IL_0052:
						num = 5;
						num2 = -1865195975;
						continue;
						IL_0045:
						num5 = 0;
						num2 = -622256929;
						continue;
					}
					break;
				}
			}
		}

		public void j()
		{
			this.m_n.f = 0;
			g = 0;
			this.m_n.s = 0;
			l = 0u;
		}

		public void f(byte[] byte_0, int int_0, int int_1)
		{
			char[] k = global::c.e.e.k;
			int[] x = default(int[]);
			int num4 = default(int);
			int num3 = default(int);
			while (true)
			{
				int num = 2093192073;
				while (true)
				{
					uint num2;
					int num8;
					int num7;
					switch ((num2 = (uint)num ^ 0x4FEA5918u) % 8u)
					{
					default:
						num8 = 2;
						goto IL_000c;
					case 6u:
						num3 = 12;
						num = ((int)num2 * -2005436361) ^ 0x71289C28;
						continue;
					case 5u:
						num8 = k[247] - 18188;
						goto IL_000c;
					case 3u:
						num = ((int)num2 * -1495351626) ^ 0x378844F8;
						continue;
					case 2u:
						while (true)
						{
							switch (num3)
							{
							case 7:
							case 13:
							{
								int num5 = this.m_n.f + 8;
								this.m_n.f = num5;
								num3 = 10;
								goto case 10;
							}
							case 10:
							{
								this.m_n.t = byte_0 as byte[];
								int num6 = int_0;
								this.m_n.s = num6;
								num3 = x[304] - 65419;
								continue;
							}
							case 8:
								l |= (uint)((byte_0[int_0++] & 0xFF) << this.m_n.f);
								num3 = k[163] - 28087;
								continue;
							case 5:
								if (num4 <= byte_0.Length)
								{
									num3 = 4;
									goto case 4;
								}
								num3 = 1;
								goto case 1;
							case 4:
								if (((uint)int_1 & (true ? 1u : 0u)) != 0)
								{
									num3 = 8;
									goto case 8;
								}
								num3 = k[247] - 18184;
								continue;
							case 3:
								break;
							case 2:
								goto IL_0126;
							default:
								goto end_IL_0141;
							case 12:
								goto IL_0186;
							case 1:
								throw m.smethod_1();
							case 6:
								throw m.smethod_0();
							case 0:
							case 9:
								g = num4;
								return;
							case 11:
								return;
							}
							goto IL_0105;
							IL_0126:
							num4 = int_0 + int_1;
							if (0 <= int_0)
							{
								num3 = 3;
								goto IL_0105;
							}
							num3 = x[260] - 62079;
							continue;
							IL_0105:
							num3 = ((int_0 > num4) ? (k[521] - 27267) : (x[1] - 15269));
							continue;
							end_IL_0141:
							break;
						}
						num = 1595431504;
						continue;
					case 0u:
						goto IL_0186;
					case 1u:
						x = global::c.l.x;
						num = ((int)num2 * -1489127814) ^ -1707163844;
						continue;
					case 4u:
						break;
						IL_0186:
						if (this.m_n.s < g)
						{
							num = 1348588565;
							num7 = 1348588565;
						}
						else
						{
							num = 1329047975;
							num7 = 1329047975;
						}
						continue;
						IL_000c:
						num3 = num8;
						num = 1056402059;
						continue;
					}
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static void u<T, U>(U gparam_0, int int_0, T gparam_1, int int_1, int int_2, short short_0, char char_0) where T : Array where U : Array
		{
			char[] k = global::c.e.e.k;
			int[] x = global::c.l.x;
			int num = 7;
			int num5 = default(int);
			while (true)
			{
				int num2 = 2074836572;
				while (true)
				{
					uint num3;
					int num4;
					switch ((num3 = (uint)num2 ^ 0x1BD3B1Fu) % 9u)
					{
					case 8u:
						switch (((short_0 ^ char_0) - 78) ^ num5)
						{
						case 0:
							goto IL_0035;
						case 1:
							goto IL_0044;
						}
						num2 = 218311767;
						continue;
					default:
						goto IL_0035;
					case 7u:
						while (true)
						{
							switch (num)
							{
							case 4:
							case 8:
								break;
							case 1:
							case 10:
								m.smethod_3((Array)gparam_0, int_0, (Array)gparam_1, int_1, int_2);
								goto case 2;
							case 2:
								num5++;
								goto case 3;
							case 3:
								num = x[330] - 63427;
								continue;
							case 9:
								num = 2;
								goto case 2;
							case 6:
								m.smethod_2((Array)gparam_0, int_0, (Array)gparam_1, int_1, int_2);
								num = x[95] - 48770;
								continue;
							case 5:
								num = x[64] - 12650;
								continue;
							default:
								goto IL_00e7;
							case 7:
								goto IL_00ee;
							case 0:
								return;
							}
							break;
						}
						goto case 8u;
					case 4u:
						goto IL_00ee;
					case 5u:
						num2 = ((int)num3 * -1138003151) ^ 0x6D3E329F;
						continue;
					case 3u:
						num4 = x[164] - 26453;
						goto IL_004e;
					case 2u:
						num = k[568] - 9295;
						num2 = ((int)num3 * -815164110) ^ 0x19B3555C;
						continue;
					case 1u:
						num2 = ((int)num3 * -2005213533) ^ -2052760717;
						continue;
					case 0u:
						break;
						IL_00ee:
						num5 = 0;
						num2 = 918261223;
						continue;
						IL_00e7:
						num2 = 1640713656;
						continue;
						IL_0044:
						num4 = x[92] - 15779;
						goto IL_004e;
						IL_0035:
						num4 = x[275] - 4937;
						goto IL_004e;
						IL_004e:
						num = num4;
						num2 = 227344154;
						continue;
					}
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static int s<T>(T gparam_0, char char_0, char char_1) where T : string
		{
			int[] x = global::c.l.x;
			char[] k = global::c.e.e.k;
			int num5 = default(int);
			int result = default(int);
			int num4 = default(int);
			int num3 = default(int);
			while (true)
			{
				int num = -2061332480;
				while (true)
				{
					uint num2;
					int num6;
					switch ((num2 = (uint)num ^ 0xDDD27291u) % 10u)
					{
					case 9u:
						num = ((int)num2 * -554546252) ^ -611395304;
						continue;
					case 8u:
						num3 = x[310] - 18334;
						num = -1670922783;
						continue;
					case 7u:
						num6 = k[505] - 37841;
						goto IL_0048;
					default:
						num6 = 8;
						goto IL_0048;
					case 5u:
						goto IL_0056;
					case 3u:
						while (true)
						{
							switch (num3)
							{
							case 3:
							case 11:
								break;
							case 6:
								goto IL_0056;
							case 10:
								if (num5 % 2 == 0)
								{
									num3 = k[596] - 63838;
									continue;
								}
								num3 = 0;
								goto IL_00f8;
							case 9:
								result = 10;
								num3 = 1;
								goto case 1;
							case 1:
								num4++;
								num5 = char_1 * char_1;
								goto case 7;
							case 7:
								num5 = char_1 + num5;
								num3 = 10;
								goto case 10;
							case 5:
							case 8:
								result = m.smethod_4((string)gparam_0);
								num3 = 1;
								goto case 1;
							case 4:
								num3 = k[263] - 4718;
								continue;
							default:
								goto IL_00ef;
							case 0:
								goto IL_00f8;
							case 2:
								return result;
							}
							break;
						}
						goto case 8u;
					case 2u:
						goto IL_00f8;
					case 1u:
						num = (int)(num2 * 1140914795) ^ -1218104743;
						continue;
					case 0u:
						num = ((int)num2 * -228133876) ^ 0x43FA5930;
						continue;
					case 4u:
						break;
						IL_00ef:
						num = -796627045;
						continue;
						IL_00f8:
						switch (((char_1 ^ char_0) - 77) ^ num4)
						{
						case 0:
							break;
						default:
							num = -1589816432;
							continue;
						}
						goto default;
						IL_0056:
						num4 = 0;
						num3 = 0;
						num = -2098495446;
						continue;
						IL_0048:
						num3 = num6;
						num = -1490673552;
						continue;
					}
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static ICryptoTransform q<T>(T gparam_0, byte[] byte_0, byte[] byte_1, short short_0, int int_0) where T : SymmetricAlgorithm
		{
			int[] x = global::c.l.x;
			int num4 = default(int);
			char[] k = default(char[]);
			IDisposable disposable = default(IDisposable);
			int num5 = default(int);
			int num3 = default(int);
			while (true)
			{
				int num = 1265585376;
				while (true)
				{
					uint num2;
					int num6;
					switch ((num2 = (uint)num ^ 0x1A8E1ECEu) % 13u)
					{
					case 12u:
						num6 = 7;
						goto IL_000c;
					case 11u:
						num = (int)((num2 * 1222140029) ^ 0x5C8021AD);
						continue;
					case 9u:
						switch (((short_0 ^ int_0) - 91) ^ num4)
						{
						default:
							num = 841913661;
							continue;
						case 0:
							break;
						}
						goto default;
					default:
						num6 = k[564] - 32748;
						goto IL_000c;
					case 8u:
						goto IL_0055;
					case 7u:
						num = ((int)num2 * -477755200) ^ -1803405610;
						continue;
					case 6u:
						k = global::c.e.e.k;
						num = (int)(num2 * 2006701444) ^ -88383527;
						continue;
					case 5u:
						while (true)
						{
							switch (num3)
							{
							case 0:
								break;
							case 2:
								goto IL_0055;
							case 10:
							case 11:
								disposable = m.smethod_5((SymmetricAlgorithm)gparam_0, byte_0, byte_1);
								num3 = 9;
								goto case 3;
							case 3:
							case 9:
								num4++;
								num5 = short_0 * short_0;
								num5 = short_0 + num5;
								num3 = 5;
								goto case 5;
							case 5:
								if (num5 % 2 == 0)
								{
									num3 = x[163] - 26065;
									continue;
								}
								num3 = 0;
								break;
							case 1:
							case 7:
								disposable = null;
								num3 = 9;
								goto case 3;
							default:
								goto IL_0107;
							case 6:
								num3 = 0;
								break;
							case 8:
								goto IL_0116;
							case 4:
								return disposable as ICryptoTransform;
							}
							break;
						}
						goto case 9u;
					case 3u:
						goto IL_0116;
					case 4u:
						num3 = x[347] - 60217;
						num = (int)(num2 * 28911204) ^ -515106574;
						continue;
					case 2u:
						num = ((int)num2 * -203941731) ^ -1969841579;
						continue;
					case 1u:
						num3 = 2;
						num = (int)(num2 * 1649241273) ^ -1253181222;
						continue;
					case 10u:
						break;
						IL_0116:
						num = 981353977;
						continue;
						IL_0107:
						num = 1348228727;
						continue;
						IL_0055:
						num4 = 0;
						num = 1135987407;
						continue;
						IL_000c:
						num3 = num6;
						num = 790678033;
						continue;
					}
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static void i<T>(T gparam_0, long long_0, short short_0, short short_1) where T : Stream
		{
			int[] x = global::c.l.x;
			int num = 0;
			int num5 = default(int);
			while (true)
			{
				int num2 = 2098782755;
				while (true)
				{
					uint num3;
					int num4;
					switch ((num3 = (uint)num2 ^ 0x167902BDu) % 8u)
					{
					case 7u:
						num5 = 0;
						num2 = 1069083886;
						continue;
					case 6u:
						while (true)
						{
							switch (num)
							{
							case 0:
							case 3:
								break;
							case 9:
								num5++;
								num = x[23] - 19440;
								continue;
							case 5:
							case 6:
								num = x[314] - 6029;
								continue;
							case 4:
								m.smethod_6((Stream)gparam_0, long_0);
								goto case 9;
							default:
								goto IL_0076;
							case 8:
								num = 2;
								goto IL_007f;
							case 2:
								goto IL_007f;
							case 1:
							case 7:
								return;
							}
							break;
						}
						goto case 7u;
					case 5u:
						goto IL_007f;
					default:
						num4 = 4;
						goto IL_0098;
					case 4u:
						num2 = (int)((num3 * 1119488552) ^ 0x28DD5CC3);
						continue;
					case 3u:
						num = 2;
						num2 = ((int)num3 * -1161337710) ^ 0xEE5D5C7;
						continue;
					case 2u:
						num4 = 6;
						goto IL_0098;
					case 0u:
						break;
						IL_007f:
						switch (((short_1 ^ short_0) - 83) ^ num5)
						{
						default:
							num2 = 1380807471;
							continue;
						case 0:
							break;
						}
						goto default;
						IL_0098:
						num = num4;
						num2 = 2098782755;
						continue;
						IL_0076:
						num2 = 1843005650;
						continue;
					}
					break;
				}
			}
		}

		static InvalidOperationException smethod_0()
		{
			return new InvalidOperationException();
		}

		static ArgumentOutOfRangeException smethod_1()
		{
			return new ArgumentOutOfRangeException();
		}

		static void smethod_2(Array array_0, int int_0, Array array_1, int int_1, int int_2)
		{
			Array.Copy(array_0, int_0, array_1, int_1, int_2);
		}

		static void smethod_3(Array array_0, int int_0, Array array_1, int int_1, int int_2)
		{
			Buffer.BlockCopy(array_0, int_0, array_1, int_1, int_2);
		}

		static int smethod_4(string string_0)
		{
			return string_0.Length;
		}

		static ICryptoTransform smethod_5(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0, byte[] byte_1)
		{
			return symmetricAlgorithm_0.CreateEncryptor(byte_0, byte_1);
		}

		static void smethod_6(Stream stream_0, long long_0)
		{
			stream_0.Position = long_0;
		}
	}

	internal sealed class l
	{
		internal sealed class u
		{
			internal int l;

			internal int b;

			internal int t;

			internal u()
			{
			}
		}

		private const int m_k = 32768;

		private const int j = 32767;

		private byte[] m_w = new byte[32768];

		private int o;

		private f.p g = new f.p();

		public void v(int int_0)
		{
			char[] array = global::c.e.e.k;
			int num = 1;
			int num8 = default(int);
			while (true)
			{
				int num2 = 948422008;
				while (true)
				{
					uint num3;
					int num4;
					switch ((num3 = (uint)num2 ^ 0x7A8B41D7u) % 7u)
					{
					case 6u:
						num4 = array[490] - 40402;
						goto IL_001a;
					case 5u:
					{
						int num9;
						int num10;
						if (num8 != 32768)
						{
							num9 = -14924271;
							num10 = -14924271;
						}
						else
						{
							num9 = -886871338;
							num10 = -886871338;
						}
						num2 = num9 ^ ((int)num3 * -779837087);
						continue;
					}
					case 3u:
						num8 = o++;
						num2 = 547571891;
						continue;
					case 2u:
						switch (num)
						{
						case 1:
							break;
						default:
							num2 = 861608512;
							continue;
						case 5:
						{
							byte[] array2 = this.m_w;
							int num5;
							int num6 = (num5 = g.w) + 1;
							g.w = num6;
							array2[num5] = (byte)int_0;
							goto case 0;
						}
						case 0:
							num = 2;
							goto case 2;
						case 2:
						case 4:
						{
							int num7 = g.w & 0x7FFF;
							g.w = num7;
							return;
						}
						case 6:
							throw l.smethod_0();
						case 3:
							return;
						}
						goto case 3u;
					case 1u:
						num2 = (int)(num3 * 1094451040) ^ -1295029608;
						continue;
					default:
						num4 = 5;
						goto IL_001a;
					case 4u:
						break;
						IL_001a:
						num = num4;
						num2 = 608519322;
						continue;
					}
					break;
				}
			}
		}

		private void p(int int_0, int int_1, int int_2)
		{
			int[] array = global::c.l.x;
			char[] array2 = default(char[]);
			int num3 = default(int);
			while (true)
			{
				int num = 1422896197;
				while (true)
				{
					uint num2;
					int num4;
					int num5;
					byte[] array3;
					int num7;
					int num6;
					int num8;
					int num9;
					switch ((num2 = (uint)num ^ 0x5CC3F124u) % 16u)
					{
					case 15u:
						num = ((int)num2 * -1023657972) ^ 0x4288A303;
						continue;
					case 14u:
						int_0 &= 0x7FFF;
						num = 1196034289;
						continue;
					case 13u:
						num4 = array2[572] - 24526;
						goto IL_003f;
					case 12u:
						goto IL_004a;
					case 11u:
						num = (int)(num2 * 341259964) ^ -2045927069;
						continue;
					case 7u:
					case 10u:
						goto IL_0076;
					case 9u:
						goto IL_009d;
					case 6u:
						goto IL_0103;
					case 5u:
						num3 = 4;
						num = ((int)num2 * -1891976301) ^ 0x7B6D400;
						continue;
					case 4u:
						num3 = 6;
						num = ((int)num2 * -568847912) ^ -202376553;
						continue;
					case 3u:
						switch (num3)
						{
						case 0:
							break;
						case 5:
						case 7:
							goto IL_004a;
						case 4:
						case 6:
							goto IL_0076;
						case 1:
							goto IL_009d;
						case 3:
						case 8:
							goto IL_0103;
						default:
							goto IL_0176;
						case 2:
							return;
						}
						goto case 14u;
					default:
						num4 = 1;
						goto IL_003f;
					case 1u:
						array2 = global::c.e.e.k;
						num = ((int)num2 * -406006312) ^ 0x289FCBF8;
						continue;
					case 0u:
						num3 = 8;
						num = ((int)num2 * -71962531) ^ 0x5EA61227;
						continue;
					case 8u:
						break;
						IL_0176:
						num = 1195258782;
						continue;
						IL_0103:
						num5 = g.w & 0x7FFF;
						g.w = num5;
						num = 1431169496;
						continue;
						IL_009d:
						array3 = this.m_w;
						num7 = (num6 = g.w);
						global::c.l.x[269] = (global::c.l.x[269] + global::c.l.x[131]) & 0x7E;
						num8 = num7 + 1;
						g.w = num8;
						array3[num6] = this.m_w[int_0++];
						num = 1780359988;
						continue;
						IL_0076:
						if (int_1-- > 0)
						{
							num = 2036210822;
							num9 = 2036210822;
						}
						else
						{
							num = 1498024601;
							num9 = 1498024601;
						}
						continue;
						IL_004a:
						num3 = array[346] - array[346];
						num = 1003396635;
						continue;
						IL_003f:
						num3 = num4;
						num = 1181900279;
						continue;
					}
					break;
				}
			}
		}

		public void p(int int_0, int int_1)
		{
			char[] array = global::c.e.e.k;
			int[] array2 = default(int[]);
			int num5 = default(int);
			int num6 = default(int);
			int num3 = default(int);
			while (true)
			{
				int num = 1704793893;
				while (true)
				{
					uint num2;
					int num9;
					switch ((num2 = (uint)num ^ 0x160E890Du) % 6u)
					{
					case 4u:
						array2 = global::c.l.x;
						num3 = 12;
						num = ((int)num2 * -822623648) ^ -186435367;
						continue;
					default:
						num9 = 0;
						goto IL_0028;
					case 2u:
					{
						int num10;
						if ((o += int_0) > 32768)
						{
							num = 1219584152;
							num10 = 1219584152;
						}
						else
						{
							num = 534105546;
							num10 = 534105546;
						}
						continue;
					}
					case 1u:
						num9 = array[232] - 28562;
						goto IL_0028;
					case 0u:
						while (true)
						{
							switch (num3)
							{
							case 12:
								break;
							case 14:
								num3 = ((int_0-- > 0) ? (array[507] - 6686) : (array2[216] - 38487));
								continue;
							case 8:
							case 13:
								if (int_0 <= int_1)
								{
									num3 = array[294] - 36139;
									continue;
								}
								num3 = 14;
								goto case 14;
							case 11:
								m.u((Array)this.m_w, num5, (Array)this.m_w, g.w, int_0, (short)670, 'ː');
								goto case 7;
							case 7:
								num3 = array[86] - 57872;
								continue;
							case 6:
							{
								byte[] array3 = this.m_w;
								int num7;
								int num8 = (num7 = g.w) + 1;
								g.w = num8;
								array3[num7] = this.m_w[num5++];
								num3 = 14;
								goto case 14;
							}
							case 5:
								if (g.w < num6)
								{
									num3 = array2[88] - 49771;
									continue;
								}
								num3 = 1;
								goto case 1;
							case 2:
								if (num5 <= num6)
								{
									num3 = array[34] - 5170;
									continue;
								}
								num3 = 1;
								goto case 1;
							case 0:
								num5 = (g.w - int_1) & 0x7FFF;
								num6 = 32768 - int_0;
								num3 = array2[67] - 55332;
								continue;
							default:
								goto IL_01dd;
							case 3:
								return;
							case 4:
								throw l.smethod_0();
							case 1:
								p(num5, int_0, int_1);
								return;
							case 9:
							{
								int num4 = g.w + int_0;
								g.w = num4;
								return;
							}
							case 10:
								return;
							}
							break;
						}
						goto case 2u;
					case 5u:
						break;
						IL_01dd:
						num = 1818335055;
						continue;
						IL_0028:
						num3 = num9;
						num = 154052569;
						continue;
					}
					break;
				}
			}
		}

		public int x(m m_0, int int_0)
		{
			int[] array = global::c.l.x;
			int num5 = default(int);
			char[] array2 = default(char[]);
			int num9 = default(int);
			int num8 = default(int);
			while (true)
			{
				int num = -1537279624;
				while (true)
				{
					uint num2;
					int num4;
					switch ((num2 = (uint)num ^ 0xDA2DF23Cu) % 12u)
					{
					case 10u:
						num5 = 32768 - g.w;
						num = -34057271;
						continue;
					case 9u:
						num = ((int)num2 * -625691646) ^ 0x68412F01;
						continue;
					case 8u:
						array2 = global::c.e.e.k;
						num = (int)(num2 * 27902746) ^ -571643882;
						continue;
					case 7u:
						num = ((int)num2 * -1634501763) ^ 0x6CC66EDC;
						continue;
					case 6u:
						num8 = 8;
						num = (int)(num2 * 2000760566) ^ -1022839625;
						continue;
					case 5u:
						num4 = array[125] - 63468;
						goto IL_0082;
					case 4u:
						goto IL_008d;
					case 3u:
						while (true)
						{
							switch (num8)
							{
							case 5:
								break;
							case 8:
								goto IL_008d;
							case 10:
								num9 = m_0.p(this.m_w, g.w, num5);
								goto case 2;
							case 2:
							case 7:
							case 9:
								num8 = array2[307] - 16010;
								continue;
							case 0:
								goto IL_00f7;
							default:
								goto IL_014d;
							case 1:
								num9 += m_0.p(this.m_w, 0, int_0 - num5);
								num8 = 3;
								goto case 3;
							case 4:
								num9 = m_0.p(this.m_w, g.w, int_0);
								num8 = 3;
								goto case 3;
							case 3:
							{
								int num10 = (g.w + num9) & 0x7FFF;
								g.w = num10;
								num8 = 6;
								goto case 6;
							}
							case 6:
								o += num9;
								return num9;
							}
							break;
							IL_00f7:
							num8 = ((num9 != num5) ? (array[185] - 13017) : (array[204] - 44026));
						}
						goto case 10u;
					case 2u:
						num8 = 5;
						num = (int)(num2 * 1823434360) ^ -1258380159;
						continue;
					case 1u:
					{
						int num6;
						int num7;
						if (int_0 > num5)
						{
							num6 = 1031033521;
							num7 = 1031033521;
						}
						else
						{
							num6 = 1952089912;
							num7 = 1952089912;
						}
						num = num6 ^ (int)(num2 * 1808836144);
						continue;
					}
					default:
					{
						int num3 = array[91];
						global::c.e.e.k[127] = (char)((global::c.e.e.k[127] - int_0) & '\u0012');
						num4 = num3 - 7726;
						goto IL_0082;
					}
					case 11u:
						break;
						IL_014d:
						num = -1525226780;
						continue;
						IL_008d:
						int_0 = global::c.b.y(global::c.b.y(int_0, 32768 - o, 517, 'ɵ'), m_0.d, 622, 'Ȟ');
						num = -1671537302;
						continue;
						IL_0082:
						num8 = num4;
						num = -473459985;
						continue;
					}
					break;
				}
			}
		}

		public void f(byte[] byte_0, int int_0, int int_1)
		{
			int[] array = global::c.l.x;
			int num4 = default(int);
			while (true)
			{
				int num = -789147387;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0xBB2B477Du) % 6u)
					{
					default:
						num3 = 4;
						goto IL_000c;
					case 3u:
					{
						int num6;
						if (o > 0)
						{
							num = -153336175;
							num6 = -153336175;
						}
						else
						{
							num = -1668878629;
							num6 = -1668878629;
						}
						continue;
					}
					case 2u:
						num4 = 6;
						num = ((int)num2 * -550829431) ^ -1970771458;
						continue;
					case 1u:
						while (true)
						{
							switch (num4)
							{
							case 6:
								break;
							case 4:
								if (int_1 > 32768)
								{
									num4 = 0;
									goto case 0;
								}
								num4 = 2;
								goto case 1;
							case 0:
							case 3:
								int_0 += int_1 - 32768;
								int_1 = 32768;
								num4 = array[59] - 14787;
								continue;
							default:
								goto IL_00a5;
							case 1:
							case 2:
							case 7:
								m.u((Array)byte_0, int_0, (Array)this.m_w, 0, int_1, (short)334, 'Ā');
								num4 = 5;
								goto case 5;
							case 8:
								throw l.smethod_0();
							case 5:
							{
								int num5 = int_1 & 0x7FFF;
								g.w = num5;
								return;
							}
							}
							break;
						}
						goto case 3u;
					case 0u:
						num3 = array[327] - 44523;
						goto IL_000c;
					case 5u:
						break;
						IL_00a5:
						num = -383814014;
						continue;
						IL_000c:
						num4 = num3;
						num = -1996169274;
						continue;
					}
					break;
				}
			}
		}

		public int s()
		{
			return 32768 - o;
		}

		public int w()
		{
			return o;
		}

		public int k(byte[] byte_0, int int_0, int int_1)
		{
			int[] array = global::c.l.x;
			int num8 = default(int);
			int num7 = default(int);
			int num6 = default(int);
			char[] array2 = default(char[]);
			int num3 = default(int);
			while (true)
			{
				int num = -758231929;
				while (true)
				{
					uint num2;
					int num9;
					switch ((num2 = (uint)num ^ 0xC358084Eu) % 8u)
					{
					case 7u:
						while (true)
						{
							switch (num3)
							{
							case 12:
								m.u((Array)this.m_w, 32768 - num8, (Array)byte_0, int_0, num8, (short)302, 'Š');
								goto case 9;
							case 9:
								num3 = array[215] - 61762;
								continue;
							case 11:
								int_1 = o;
								num3 = 3;
								goto case 3;
							case 3:
								num7 = int_1;
								num8 = int_1 - num6;
								if (num8 > 0)
								{
									num3 = 12;
									goto case 12;
								}
								num3 = array2[483] - 25571;
								continue;
							case 5:
								int_0 += num8;
								int_1 = num6;
								num3 = array2[419] - 10628;
								continue;
							case 2:
								num6 = (g.w - o + int_1) & 0x7FFF;
								num3 = array[324] - 33280;
								continue;
							case 7:
								goto IL_00f4;
							case 10:
								m.u((Array)this.m_w, num6 - int_1, (Array)byte_0, int_0, int_1, (short)389, 'ǋ');
								num3 = 0;
								goto case 0;
							case 0:
							case 1:
								o -= num7;
								if (o < 0)
								{
									num3 = 8;
									goto case 4;
								}
								num3 = 6;
								goto case 6;
							case 4:
							case 8:
								throw l.smethod_0();
							case 6:
								return num7;
							}
							break;
						}
						num = -1123015508;
						continue;
					case 2u:
						goto IL_00f4;
					default:
						num9 = 2;
						goto IL_0109;
					case 4u:
						num9 = 11;
						goto IL_0109;
					case 3u:
					{
						int num4;
						int num5;
						if (int_1 > o)
						{
							num4 = 2136444705;
							num5 = 2136444705;
						}
						else
						{
							num4 = 549580112;
							num5 = 549580112;
						}
						num = num4 ^ (int)(num2 * 516218153);
						continue;
					}
					case 1u:
						array2 = global::c.e.e.k;
						num3 = 7;
						num = (int)(num2 * 395485025) ^ -2129910344;
						continue;
					case 0u:
						num = ((int)num2 * -2019287126) ^ 0x693FCCA1;
						continue;
					case 6u:
						break;
						IL_00f4:
						num6 = g.w;
						num = -494174323;
						continue;
						IL_0109:
						num3 = num9;
						num = -2092071178;
						continue;
					}
					break;
				}
			}
		}

		public void n()
		{
			g.w = 0;
			o = 0;
		}

		[SecuritySafeCritical]
		internal static AppDomain i(short short_0, short short_1)
		{
			int[] array = global::c.l.x;
			char[] array2 = global::c.e.e.k;
			int num5 = default(int);
			_AppDomain val = default(_AppDomain);
			int num3 = default(int);
			while (true)
			{
				int num = -1307973427;
				while (true)
				{
					uint num2;
					int num4;
					switch ((num2 = (uint)num ^ 0xB83EE634u) % 12u)
					{
					case 11u:
						num = (int)(num2 * 942204430) ^ -949439813;
						continue;
					case 10u:
						switch (((short_0 ^ short_1) - 87) ^ num5)
						{
						default:
							num = -1729156617;
							continue;
						case 0:
							break;
						}
						goto default;
					default:
						num4 = 4;
						goto IL_0040;
					case 9u:
						while (true)
						{
							switch (num3)
							{
							case 7:
								break;
							case 6:
								num5++;
								num3 = array2[439] - 34996;
								continue;
							case 5:
								val = null;
								num3 = 6;
								goto case 6;
							case 4:
								val = (_AppDomain)(object)l.smethod_1();
								num3 = array[137] - 55303;
								continue;
							default:
								goto IL_00b3;
							case 1:
							case 2:
								goto IL_00ba;
							case 3:
								num3 = 7;
								break;
							case 8:
								num3 = 7;
								break;
							case 11:
								goto IL_00cf;
							case 0:
							case 9:
							case 10:
								return val as AppDomain;
							}
							break;
						}
						goto case 10u;
					case 4u:
						goto IL_00ba;
					case 8u:
						goto IL_00cf;
					case 7u:
						num4 = array2[594] - 21637;
						goto IL_0040;
					case 3u:
						num3 = 11;
						num = ((int)num2 * -1857538460) ^ 0x685A7D70;
						continue;
					case 2u:
						num3 = array[311] - 53279;
						num = (int)((num2 * 110745775) ^ 0x3C779D1);
						continue;
					case 1u:
						num = ((int)num2 * -1730626100) ^ -304206536;
						continue;
					case 0u:
						num = (int)(num2 * 850758160) ^ -1848475927;
						continue;
					case 6u:
						break;
						IL_00cf:
						num5 = 0;
						num = -1206040574;
						continue;
						IL_00ba:
						num = -1101249393;
						continue;
						IL_00b3:
						num = -233984016;
						continue;
						IL_0040:
						num3 = num4;
						num = -1515574679;
						continue;
					}
					break;
				}
			}
		}

		static InvalidOperationException smethod_0()
		{
			return new InvalidOperationException();
		}

		static AppDomain smethod_1()
		{
			return AppDomain.CurrentDomain;
		}
	}

	internal sealed class v
	{
		private const int u = 15;

		public static readonly v p;

		public static readonly v k;

		private global::c.t.a e;

		static v()
		{
			char[] array = global::c.e.e.k;
			int[] x = global::c.l.x;
			int num = 1;
			Array array2 = default(Array);
			int num5 = default(int);
			while (true)
			{
				int num2 = -766327930;
				while (true)
				{
					uint num3;
					int num4;
					int num6;
					switch ((num3 = (uint)num2 ^ 0x997F80BBu) % 8u)
					{
					case 7u:
						((byte[])array2)[num5++] = 8;
						num = 17;
						num2 = -1772519416;
						continue;
					default:
						num4 = x[132] - 34347;
						goto IL_003d;
					case 5u:
						while (true)
						{
							switch (num)
							{
							case 3:
							case 12:
							case 14:
								break;
							case 11:
								(array2 as byte[])[num5++] = 8;
								num = 18;
								goto case 18;
							case 18:
								if (num5 < 288)
								{
									num = 11;
									goto case 11;
								}
								num = 8;
								goto case 8;
							case 8:
								p = new v(array2 as byte[]);
								goto case 7;
							case 7:
								array2 = new byte[32];
								num5 = 0;
								num = 10;
								goto case 10;
							case 10:
								num = ((num5 < 32) ? (x[23] - 19434) : (x[103] - 65053));
								continue;
							case 16:
								num = array[365] - 331;
								continue;
							case 15:
								((byte[])array2)[num5++] = 9;
								num = x[142] - 1415;
								continue;
							case 13:
								((byte[])array2)[num5++] = 5;
								num = array[60] - 16831;
								continue;
							case 9:
								if (num5 >= 256)
								{
									num = x[122] - 5543;
									continue;
								}
								num = 15;
								goto case 15;
							case 6:
								num = 4;
								goto case 4;
							case 4:
								if (num5 >= 280)
								{
									num = 16;
									goto case 16;
								}
								num = x[28] - 62813;
								continue;
							case 5:
								((byte[])array2)[num5++] = 7;
								num = 4;
								goto case 4;
							case 2:
								num = 9;
								goto case 9;
							default:
								goto IL_01a3;
							case 1:
								goto IL_01aa;
							case 17:
								goto IL_01ce;
							case 0:
								k = new v((byte[])array2);
								return;
							}
							break;
						}
						goto case 7u;
					case 2u:
						goto IL_01aa;
					case 1u:
						goto IL_01ce;
					case 4u:
						num4 = 2;
						goto IL_003d;
					case 3u:
						num2 = ((int)num3 * -1336906262) ^ -1666574056;
						continue;
					case 0u:
						break;
						IL_01ce:
						if (num5 >= 144)
						{
							num2 = -1969894881;
							num6 = -1969894881;
						}
						else
						{
							num2 = -1506377107;
							num6 = -1506377107;
						}
						continue;
						IL_003d:
						num = num4;
						num2 = -766327930;
						continue;
						IL_01aa:
						array2 = new byte[288];
						num5 = 0;
						num = array[341] - 38639;
						num2 = -766327930;
						continue;
						IL_01a3:
						num2 = -1478390255;
						continue;
					}
					break;
				}
			}
		}

		public v(byte[] byte_0)
		{
			g(byte_0);
		}

		private void g(byte[] byte_0)
		{
			int[] x = global::c.l.x;
			char[] array = global::c.e.e.k;
			int num4 = default(int);
			int num7 = default(int);
			object obj2 = default(object);
			int num15 = default(int);
			int num13 = default(int);
			object obj = default(object);
			int num23 = default(int);
			int num24 = default(int);
			int num14 = default(int);
			int num18 = default(int);
			int num19 = default(int);
			int num11 = default(int);
			int num12 = default(int);
			int num22 = default(int);
			int num10 = default(int);
			int num20 = default(int);
			int num9 = default(int);
			int num16 = default(int);
			int num8 = default(int);
			while (true)
			{
				int num = 832808550;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x793A25A1u) % 11u)
					{
					case 10u:
						num4 = byte_0[num7];
						num = 2062429760;
						continue;
					case 9u:
						goto IL_0021;
					case 8u:
						num8 = 37;
						num = (int)(num2 * 1493865724) ^ -52074103;
						continue;
					case 7u:
						num = ((int)num2 * -141182145) ^ -681394181;
						continue;
					case 6u:
						num3 = array[422] - 832;
						goto IL_0071;
					case 5u:
						num7 = 0;
						num8 = x[177] - 10674;
						num = (int)((num2 * 2012919557) ^ 0x7A912ABE);
						continue;
					case 4u:
						while (true)
						{
							switch (num8)
							{
							case 18:
								break;
							case 37:
								goto IL_0021;
							case 1:
							case 38:
								(obj2 as int[])[num15] = num13;
								num13 += ((int[])obj)[num15] << 16 - num15;
								num8 = 12;
								goto case 12;
							case 12:
								if (num15 >= 10)
								{
									num8 = 30;
									goto case 30;
								}
								num8 = 10;
								goto case 10;
							case 30:
								num23 = (obj2 as int[])[num15] & 0x1FF80;
								num24 = num13 & 0x1FF80;
								goto case 16;
							case 16:
								num8 = 4;
								goto case 4;
							case 4:
								num14 += num24 - num23 >> 16 - num15;
								num8 = x[331] - 5457;
								continue;
							case 10:
								num15++;
								num8 = 3;
								goto case 3;
							case 3:
								if (num15 > 15)
								{
									num8 = 15;
									goto case 15;
								}
								num8 = x[169] - 12384;
								continue;
							case 15:
							{
								Array array2 = new short[num14];
								e.o = (short[])array2;
								num18 = 512;
								num8 = 26;
								goto case 26;
							}
							case 26:
								num19 = 15;
								num8 = 5;
								goto case 5;
							case 5:
								if (num19 < 10)
								{
									num8 = 14;
									goto case 14;
								}
								num8 = 9;
								goto case 9;
							case 14:
								num11 = 0;
								num8 = 25;
								goto case 25;
							case 25:
								if (num11 < byte_0.Length)
								{
									num8 = 34;
									goto case 34;
								}
								num8 = 0;
								return;
							case 34:
								num12 = byte_0[num11];
								if (num12 != 0)
								{
									num8 = array[493] - 35928;
									continue;
								}
								num8 = 24;
								goto case 24;
							case 24:
								num11++;
								num8 = x[279] - 98;
								continue;
							case 9:
								num22 = num13 & 0x1FF80;
								num13 -= ((int[])obj)[num19] << 16 - num19;
								num8 = x[309] - 45510;
								continue;
							case 36:
								num7++;
								num8 = 29;
								goto case 29;
							case 29:
								num8 = ((num7 < byte_0.Length) ? (array[90] - 59581) : (x[180] - 14341));
								continue;
							case 21:
								e.o[num10] = (short)((num11 << 4) | num12);
								goto case 17;
							case 17:
								num8 = 35;
								goto case 35;
							case 35:
								num10 += 1 << num12;
								if (num10 < 512)
								{
									num8 = 21;
									goto case 21;
								}
								num8 = 20;
								goto case 20;
							case 20:
								num8 = array[131] - 59562;
								continue;
							case 33:
							{
								num18 += 1 << num19 - 9;
								char num21 = array[107];
								global::c.e.e.k[275] = (char)((global::c.e.e.k[275] * global::c.e.e.k[43]) & '\u008d');
								num8 = num21 - 8418;
								continue;
							}
							case 32:
								num19--;
								num8 = 5;
								goto case 5;
							case 31:
								((int[])obj2)[num12] = num13 + (1 << 16 - num12);
								num8 = 24;
								goto case 24;
							case 28:
								num10 += 1 << num12;
								if (num10 >= num20)
								{
									num8 = 31;
									goto case 31;
								}
								num8 = array[142] - 64885;
								continue;
							case 27:
								num9 = e.o[num10 & 0x1FF];
								num20 = 1 << (num9 & 0xF);
								num8 = x[194] - 5263;
								continue;
							case 23:
								e.o[t.g(num16)] = (short)((-num18 << 4) | num19);
								num8 = array[225] - 46624;
								continue;
							case 22:
								goto IL_036a;
							case 19:
								num9 = -(num9 >> 4);
								num8 = x[305] - 55685;
								continue;
							case 13:
							{
								int num17 = num13 & 0x1FF80;
								num16 = num17;
								num8 = x[41] - 32955;
								continue;
							}
							case 11:
								num13 = (obj2 as int[])[num12];
								num10 = t.g(num13);
								if (num12 <= 9)
								{
									num8 = x[342] - 33890;
									continue;
								}
								num8 = 27;
								goto case 27;
							case 8:
								num16 += 128;
								num8 = x[98] - 54146;
								continue;
							case 7:
								num13 = 0;
								num14 = 512;
								num15 = 1;
								num8 = 3;
								goto case 3;
							case 6:
								(obj as int[])[num4]++;
								num8 = 36;
								goto case 36;
							case 2:
								e.o[num9 | (num10 >> 9)] = (short)((num11 << 4) | num12);
								num8 = 28;
								goto case 28;
							default:
								goto IL_0512;
							case 0:
								return;
							}
							break;
							IL_036a:
							num8 = ((num16 < num22) ? (x[119] - 11304) : (x[302] - 22679));
						}
						goto case 10u;
					case 3u:
					{
						int num5;
						int num6;
						if (num4 > 0)
						{
							num5 = -211482468;
							num6 = -211482468;
						}
						else
						{
							num5 = -676309476;
							num6 = -676309476;
						}
						num = num5 ^ ((int)num2 * -1717088025);
						continue;
					}
					default:
						num3 = 36;
						goto IL_0071;
					case 0u:
						num = (int)(num2 * 1773113219) ^ -2133938570;
						continue;
					case 2u:
						break;
						IL_0021:
						obj = new int[16];
						obj2 = new int[16];
						num = 168551871;
						continue;
						IL_0512:
						num = 771014212;
						continue;
						IL_0071:
						num8 = num3;
						num = 799586123;
						continue;
					}
					break;
				}
			}
		}

		public int a(m m_0)
		{
			char[] array = global::c.e.e.k;
			int[] x = default(int[]);
			int num5 = default(int);
			int num8 = default(int);
			int num9 = default(int);
			int num6 = default(int);
			int num7 = default(int);
			int num3 = default(int);
			while (true)
			{
				int num = 1735643097;
				while (true)
				{
					uint num2;
					int num4;
					switch ((num2 = (uint)num ^ 0x11865FB7u) % 8u)
					{
					case 7u:
					{
						int num10;
						if ((num7 = m_0.p(9)) >= 0)
						{
							num = 285497197;
							num10 = 285497197;
						}
						else
						{
							num = 444311675;
							num10 = 444311675;
						}
						continue;
					}
					case 6u:
						x = global::c.l.x;
						num = (int)(num2 * 1005554009) ^ -26647496;
						continue;
					case 5u:
						while (true)
						{
							switch (num3)
							{
							case 0:
								break;
							case 17:
								if ((num5 & 0xF) > num8)
								{
									num3 = array[87] - 47386;
									continue;
								}
								num3 = 5;
								goto case 5;
							case 10:
								goto IL_0069;
							case 6:
								num8 = m_0.v;
								num7 = m_0.p(num8);
								num5 = e.o[num9 | (num7 >> 9)];
								num3 = 17;
								goto case 17;
							case 4:
								if ((num5 = e.o[num7]) < 0)
								{
									num3 = 10;
									goto IL_0069;
								}
								num3 = 2;
								goto case 2;
							case 1:
								num5 = e.o[num9 | (num7 >> 9)];
								num3 = array[379] - 48069;
								continue;
							default:
								goto IL_0166;
							case 3:
								num6 = m_0.v;
								goto case 15;
							case 2:
								m_0.a(num5 & 0xF);
								return num5 >> 4;
							case 7:
								return -1;
							case 8:
								m_0.a(num5 & 0xF);
								return num5 >> 4;
							case 15:
								num7 = m_0.p(num6);
								num5 = e.o[num7];
								num3 = 16;
								goto case 13;
							case 13:
							case 16:
								if (num5 >= 0)
								{
									num3 = 9;
									goto case 9;
								}
								num3 = 14;
								goto case 14;
							case 9:
								if ((num5 & 0xF) <= num6)
								{
									num3 = 12;
									goto case 12;
								}
								num3 = 14;
								goto case 14;
							case 12:
								m_0.a(num5 & 0xF);
								return num5 >> 4;
							case 14:
								return -1;
							case 5:
							case 11:
								m_0.a(num5 & 0xF);
								return num5 >> 4;
							}
							break;
							IL_0069:
							num9 = -(num5 >> 4);
							int int_ = num5 & 0xF;
							num3 = (((num7 = m_0.p(int_)) < 0) ? (array[356] - 1838) : (x[279] - 122));
						}
						goto case 7u;
					default:
						num4 = 3;
						goto IL_016e;
					case 3u:
						num = ((int)num2 * -242564841) ^ -376306281;
						continue;
					case 2u:
						num4 = array[60] - 16837;
						goto IL_016e;
					case 1u:
						num3 = 0;
						num = ((int)num2 * -731524036) ^ -1603990218;
						continue;
					case 0u:
						break;
						IL_016e:
						num3 = num4;
						num = 1444414108;
						continue;
						IL_0166:
						num = 1051225320;
						continue;
					}
					break;
				}
			}
		}
	}

	internal sealed class b
	{
		private const int m_w = 0;

		private const int n = 1;

		private const int m_b = 2;

		private const int f = 3;

		private const int i = 4;

		private const int s = 5;

		private static readonly int[] h;

		private static readonly int[] m_v;

		private v c;

		private int t;

		private int g;

		private byte l;

		private int h;

		private static readonly int[] u;

		private a.j x = new a.j();

		static b()
		{
			int num = 3;
			while (true)
			{
				int num2 = -296056109;
				while (true)
				{
					uint num3;
					int[] array_2;
					int[] array_3;
					switch ((num3 = (uint)num2 ^ 0x9BAAC889u) % 7u)
					{
					case 6u:
						switch (num)
						{
						case 2:
							goto IL_0028;
						case 3:
							goto IL_0046;
						case 0:
						case 1:
						case 4:
							return;
						}
						num2 = -1669950240;
						continue;
					case 1u:
						goto IL_0028;
					case 3u:
						goto IL_0046;
					case 4u:
					{
						int[] array_ = new int[3];
						global::c.e.b.smethod_0((Array)array_, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
						global::c.e.b.m_v = array_;
						num2 = (int)(num3 * 858270851) ^ -596923613;
						continue;
					}
					case 0u:
						num = 2;
						num2 = ((int)num3 * -501480753) ^ -792474156;
						continue;
					default:
						return;
					case 2u:
						break;
					case 5u:
						return;
						IL_0046:
						array_2 = new int[3];
						global::c.e.b.smethod_0((Array)array_2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
						global::c.e.b.h = array_2;
						num2 = -1020294232;
						continue;
						IL_0028:
						array_3 = new int[19];
						global::c.e.b.smethod_0((Array)array_3, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
						u = array_3;
						num2 = -78942620;
						continue;
					}
					break;
				}
			}
		}

		public bool w(m m_0)
		{
			int[] array = global::c.l.x;
			char[] k = default(char[]);
			int num8 = default(int);
			int int_ = default(int);
			int num10 = default(int);
			int num7 = default(int);
			int num3 = default(int);
			int num4 = default(int);
			while (true)
			{
				int num = -981147758;
				while (true)
				{
					uint num2;
					int num5;
					switch ((num2 = (uint)num ^ 0xC41FD377u) % 8u)
					{
					case 6u:
						num5 = array[245] - 53020;
						goto IL_0018;
					case 5u:
						k = global::c.e.e.k;
						num = ((int)num2 * -857662855) ^ -860383741;
						continue;
					case 4u:
						while (true)
						{
							switch (num3)
							{
							case 42:
								if (num8 >= 17)
								{
									num3 = array[310] - 18302;
									continue;
								}
								num3 = 37;
								goto case 37;
							case 37:
								g = num8 - 16;
								x.j = 5;
								num3 = 32;
								goto case 32;
							case 32:
								int_ = global::c.e.b.m_v[g];
								num10 = m_0.p(int_);
								if (num10 >= 0)
								{
									num3 = 3;
									goto case 3;
								}
								num3 = 1;
								goto case 1;
							case 3:
								m_0.a(int_);
								num10 += global::c.e.b.h[g];
								num3 = 29;
								goto case 29;
							case 18:
								x.c[h++] = l;
								num3 = 29;
								goto case 29;
							case 29:
								if (num10-- > 0)
								{
									num3 = 18;
									goto case 18;
								}
								num3 = array[4] - 53301;
								continue;
							case 41:
								h++;
								num3 = 11;
								goto case 11;
							case 11:
								if (h >= x.v)
								{
									num3 = 7;
									goto case 7;
								}
								num3 = array[104] - 24110;
								continue;
							case 7:
							{
								c = new v(x.u);
								object obj = null;
								x.u = (byte[])obj;
								num3 = 35;
								goto case 35;
							}
							case 35:
								h = 0;
								x.j = 4;
								num3 = 13;
								goto case 13;
							case 13:
								if (((uint)(num8 = c.a(m_0)) & 0xFFFFFFF0u) != 0)
								{
									num3 = array[347] - 60190;
									continue;
								}
								num3 = 28;
								goto case 28;
							case 28:
								x.c[h++] = (l = (byte)num8);
								num3 = k[492] - 57600;
								continue;
							case 30:
							case 40:
							{
								int num12 = m_0.p(4);
								x.v = num12;
								if (x.v < 0)
								{
									num3 = k[487] - 18965;
									continue;
								}
								num3 = 22;
								goto case 22;
							}
							case 22:
							{
								int num13 = x.v + 4;
								x.v = num13;
								goto case 4;
							}
							case 4:
								num3 = k[553] - 23212;
								continue;
							case 39:
							{
								t++;
								m_0.a(5);
								int num11 = x.g + t;
								x.l = num11;
								num3 = 34;
								goto case 34;
							}
							case 34:
							{
								object obj2 = new byte[x.l];
								x.c = (byte[])obj2;
								num3 = 17;
								goto case 17;
							}
							case 17:
								x.j = 2;
								num3 = array[349] - 45774;
								continue;
							case 38:
								l = 0;
								num3 = k[278] - 16605;
								continue;
							case 36:
								t = m_0.p(5);
								if (t < 0)
								{
									num3 = array[73] - 53855;
									continue;
								}
								num3 = 39;
								goto case 39;
							case 27:
								if (num8 >= 0)
								{
									num3 = 42;
									goto case 42;
								}
								num3 = 15;
								goto case 15;
							case 25:
								m_0.a(3);
								x.u[u[h]] = (byte)num7;
								num3 = 41;
								goto case 41;
							case 24:
								m_0.a(5);
								x.j = 1;
								num3 = 36;
								goto case 36;
							case 23:
								if (h != x.l)
								{
									num3 = 13;
									goto case 13;
								}
								num3 = 19;
								goto case 19;
							case 16:
								x.j = 4;
								num3 = k[247] - 18168;
								continue;
							case 14:
							{
								int num9 = x.g + 257;
								x.g = num9;
								num3 = k[493] - 35915;
								continue;
							}
							case 10:
								if (h != x.l)
								{
									num3 = 16;
									goto case 16;
								}
								num3 = 20;
								goto case 20;
							case 2:
							case 9:
								num3 = array[67] - 55308;
								continue;
							case 8:
							{
								m_0.a(4);
								Array array2 = new byte[19];
								x.u = array2 as byte[];
								num3 = k[102] - 37357;
								continue;
							}
							case 6:
								h = 0;
								x.j = 3;
								num3 = 11;
								goto case 11;
							case 5:
								num7 = m_0.p(3);
								if (num7 >= 0)
								{
									num3 = 25;
									goto case 25;
								}
								num3 = 31;
								goto case 31;
							case 0:
							{
								int num6 = m_0.p(5);
								x.g = num6;
								if (x.g >= 0)
								{
									num3 = array[167] - 44450;
									continue;
								}
								num3 = 21;
								goto case 21;
							}
							case 26:
								goto IL_0551;
							case 12:
								return false;
							case 20:
								return true;
							case 21:
								return false;
							case 19:
								return true;
							case 15:
								return false;
							case 31:
								return false;
							case 33:
								return false;
							case 1:
								return false;
							}
							break;
						}
						num = -54322041;
						continue;
					case 0u:
						goto IL_0551;
					default:
						num5 = 0;
						goto IL_0018;
					case 2u:
						switch (num4)
						{
						case 0:
							break;
						default:
							goto IL_058a;
						case 1:
							goto IL_0599;
						case 2:
							goto IL_05a0;
						case 3:
							goto IL_05b2;
						case 4:
							goto IL_05b9;
						case 5:
							goto IL_05c0;
						}
						goto default;
					case 1u:
						num3 = 26;
						num = (int)((num2 * 699054694) ^ 0x30C15C05);
						continue;
					case 7u:
						break;
						IL_05c0:
						num5 = k[547] - 42014;
						goto IL_0018;
						IL_05b9:
						num5 = 13;
						goto IL_0018;
						IL_05b2:
						num5 = 11;
						goto IL_0018;
						IL_05a0:
						num5 = array[299] - 20250;
						goto IL_0018;
						IL_0599:
						num5 = 36;
						goto IL_0018;
						IL_058a:
						num = ((int)num2 * -1896396018) ^ 0x3664FDE5;
						continue;
						IL_0551:
						num4 = x.j;
						num = -2018605515;
						continue;
						IL_0018:
						num3 = num5;
						num = -1440817901;
						continue;
					}
					break;
				}
			}
		}

		public v v()
		{
			int num = 4;
			Array array = default(Array);
			while (true)
			{
				int num2 = 1469747852;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num2 ^ 0x3F1A6C51u) % 6u)
					{
					case 5u:
						switch (num)
						{
						case 0:
						case 1:
						case 3:
						case 4:
							goto IL_0028;
						case 2:
							goto IL_00bb;
						}
						num2 = 283761017;
						continue;
					case 4u:
						goto IL_0028;
					case 3u:
						num = 2;
						num2 = (int)((num3 * 373364756) ^ 0x5359C2F1);
						continue;
					case 2u:
						num2 = ((int)num3 * -1501983528) ^ 0x3FCEF92C;
						continue;
					case 0u:
						break;
					default:
						goto IL_00bb;
						IL_00bb:
						return new v((byte[])array);
						IL_0028:
						array = new byte[x.g];
						m.u((Array)x.c, 0, (Array)(byte[])array, 0, x.g, (short)387, 'Ǎ');
						num2 = 1433391250;
						continue;
					}
					break;
				}
			}
		}

		public v d()
		{
			int num = 1;
			object obj = default(object);
			while (true)
			{
				int num2 = 280528990;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num2 ^ 0x238EF78Bu) % 7u)
					{
					case 6u:
						num = 3;
						num2 = 1750433696;
						continue;
					case 5u:
						switch (num)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_002a;
						case 1:
							goto IL_0031;
						case 4:
							goto IL_0044;
						case 3:
							goto IL_00be;
						}
						goto case 6u;
					case 0u:
						goto IL_0031;
					case 3u:
						goto IL_0044;
					case 1u:
						num2 = (int)(num3 * 1015285006) ^ -1452359420;
						continue;
					case 2u:
						break;
					default:
						goto IL_00be;
						IL_00be:
						return new v((byte[])obj);
						IL_0044:
						m.u((Array)x.c, x.g, (Array)(byte[])obj, 0, t, (short)173, 'ã');
						num2 = 1192358296;
						continue;
						IL_0031:
						obj = new byte[t];
						num2 = 1969540423;
						continue;
						IL_002a:
						num2 = 667756364;
						continue;
					}
					break;
				}
			}
		}

		static void smethod_0(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
		{
			RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
		}
	}

	internal sealed class p
	{
		[StructLayout(LayoutKind.Auto)]
		internal struct u
		{
			internal long b;
		}

		internal sealed class t
		{
			internal int h;

			internal int t;

			internal t()
			{
			}
		}

		private const int k = 4;

		private const int m_w = 8;

		private const int m = 16;

		private const int v = 20;

		private const int s = 28;

		private const int q = 30;

		private int f = 16;

		private e q;

		private r m_e;

		private u m_t;

		public long p => this.m_t.b;

		public bool c
		{
			get
			{
				char[] array = global::c.e.e.k;
				int num3 = default(int);
				while (true)
				{
					int num = 782577029;
					while (true)
					{
						uint num2;
						int num4;
						switch ((num2 = (uint)num ^ 0x196685A5u) % 7u)
						{
						case 6u:
							switch (num3)
							{
							default:
								num = 1186855362;
								continue;
							case 3:
							case 5:
								break;
							case 0:
							case 1:
								return false;
							case 2:
							case 4:
							{
								bool result = q.f;
								global::c.l.x[6] = (global::c.l.x[6] - global::c.l.x[158]) & 8;
								return result;
							}
							}
							goto case 5u;
						case 5u:
						{
							int num5;
							if (f == 30)
							{
								num = 1187398098;
								num5 = 1187398098;
							}
							else
							{
								num = 50417751;
								num5 = 50417751;
							}
							continue;
						}
						case 4u:
							num = (int)((num2 * 1712617587) ^ 0x24C0FFE);
							continue;
						default:
							num4 = array[14] - 11608;
							goto IL_006c;
						case 2u:
							num4 = 2;
							goto IL_006c;
						case 1u:
							num3 = 3;
							num = (int)((num2 * 977342822) ^ 0x7CE1F56B);
							continue;
						case 0u:
							break;
							IL_006c:
							num3 = num4;
							num = 1588861362;
							continue;
						}
						break;
					}
				}
			}
		}

		public bool e => this.m_e.x();

		public p()
		{
			while (true)
			{
				int num = -360853440;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC4549C4Au) % 3u)
					{
					case 2u:
						goto IL_0010;
					default:
						return;
					case 0u:
						break;
					case 1u:
						return;
					}
					break;
					IL_0010:
					q = new e();
					this.m_e = new r(q);
					num = (int)((num2 * 1345287799) ^ 0x28091872);
				}
			}
		}

		public void w()
		{
			f |= 12;
		}

		public void p(byte[] byte_0)
		{
			this.m_e.f(byte_0);
		}

		public int a(byte[] byte_0)
		{
			int[] array = global::c.l.x;
			char[] array2 = global::c.e.e.k;
			int num5 = default(int);
			int num7 = default(int);
			int num9 = default(int);
			int num8 = default(int);
			int num4 = default(int);
			int num6 = default(int);
			while (true)
			{
				int num = -1357190629;
				while (true)
				{
					uint num2;
					int num3;
					int num11;
					long num12;
					switch ((num2 = (uint)num ^ 0xD7CC5253u) % 16u)
					{
					case 15u:
						num5 = 0;
						num7 = byte_0.Length;
						num = -795172281;
						continue;
					default:
						num3 = 5;
						goto IL_0024;
					case 13u:
						goto IL_002f;
					case 12u:
						num = (int)((num2 * 1023350541) ^ 0xCA68E56);
						continue;
					case 11u:
						num = (int)((num2 * 476644893) ^ 0x348101F5);
						continue;
					case 9u:
						while (true)
						{
							switch (num4)
							{
							case 1:
								break;
							case 7:
							case 9:
								goto IL_002f;
							case 18:
								goto IL_006f;
							case 11:
							case 17:
								q.o();
								f = 30;
								num4 = array2[438] - 60739;
								continue;
							case 15:
								goto IL_00b5;
							case 3:
							case 14:
								goto IL_0118;
							case 13:
								if (f != 16)
								{
									num4 = 12;
									goto case 12;
								}
								num4 = 16;
								goto case 16;
							case 12:
								if (f == 20)
								{
									num4 = 8;
									goto case 8;
								}
								num4 = array2[478] - 27418;
								continue;
							case 8:
								num9 = 8 + (-q.d & 7);
								num4 = 10;
								goto case 10;
							case 10:
								num4 = ((num9 > 0) ? (array2[314] - 29851) : (array[130] - array[130]));
								continue;
							case 6:
								q.g(2, 10);
								num9 -= 10;
								num4 = 10;
								goto case 10;
							case 0:
								f = 16;
								num4 = array[119] - 11318;
								continue;
							default:
								goto IL_0223;
							case 2:
								goto IL_022d;
							case 4:
								goto IL_0263;
							case 5:
								return num8 - num7;
							case 16:
								return num8 - num7;
							}
							break;
							IL_0118:
							if (f != 30)
							{
								num4 = 15;
								goto IL_00b5;
							}
							num4 = array2[229] - 801;
							continue;
							IL_00b5:
							r obj = this.m_e;
							int num10 = f;
							global::c.e.e.k[135] = (char)((global::c.e.e.k[135] | global::c.e.e.k[2]) & '°');
							if (!obj.y((num10 & 4) != 0, (f & 8) != 0))
							{
								num4 = array2[307] - 15997;
								continue;
							}
							num4 = 9;
							goto IL_002f;
							IL_006f:
							if (f == 28)
							{
								num4 = array2[339] - 32093;
								continue;
							}
							num4 = 9;
							goto IL_002f;
						}
						goto case 15u;
					case 2u:
						goto IL_022d;
					case 5u:
						goto IL_0263;
					case 8u:
						num4 = 1;
						num = ((int)num2 * -1251636936) ^ 0x49AFD75A;
						continue;
					case 7u:
						num4 = 2;
						num = (int)(num2 * 367659221) ^ -2081107927;
						continue;
					case 6u:
						num = (int)((num2 * 897512560) ^ 0x76C3BE3A);
						continue;
					case 4u:
						num8 = num7;
						num = ((int)num2 * -1445268360) ^ 0x536EA962;
						continue;
					case 3u:
						num5 += num6;
						num = ((int)num2 * -1422953152) ^ 0x497AF4;
						continue;
					case 1u:
						num4 = array[142] - 1415;
						num = ((int)num2 * -1277988974) ^ 0x43F6EEA7;
						continue;
					case 0u:
						num3 = 3;
						goto IL_0024;
					case 10u:
						break;
						IL_0263:
						num7 -= num6;
						if (num7 == 0)
						{
							num = -575037555;
							num11 = -575037555;
						}
						else
						{
							num = -135028397;
							num11 = -135028397;
						}
						continue;
						IL_0024:
						num4 = num3;
						num = -460599896;
						continue;
						IL_022d:
						num12 = this.m_t.b + num6;
						this.m_t.b = num12;
						num4 = array2[531] - 26517;
						num = -717978449;
						continue;
						IL_0223:
						num = -1879883476;
						continue;
						IL_002f:
						num6 = q.o(byte_0, num5, num7);
						num = -1025496240;
						continue;
					}
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static void o<T>(T gparam_0, Size size_0, int int_0, int int_1) where T : Form
		{
			char[] array = global::c.e.e.k;
			int[] array2 = default(int[]);
			int num4 = default(int);
			int num7 = default(int);
			int num5 = default(int);
			int num3 = default(int);
			while (true)
			{
				int num = 990842801;
				while (true)
				{
					uint num2;
					int num9;
					switch ((num2 = (uint)num ^ 0x41EA9A39u) % 10u)
					{
					case 9u:
						num3 = 8;
						num = ((int)num2 * -372453132) ^ 0x2D3ABB0F;
						continue;
					case 8u:
						num = (int)((num2 * 825097477) ^ 0x7BF4B171);
						continue;
					case 7u:
						num9 = array[530] - 35742;
						goto IL_003e;
					case 6u:
						array2 = global::c.l.x;
						num = ((int)num2 * -1018188222) ^ 0x97E9B86;
						continue;
					case 5u:
						switch (((int_1 ^ int_0) - 111) ^ num4)
						{
						default:
							num = 1667359364;
							continue;
						case 0:
							break;
						}
						goto default;
					default:
						num9 = array[265] - 42157;
						goto IL_003e;
					case 4u:
						while (true)
						{
							switch (num3)
							{
							case 4:
								break;
							case 9:
							{
								num7 = num5 + num7;
								int num8 = num7;
								global::c.e.e.k[79] = (char)((global::c.e.e.k[79] + int_1) & 'I');
								if (num8 % 2 == 0)
								{
									num3 = array[344] - 31149;
									continue;
								}
								num3 = 4;
								break;
							}
							case 7:
								num3 = array2[188] - 15088;
								continue;
							case 6:
							{
								int num6 = num5;
								num7 = num6 * num6;
								num3 = 9;
								goto case 9;
							}
							case 0:
							case 5:
								global::c.e.p.smethod_0((Form)(object)gparam_0, size_0);
								goto case 1;
							case 1:
							case 3:
								num4++;
								num5 = 887;
								goto case 6;
							default:
								goto IL_0124;
							case 8:
								goto IL_012b;
							case 2:
								return;
							}
							break;
						}
						goto case 5u;
					case 2u:
						goto IL_012b;
					case 1u:
						num = (int)(num2 * 1641704114) ^ -1803634115;
						continue;
					case 0u:
						break;
						IL_012b:
						num4 = 0;
						num3 = 4;
						num = 318378675;
						continue;
						IL_0124:
						num = 1432097539;
						continue;
						IL_003e:
						num3 = num9;
						num = 1778645806;
						continue;
					}
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static bool l<T, U>(T gparam_0, U gparam_1, int int_0, int int_1) where T : string where U : string
		{
			char[] array = global::c.e.e.k;
			int num4 = default(int);
			int[] array2 = default(int[]);
			int num5 = default(int);
			int num6 = default(int);
			bool result = default(bool);
			int num3 = default(int);
			while (true)
			{
				int num = -1411080585;
				while (true)
				{
					uint num2;
					int num7;
					switch ((num2 = (uint)num ^ 0xF1A9264Du) % 10u)
					{
					case 9u:
						switch (((int_1 ^ int_0) - 111) ^ num4)
						{
						default:
							num = -688598416;
							continue;
						case 0:
							break;
						}
						goto default;
					default:
						num7 = array2[172] - 48868;
						goto IL_0034;
					case 8u:
						goto IL_003f;
					case 7u:
						num7 = 8;
						goto IL_0034;
					case 6u:
						num = (int)((num2 * 437263607) ^ 0x5295DA96);
						continue;
					case 4u:
						array2 = global::c.l.x;
						num = ((int)num2 * -826092520) ^ -1803949847;
						continue;
					case 2u:
						num3 = array[297] - 45206;
						num = (int)((num2 * 981062006) ^ 0x6A78A23F);
						continue;
					case 1u:
						while (true)
						{
							switch (num3)
							{
							case 1:
							case 6:
								break;
							case 4:
								goto IL_003f;
							case 10:
								num4++;
								num5 = 87;
								num6 = 259;
								goto case 7;
							case 7:
								if (2331 <= num6 - num5 * 9)
								{
									num3 = array[557] - 51937;
									continue;
								}
								num3 = 11;
								goto case 11;
							case 8:
								result = false;
								num3 = 10;
								goto case 10;
							case 0:
							case 2:
								result = global::c.e.p.smethod_1((string)gparam_0, (string)gparam_1);
								num3 = 10;
								goto case 10;
							default:
								goto IL_0120;
							case 3:
								goto IL_0127;
							case 5:
								num3 = 1;
								break;
							case 9:
								num3 = 1;
								break;
							case 11:
								return result;
							}
							break;
						}
						goto case 9u;
					case 0u:
						goto IL_0127;
					case 3u:
						break;
						IL_0127:
						num3 = 4;
						num = -1633186376;
						continue;
						IL_0120:
						num = -1442336843;
						continue;
						IL_003f:
						num4 = 0;
						num = -698384955;
						continue;
						IL_0034:
						num3 = num7;
						num = -1633186376;
						continue;
					}
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static ProcessModule x<T>(T gparam_0, char char_0, char char_1) where T : Process
		{
			char[] array = global::c.e.e.k;
			int[] array2 = global::c.l.x;
			int num7 = default(int);
			int num6 = default(int);
			object obj = default(object);
			int num4 = default(int);
			while (true)
			{
				int num = 0;
				int num2 = -1418155428;
				while (true)
				{
					uint num3;
					int num5;
					switch ((num3 = (uint)num2 ^ 0x8CEEC00Au) % 11u)
					{
					default:
						num5 = 3;
						goto IL_0012;
					case 9u:
						num2 = -1406066664;
						continue;
					case 8u:
						while (true)
						{
							switch (num4)
							{
							case 10:
								num7 = 739;
								goto case 4;
							case 4:
								num4 = ((1478 > num7 - num6 * 2) ? (array2[154] - 30109) : (array[32] - 31131));
								continue;
							case 7:
								num++;
								num6 = 120;
								goto case 10;
							case 3:
								obj = global::c.e.p.smethod_2((Process)gparam_0);
								num4 = 7;
								goto case 7;
							case 1:
								obj = null;
								num4 = 7;
								goto case 7;
							case 0:
								num4 = array[104] - 49126;
								continue;
							case 5:
								goto IL_00ca;
							case 6:
								num4 = 11;
								goto IL_00d5;
							case 9:
							case 11:
								goto IL_00d5;
							case 2:
								goto end_IL_013f;
							case 8:
								return obj as ProcessModule;
							}
							break;
						}
						num2 = -134311638;
						continue;
					case 0u:
						goto IL_00ca;
					case 5u:
						goto IL_00d5;
					case 7u:
						num5 = 1;
						goto IL_0012;
					case 6u:
						num2 = (int)((num3 * 266407843) ^ 0x5B088918);
						continue;
					case 4u:
						num2 = ((int)num3 * -2042318291) ^ 0x2AB75C69;
						continue;
					case 3u:
						num4 = 2;
						num2 = (int)((num3 * 1944466926) ^ 0x4FAB61E9);
						continue;
					case 2u:
						num4 = 11;
						num2 = (int)((num3 * 363449399) ^ 0x32E24062);
						continue;
					case 1u:
						break;
						IL_00d5:
						switch (((char_1 ^ char_0) - 83) ^ num)
						{
						case 0:
							break;
						default:
							num2 = -739760082;
							continue;
						}
						goto default;
						IL_00ca:
						num2 = -1092780297;
						continue;
						IL_0012:
						num4 = num5;
						num2 = -442989814;
						continue;
						end_IL_013f:
						break;
					}
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static int b<T>(T gparam_0, short short_0, char char_0) where T : Stream
		{
			char[] array = global::c.e.e.k;
			int[] array2 = default(int[]);
			int result = default(int);
			int num4 = default(int);
			int num3 = default(int);
			while (true)
			{
				int num = -489981160;
				while (true)
				{
					uint num2;
					int num6;
					switch ((num2 = (uint)num ^ 0x869F08A7u) % 11u)
					{
					case 10u:
						array2 = global::c.l.x;
						num = ((int)num2 * -2092284125) ^ -1837554570;
						continue;
					case 9u:
						num3 = 2;
						num = -1982900048;
						continue;
					default:
						num6 = array[314] - 29856;
						goto IL_003c;
					case 7u:
						goto IL_0047;
					case 6u:
						num = ((int)num2 * -1475079794) ^ -843449668;
						continue;
					case 5u:
						num3 = 5;
						num = ((int)num2 * -1489058355) ^ -1324444070;
						continue;
					case 4u:
						num6 = 8;
						goto IL_003c;
					case 3u:
						goto IL_0089;
					case 2u:
						while (true)
						{
							switch (num3)
							{
							case 6:
								break;
							case 5:
								goto IL_0047;
							case 2:
								goto IL_0089;
							case 1:
								result = global::c.e.p.smethod_3((Stream)gparam_0);
								num3 = array2[178] - 14232;
								continue;
							default:
								goto IL_00e0;
							case 3:
								num3 = 5;
								goto IL_0047;
							case 8:
							case 10:
								result = 14;
								goto case 0;
							case 0:
								num3 = 4;
								goto case 4;
							case 4:
							{
								int num5 = num4;
								global::c.l.x[225] = (global::c.l.x[225] + global::c.e.e.k[352]) & 0xF;
								num4 = num5 + 1;
								goto case 9;
							}
							case 9:
								num3 = 7;
								goto case 7;
							case 7:
								return result;
							}
							break;
						}
						goto case 9u;
					case 1u:
						num = ((int)num2 * -1754954549) ^ 0x232BC264;
						continue;
					case 0u:
						break;
						IL_00e0:
						num = -1974616926;
						continue;
						IL_0089:
						num4 = 0;
						num = -1506472780;
						continue;
						IL_0047:
						switch (((short_0 ^ char_0) - 42) ^ num4)
						{
						case 0:
							break;
						default:
							num = -706453707;
							continue;
						}
						goto default;
						IL_003c:
						num3 = num6;
						num = -1982900048;
						continue;
					}
					break;
				}
			}
		}

		static void smethod_0(Form form_0, Size size_0)
		{
			form_0.set_ClientSize(size_0);
		}

		static bool smethod_1(string string_0, string string_1)
		{
			return string_0.StartsWith(string_1);
		}

		static ProcessModule smethod_2(Process process_0)
		{
			return process_0.MainModule;
		}

		static int smethod_3(Stream stream_0)
		{
			return stream_0.ReadByte();
		}
	}

	internal sealed class t
	{
		public sealed class d
		{
			public short[] s;

			public byte[] w;

			public int n;

			public int s;

			private short[] b;

			private int m_l;

			private t v;

			private a.l m_g;

			public d(t t_0, int int_0, int int_1, int int_2)
			{
				while (true)
				{
					int num = -900114531;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0xD1784E82u) % 5u)
						{
						case 4u:
						{
							this.s = new short[int_0];
							object obj = new int[int_2];
							this.m_g.p = obj as int[];
							num = (int)(num2 * 249692955) ^ -1263594904;
							continue;
						}
						case 1u:
							v = t_0;
							num = ((int)num2 * -975192023) ^ 0x461AA793;
							continue;
						case 0u:
							n = int_1;
							this.m_l = int_2;
							num = ((int)num2 * -122705016) ^ -511321713;
							continue;
						default:
							return;
						case 2u:
							break;
						case 3u:
							return;
						}
						break;
					}
				}
			}

			public void w(int int_0)
			{
				v.m.g(b[int_0] & 0xFFFF, this.w[int_0]);
			}

			public void w(short[] short_0, byte[] byte_0)
			{
				b = short_0;
				this.w = byte_0;
			}

			public void g()
			{
				int[] x = global::c.l.x;
				int num8 = default(int);
				char[] k = default(char[]);
				int num4 = default(int);
				int num6 = default(int);
				object obj = default(object);
				int num3 = default(int);
				int num7 = default(int);
				while (true)
				{
					int num = 681373921;
					while (true)
					{
						uint num2;
						int num9;
						switch ((num2 = (uint)num ^ 0x257D09CDu) % 16u)
						{
						case 15u:
						{
							int num10;
							if (num8 < this.m_l)
							{
								num = 506517478;
								num10 = 506517478;
							}
							else
							{
								num = 1373782103;
								num10 = 1373782103;
							}
							continue;
						}
						case 14u:
							goto IL_0030;
						case 13u:
							num3 = x[46] - 43317;
							num = ((int)num2 * -1646822386) ^ -1930469734;
							continue;
						case 12u:
							k = global::c.e.e.k;
							num = ((int)num2 * -1268074244) ^ 0x3E6ACEBD;
							continue;
						default:
							num9 = 5;
							goto IL_0073;
						case 10u:
							num9 = 2;
							goto IL_0073;
						case 8u:
							goto IL_0081;
						case 7u:
							num = (int)(num2 * 697239878) ^ -851858618;
							continue;
						case 6u:
							goto IL_00a1;
						case 5u:
							goto IL_00de;
						case 4u:
							num = (int)((num2 * 372047974) ^ 0x6DBD7694);
							continue;
						case 3u:
							b = new short[this.s.Length];
							num3 = x[208] - 14594;
							num = ((int)num2 * -37802746) ^ -1889768130;
							continue;
						case 2u:
							goto IL_013d;
						case 1u:
							while (true)
							{
								switch (num3)
								{
								case 7:
									break;
								case 14:
									goto IL_0030;
								case 8:
									goto IL_0081;
								case 5:
									goto IL_00a1;
								case 9:
									goto IL_00de;
								case 13:
									goto IL_013d;
								case 1:
								case 12:
									if (num4 >= s)
									{
										int num5 = x[33];
										global::c.e.e.k[226] = (char)((global::c.e.e.k[226] - global::c.e.e.k[305]) & 'X');
										num3 = num5 - 9820;
										continue;
									}
									num3 = 4;
									goto case 4;
								case 4:
									num6 = this.w[num4];
									if (num6 > 0)
									{
										num3 = 6;
										goto case 6;
									}
									num3 = k[27] - 37411;
									continue;
								case 6:
									b[num4] = global::c.e.t.g((obj as int[])[num6 - 1]);
									num3 = 10;
									goto case 10;
								case 10:
									((int[])obj)[num6 - 1] += 1 << 16 - num6;
									num3 = k[570] - 1533;
									continue;
								case 3:
									num4++;
									num3 = 12;
									goto case 1;
								case 0:
								case 2:
									num4 = 0;
									num3 = 12;
									goto case 1;
								default:
									goto IL_0259;
								case 11:
									return;
								}
								break;
							}
							goto case 15u;
						case 0u:
							num3 = 9;
							num = (int)((num2 * 71117944) ^ 0x19D1B0CC);
							continue;
						case 9u:
							break;
							IL_0259:
							num = 1607273448;
							continue;
							IL_013d:
							num3 = 7;
							num = 157869417;
							continue;
							IL_00de:
							obj = new int[this.m_l];
							num7 = 0;
							num = 961943198;
							continue;
							IL_00a1:
							(obj as int[])[num8] = num7;
							num7 += this.m_g.p[num8] << 15 - num8;
							num3 = x[330] - 63419;
							num = 337146426;
							continue;
							IL_0081:
							num8++;
							num = 633636592;
							continue;
							IL_0073:
							num3 = num9;
							num = 741162956;
							continue;
							IL_0030:
							num8 = 0;
							num = 739796287;
							continue;
						}
						break;
					}
				}
			}

			private void l(int[] int_0)
			{
				char[] k = global::c.e.e.k;
				int num16 = default(int);
				int num12 = default(int);
				int num13 = default(int);
				int[] x = default(int[]);
				int num5 = default(int);
				int num9 = default(int);
				int num10 = default(int);
				int num11 = default(int);
				int num4 = default(int);
				int num8 = default(int);
				int num14 = default(int);
				Array array = default(Array);
				int num6 = default(int);
				int num3 = default(int);
				while (true)
				{
					int num = 1143561599;
					while (true)
					{
						uint num2;
						int num15;
						int num17;
						switch ((num2 = (uint)num ^ 0x734E1764u) % 17u)
						{
						case 16u:
							this.m_g.p[num16] = 0;
							num = 121116958;
							continue;
						case 15u:
							goto IL_0023;
						case 14u:
							num = (int)(num2 * 37051356) ^ -332513430;
							continue;
						case 13u:
							num16++;
							num3 = k[285] - 65134;
							num = (int)((num2 * 875798565) ^ 0x3A98FD0C);
							continue;
						case 11u:
							num12 = 0;
							num = ((int)num2 * -502777959) ^ 0x7AD8FA8E;
							continue;
						case 10u:
							num13 = int_0.Length / 2;
							num3 = 30;
							num = (int)(num2 * 1477394980) ^ -928456874;
							continue;
						case 9u:
							num3 = 10;
							num = ((int)num2 * -618178912) ^ 0x6E394CD3;
							continue;
						case 8u:
							goto IL_00c7;
						case 7u:
							num16 = 0;
							num = ((int)num2 * -880682920) ^ 0x7013EFC3;
							continue;
						case 6u:
							num15 = x[88] - 49755;
							goto IL_00f7;
						default:
							num15 = 27;
							goto IL_00f7;
						case 4u:
							x = global::c.l.x;
							num3 = 6;
							num = ((int)num2 * -1664516462) ^ 0x606627C8;
							continue;
						case 3u:
							goto IL_0122;
						case 2u:
							while (true)
							{
								switch (num3)
								{
								case 27:
									break;
								case 10:
									goto IL_0023;
								case 30:
									goto IL_00c7;
								case 6:
									goto IL_0122;
								case 37:
									if (num5 < 0)
									{
										num3 = k[343] - 51250;
										continue;
									}
									num3 = 17;
									goto case 17;
								case 17:
									num3 = ((int_0[2 * num5 + 1] == -1) ? (k[210] - 36240) : (k[152] - 60857));
									continue;
								case 36:
									this.m_g.p[this.m_l - 1] += num12;
									num3 = 15;
									goto case 15;
								case 15:
									this.m_g.p[this.m_l - 2] -= num12;
									num3 = x[318] - 11818;
									continue;
								case 35:
									this.w[int_0[num9]] = (byte)num10;
									goto case 14;
								case 14:
									num11--;
									num3 = k[534] - 6268;
									continue;
								case 34:
									if (num12 <= 0)
									{
										num3 = 36;
										goto case 36;
									}
									num3 = 2;
									goto case 2;
								case 2:
									num3 = ((this.m_g.p[--num4] == 0) ? (k[180] - 31064) : (x[330] - x[330]));
									continue;
								case 33:
									num12 -= 1 << this.m_l - 1 - num4;
									num3 = 11;
									goto case 11;
								case 11:
									num3 = ((num12 <= 0) ? (x[226] - 64322) : (k[52] - 18049));
									continue;
								case 32:
									num10--;
									num3 = 16;
									goto case 16;
								case 16:
									if (num10 != 0)
									{
										num3 = x[81] - 64286;
										continue;
									}
									num3 = 5;
									return;
								case 31:
									num8 = 2 * num14;
									goto case 19;
								case 19:
									num10 = this.m_l;
									num3 = 16;
									goto case 16;
								case 29:
									array = new int[num13];
									(array as int[])[num13 - 1] = 0;
									num3 = 23;
									goto case 12;
								case 12:
								case 23:
									num5 = num13 - 1;
									num3 = 37;
									goto case 37;
								case 28:
									goto IL_030d;
								case 26:
									num6 = this.m_l;
									num12++;
									num3 = k[464] - 24643;
									continue;
								case 25:
									num11 = this.m_g.p[num10 - 1];
									num3 = 9;
									goto case 9;
								case 9:
									num3 = ((num11 > 0) ? (k[131] - 59586) : (x[274] - 32513));
									continue;
								case 24:
									num5--;
									num3 = 37;
									goto case 37;
								case 22:
									num6 = (array as int[])[num5] + 1;
									if (num6 > this.m_l)
									{
										num3 = 26;
										goto case 26;
									}
									num3 = k[336] - 54709;
									continue;
								case 20:
									this.w[int_0[2 * num5]] = (byte)((int[])array)[num5];
									num3 = k[42] - 32179;
									continue;
								case 18:
									this.m_g.p[++num4]++;
									num3 = 33;
									goto case 33;
								case 13:
									num3 = ((int_0[num9 + 1] != -1) ? (x[297] - 25318) : (x[205] - 60866));
									continue;
								case 8:
									num4 = this.m_l - 1;
									num3 = 2;
									goto case 2;
								case 7:
									num9 = 2 * int_0[num8++];
									num3 = 13;
									goto case 13;
								case 4:
								{
									int num7 = (array as int[])[num5];
									this.m_g.p[num7 - 1]++;
									num3 = 20;
									goto case 20;
								}
								case 3:
									goto IL_04c4;
								case 1:
									(array as int[])[int_0[2 * num5]] = (((int[])array)[int_0[2 * num5 + 1]] = num6);
									num3 = 24;
									goto case 24;
								case 0:
									this.m_g.p[num4]--;
									num3 = k[548] - 41370;
									continue;
								default:
									goto IL_05ed;
								case 21:
									return;
								case 5:
									return;
								}
								break;
								IL_04c4:
								num3 = ((num4 < this.m_l - 1) ? (k[493] - 35939) : (k[548] - 41354));
								continue;
								IL_030d:
								num3 = ((num12 != 0) ? (k[414] - 21536) : (k[133] - 26469));
							}
							goto case 16u;
						case 1u:
							num = (int)((num2 * 1930530405) ^ 0x1EB5B964);
							continue;
						case 0u:
							num = ((int)num2 * -1618269193) ^ -701315044;
							continue;
						case 12u:
							break;
							IL_05ed:
							num = 590137847;
							continue;
							IL_0122:
							this.w = new byte[this.s.Length];
							num = 53563400;
							continue;
							IL_00f7:
							num3 = num15;
							num = 809379130;
							continue;
							IL_00c7:
							num14 = (num13 + 1) / 2;
							num = 1709101917;
							continue;
							IL_0023:
							if (num16 < this.m_l)
							{
								num = 1868592444;
								num17 = 1868592444;
							}
							else
							{
								num = 869350422;
								num17 = 869350422;
							}
							continue;
						}
						break;
					}
				}
			}

			public void y()
			{
				int[] x = global::c.l.x;
				char[] k = global::c.e.e.k;
				int num = 34;
				Array array2 = default(Array);
				Array array = default(Array);
				int num11 = default(int);
				int num12 = default(int);
				int num6 = default(int);
				int num22 = default(int);
				int num26 = default(int);
				object obj = default(object);
				int num10 = default(int);
				int num5 = default(int);
				int num19 = default(int);
				int num20 = default(int);
				int num7 = default(int);
				int num17 = default(int);
				int num18 = default(int);
				int num14 = default(int);
				int num15 = default(int);
				int num21 = default(int);
				int num13 = default(int);
				int num16 = default(int);
				int num24 = default(int);
				while (true)
				{
					int num2 = 1900711843;
					while (true)
					{
						uint num3;
						int num4;
						switch ((num3 = (uint)num2 ^ 0x32CE6EBCu) % 13u)
						{
						case 12u:
							num2 = ((int)num3 * -2142958214) ^ 0x380B3F49;
							continue;
						case 11u:
							num = 4;
							num2 = ((int)num3 * -217741583) ^ 0x40C5D2A;
							continue;
						case 10u:
							while (true)
							{
								int num23;
								int num25;
								switch (num)
								{
								case 53:
									if ((array2 as int[])[((int[])array)[num11]] > (array2 as int[])[(array as int[])[num11 + 1]])
									{
										num = 13;
										goto case 13;
									}
									num = 39;
									goto case 39;
								case 13:
									num11++;
									num = 39;
									goto case 39;
								case 39:
									(array as int[])[num12] = ((int[])array)[num11];
									num12 = num11;
									num = 38;
									goto case 38;
								case 38:
									num11 = num11 * 2 + 1;
									num = 19;
									goto case 19;
								case 19:
									if (num11 >= num6)
									{
										num = k[269] - 11142;
										continue;
									}
									num = 45;
									goto case 45;
								case 45:
									num = ((num11 + 1 >= num6) ? (x[111] - 33516) : (x[146] - 49076));
									continue;
								case 52:
									num11++;
									num = 33;
									goto case 33;
								case 33:
									((int[])array)[num12] = (array as int[])[num11];
									num12 = num11;
									num = 40;
									goto case 40;
								case 40:
									num11 = num12 * 2 + 1;
									num = k[201] - 45856;
									continue;
								case 51:
									if (num6 >= 2)
									{
										num = 20;
										goto case 20;
									}
									num = k[40] - 61452;
									continue;
								case 20:
									s = global::c.w.p(num22 + 1, n, 679, 710);
									num = 37;
									goto case 37;
								case 37:
									num26 = num6;
									obj = new int[4 * num6 - 2];
									array2 = new int[2 * num6 - 1];
									num = x[146] - 49082;
									continue;
								case 30:
								case 50:
									num10++;
									num = 7;
									goto case 7;
								case 7:
									num = ((num10 < num5) ? (k[295] - k[295]) : (k[542] - 59080));
									continue;
								case 49:
									(array as int[])[num19] = num10;
									num22 = num10;
									num = 50;
									goto case 30;
								case 48:
									num19 = num6++;
									num = 14;
									goto case 14;
								case 14:
									if (num19 > 0)
									{
										num = 35;
										goto case 35;
									}
									num = 49;
									goto case 49;
								case 35:
									if (this.s[(array as int[])[num20 = (num19 - 1) / 2]] <= num7)
									{
										num = 49;
										goto case 49;
									}
									num = k[539] - 29436;
									continue;
								case 47:
									num17 = num26;
									num18 = 0;
									num = 10;
									goto case 10;
								case 10:
									if (num18 >= num6)
									{
										num = 16;
										goto case 16;
									}
									num = x[64] - 12608;
									continue;
								case 16:
									num14 = (array as int[])[0];
									num15 = ((int[])array)[--num6];
									num = x[274] - 32509;
									continue;
								case 46:
									num21 = ((int[])array)[num18];
									((int[])obj)[2 * num18] = num21;
									num = x[338] - 45944;
									continue;
								case 44:
									if ((array2 as int[])[(array as int[])[num11]] > ((int[])array2)[((int[])array)[num11 + 1]])
									{
										num = k[78] - 20153;
										continue;
									}
									num = 33;
									goto case 33;
								case 43:
									if (num22 >= 2)
									{
										num = 32;
										goto case 32;
									}
									num = k[131] - 59566;
									continue;
								case 32:
									num23 = 0;
									goto IL_02ea;
								case 42:
									if (num11 >= num6)
									{
										num = 28;
										goto case 26;
									}
									num = 3;
									goto case 3;
								case 26:
								case 28:
									num = 22;
									goto case 22;
								case 22:
									if ((num11 = num12) > 0)
									{
										num = 2;
										goto case 2;
									}
									num = 23;
									goto case 23;
								case 2:
									num = ((((int[])array2)[(array as int[])[num12 = (num11 - 1) / 2]] > num13) ? (k[181] - 6777) : (k[333] - 16723));
									continue;
								case 23:
									(array as int[])[num11] = num15;
									goto case 29;
								case 29:
									if (num6 > 1)
									{
										num = 16;
										goto case 16;
									}
									num = 17;
									goto case 17;
								case 3:
									if (num11 + 1 < num6)
									{
										num = 44;
										goto case 44;
									}
									num = 33;
									goto case 33;
								case 41:
									num13 = (array2 as int[])[num15];
									num = 1;
									goto case 1;
								case 1:
									num = (((num11 = num12) <= 0) ? (x[286] - 23161) : (x[309] - 45518));
									continue;
								case 36:
									num12 = 0;
									num11 = 1;
									num = x[84] - 6588;
									continue;
								case 31:
									((int[])obj)[2 * num15 + 1] = num16;
									num24 = global::c.b.y(((int[])array2)[num14] & 0xFF, (array2 as int[])[num16] & 0xFF, 284, 'Ŭ');
									num = 6;
									goto case 6;
								case 6:
									num13 = (((int[])array2)[num15] = (array2 as int[])[num14] + (array2 as int[])[num16] - num24 + 1);
									num = x[41] - 32959;
									continue;
								case 27:
									num23 = ++num22;
									goto IL_02ea;
								case 25:
									(obj as int[])[2 * num18 + 1] = -1;
									(array2 as int[])[num18] = this.s[num21] << 8;
									num = k[594] - 21621;
									continue;
								case 24:
									(array as int[])[num19] = (array as int[])[num20];
									num19 = num20;
									num = 14;
									goto case 14;
								case 21:
									((int[])array)[num18] = num18;
									num18++;
									num = x[112] - 24126;
									continue;
								case 18:
									num12 = 0;
									num11 = 1;
									num = 42;
									goto case 42;
								case 15:
									num15 = num17++;
									(obj as int[])[2 * num15] = num14;
									num = x[173] - 60164;
									continue;
								case 12:
									((int[])array)[num11] = ((int[])array)[num12];
									num = 22;
									goto case 22;
								case 11:
									num = 51;
									goto case 51;
								case 9:
									(array as int[])[num11] = num15;
									num16 = ((int[])array)[0];
									num = k[151] - 3331;
									continue;
								case 8:
									((int[])array)[num11] = ((int[])array)[num12];
									num = 1;
									goto case 1;
								case 5:
									if (((int[])array2)[(array as int[])[num12 = (num11 - 1) / 2]] <= num13)
									{
										num = x[3] - 24219;
										continue;
									}
									num = 8;
									goto case 8;
								case 0:
									goto IL_06b9;
								case 4:
									goto IL_06ce;
								case 34:
									goto IL_06e0;
								case 17:
									{
										l((int[])obj);
										return;
									}
									IL_02ea:
									num25 = num23;
									((int[])array)[num6++] = num25;
									num = x[166] - 64688;
									continue;
								}
								break;
							}
							num2 = 878945178;
							continue;
						case 4u:
							goto IL_06b9;
						case 7u:
							goto IL_06ce;
						case 3u:
							goto IL_06e0;
						case 9u:
						{
							int num8;
							int num9;
							if (num7 != 0)
							{
								num8 = 3522351;
								num9 = 3522351;
							}
							else
							{
								num8 = 691121768;
								num9 = 691121768;
							}
							num2 = num8 ^ (int)(num3 * 1411383932);
							continue;
						}
						default:
							num4 = x[180] - 14298;
							goto IL_0723;
						case 6u:
							num6 = 0;
							num2 = ((int)num3 * -1271842023) ^ 0x61CB659E;
							continue;
						case 5u:
							array = new int[num5];
							num2 = (int)((num3 * 2000802128) ^ 0x1319E9);
							continue;
						case 2u:
							num4 = 48;
							goto IL_0723;
						case 1u:
							num2 = (int)(num3 * 1599498628) ^ -1426383289;
							continue;
						case 0u:
							break;
							IL_0723:
							num = num4;
							num2 = 1900711843;
							continue;
							IL_06b9:
							num7 = this.s[num10];
							num2 = 470953324;
							continue;
							IL_06e0:
							num5 = this.s.Length;
							num2 = 205228163;
							continue;
							IL_06ce:
							num22 = 0;
							num10 = 0;
							num = 7;
							num2 = 892673701;
							continue;
						}
						break;
					}
				}
			}

			public int q()
			{
				int[] x = global::c.l.x;
				char[] k = global::c.e.e.k;
				int num = 0;
				int num6 = default(int);
				int num5 = default(int);
				while (true)
				{
					int num2 = -1641329447;
					while (true)
					{
						uint num3;
						int num4;
						switch ((num3 = (uint)num2 ^ 0xF8A9F0A9u) % 13u)
						{
						case 12u:
						{
							int num7;
							if (num6 >= this.s.Length)
							{
								num2 = -507958145;
								num7 = -507958145;
							}
							else
							{
								num2 = -1944295594;
								num7 = -1944295594;
							}
							continue;
						}
						default:
							num4 = k[232] - 28562;
							goto IL_0048;
						case 10u:
							num = k[10] - 38278;
							num2 = (int)(num3 * 416088375) ^ -344104952;
							continue;
						case 9u:
							goto IL_0070;
						case 8u:
							switch (num)
							{
							case 1:
							case 5:
								break;
							case 0:
								goto IL_0070;
							default:
								goto IL_00a6;
							case 2:
								goto IL_00ad;
							case 3:
								goto IL_00c2;
							case 4:
								goto IL_00cb;
							case 6:
								goto IL_00ea;
							case 7:
								return num5;
							}
							goto case 12u;
						case 2u:
							goto IL_00ad;
						case 7u:
							goto IL_00c2;
						case 1u:
							goto IL_00cb;
						case 4u:
							goto IL_00ea;
						case 6u:
							num2 = (int)((num3 * 771588928) ^ 0x59D8F699);
							continue;
						case 5u:
							num4 = 7;
							goto IL_0048;
						case 3u:
							num2 = ((int)num3 * -1275666335) ^ 0x6CCFF1FF;
							continue;
						case 0u:
							break;
							IL_00ea:
							num6++;
							num2 = -1082091874;
							continue;
							IL_00cb:
							num5 += this.s[num6] * this.w[num6];
							num2 = -901537173;
							continue;
							IL_00c2:
							num = 6;
							num2 = -1641329447;
							continue;
							IL_00ad:
							num = x[137] - 55308;
							num2 = -937545244;
							continue;
							IL_00a6:
							num2 = -717438410;
							continue;
							IL_0070:
							num5 = 0;
							num6 = 0;
							num2 = -2122415284;
							continue;
							IL_0048:
							num = num4;
							num2 = -1658251697;
							continue;
						}
						break;
					}
				}
			}

			public void u(d d_0)
			{
				int[] x = global::c.l.x;
				char[] k = default(char[]);
				int num10 = default(int);
				int num7 = default(int);
				int num9 = default(int);
				int num4 = default(int);
				int num5 = default(int);
				int num6 = default(int);
				int num3 = default(int);
				while (true)
				{
					int num = 1243812574;
					while (true)
					{
						uint num2;
						int num11;
						switch ((num2 = (uint)num ^ 0x2BE443A5u) % 12u)
						{
						case 11u:
							k = global::c.e.e.k;
							num3 = 6;
							num = ((int)num2 * -1104664852) ^ -437569303;
							continue;
						default:
							num11 = 0;
							goto IL_0028;
						case 8u:
							num10 = 1;
							num = 2060312478;
							continue;
						case 7u:
							num7 = this.w[num9];
							num = (int)((num2 * 1959384646) ^ 0x6A005DDE);
							continue;
						case 6u:
							goto IL_005c;
						case 5u:
						{
							int num12;
							int num13;
							if (num7 != 0)
							{
								num12 = -1962147089;
								num13 = -1962147089;
							}
							else
							{
								num12 = -1295614754;
								num13 = -1295614754;
							}
							num = num12 ^ ((int)num2 * -1389028176);
							continue;
						}
						case 4u:
							num = (int)(num2 * 1882227834) ^ -1871679011;
							continue;
						case 3u:
							num11 = 19;
							goto IL_0028;
						case 2u:
							num9 = 0;
							num3 = x[280] - 31404;
							num = ((int)num2 * -960772502) ^ 0x7BFEC831;
							continue;
						case 1u:
							num = (int)(num2 * 97917273) ^ -740339132;
							continue;
						case 0u:
							while (true)
							{
								switch (num3)
								{
								case 11:
									break;
								case 6:
									goto IL_005c;
								case 21:
									d_0.s[17]++;
									num3 = k[559] - 25042;
									continue;
								case 20:
									d_0.s[18]++;
									num3 = 15;
									goto case 15;
								case 15:
									if (num9 >= s)
									{
										num3 = k[458] - 46456;
										continue;
									}
									num3 = 11;
									break;
								case 19:
									num4 = 138;
									num5 = 3;
									num3 = 16;
									goto case 16;
								case 16:
									num6 = num7;
									num9++;
									num3 = 10;
									goto case 10;
								case 17:
									if (num6 == this.w[num9])
									{
										num3 = 1;
										goto case 1;
									}
									num3 = 13;
									goto case 13;
								case 1:
									num9++;
									goto case 2;
								case 2:
									if (++num10 < num4)
									{
										num3 = 10;
										goto case 10;
									}
									num3 = 13;
									goto case 13;
								case 10:
									if (num9 < s)
									{
										num3 = 17;
										goto case 17;
									}
									num3 = 13;
									goto case 13;
								case 13:
									if (num10 < num5)
									{
										num3 = 4;
										goto case 4;
									}
									num3 = k[352] - 24155;
									continue;
								case 4:
								case 18:
									d_0.s[num6] += (short)num10;
									num3 = 15;
									goto case 15;
								case 14:
									num10 = 0;
									num3 = 16;
									goto case 16;
								case 12:
									if (num10 <= 10)
									{
										num3 = 21;
										goto case 21;
									}
									num3 = 20;
									goto case 20;
								case 9:
									d_0.s[16]++;
									num3 = 15;
									goto case 15;
								case 8:
									num3 = 14;
									goto case 14;
								case 7:
									if (num6 != 0)
									{
										num3 = 9;
										goto case 9;
									}
									num3 = 12;
									goto case 12;
								case 3:
									d_0.s[num7]++;
									goto case 8;
								case 0:
								{
									num4 = 6;
									num5 = 3;
									if (num6 != num7)
									{
										num3 = 3;
										goto case 3;
									}
									int num8 = x[288];
									global::c.e.e.k[62] = (char)((global::c.e.e.k[62] - global::c.e.e.k[70]) & 'w');
									num3 = num8 - 25769;
									continue;
								}
								default:
									goto IL_0301;
								case 5:
									return;
								}
								break;
							}
							goto case 8u;
						case 9u:
							break;
							IL_0301:
							num = 1506288759;
							continue;
							IL_0028:
							num3 = num11;
							num = 424690260;
							continue;
							IL_005c:
							num6 = -1;
							num = 383478611;
							continue;
						}
						break;
					}
				}
			}

			public void i(d d_0)
			{
				char[] k = global::c.e.e.k;
				int[] x = global::c.l.x;
				int num8 = default(int);
				int num9 = default(int);
				int num7 = default(int);
				int num10 = default(int);
				int num6 = default(int);
				int num5 = default(int);
				int num4 = default(int);
				while (true)
				{
					int num = 1299529480;
					while (true)
					{
						uint num2;
						int num3;
						switch ((num2 = (uint)num ^ 0x72F0BA85u) % 11u)
						{
						case 10u:
							num4 = k[344] - 31133;
							num = ((int)num2 * -1366174083) ^ -294485554;
							continue;
						case 9u:
						{
							num8 = this.w[num9];
							int num11;
							int num12;
							if (num8 == 0)
							{
								num11 = 1477682013;
								num12 = 1477682013;
							}
							else
							{
								num11 = 418776850;
								num12 = 418776850;
							}
							num = num11 ^ (int)(num2 * 1310518457);
							continue;
						}
						default:
							num3 = 21;
							goto IL_0066;
						case 7u:
							num9 = 0;
							num = (int)((num2 * 995944743) ^ 0x9CF925A);
							continue;
						case 6u:
							num4 = 23;
							num = (int)(num2 * 587839563) ^ -395298467;
							continue;
						case 5u:
							while (true)
							{
								switch (num4)
								{
								case 3:
								case 22:
									num7 = num8;
									num9++;
									num4 = 4;
									goto case 4;
								case 4:
									num4 = ((num9 >= s) ? (x[132] - 34348) : (x[222] - 29367));
									continue;
								case 21:
									num10 = 6;
									num6 = 3;
									if (num7 != num8)
									{
										num4 = 15;
										goto case 15;
									}
									num4 = 22;
									goto case 3;
								case 15:
									d_0.w(num8);
									num5 = 0;
									num4 = x[194] - 5260;
									continue;
								case 20:
									break;
								case 19:
									d_0.w(18);
									v.m.g(num5 - 11, 7);
									goto case 18;
								case 18:
									if (num9 < s)
									{
										num4 = k[370] - 23612;
										continue;
									}
									num4 = 8;
									return;
								case 14:
									if (num5-- > 0)
									{
										num4 = 17;
										goto case 5;
									}
									num4 = k[487] - 18989;
									continue;
								case 5:
								case 17:
									d_0.w(num7);
									goto case 14;
								case 16:
									d_0.w(16);
									v.m.g(num5 - 3, 2);
									num4 = 18;
									goto case 18;
								case 13:
									num9++;
									if (++num5 < num10)
									{
										num4 = 4;
										goto case 4;
									}
									num4 = k[413] - 52342;
									continue;
								case 12:
									num10 = 138;
									num6 = 3;
									num4 = 22;
									goto case 3;
								case 11:
									if (num5 <= 10)
									{
										num4 = 1;
										goto case 1;
									}
									num4 = 19;
									goto case 19;
								case 1:
									d_0.w(17);
									goto case 10;
								case 10:
									v.m.g(num5 - 3, 3);
									num4 = 18;
									goto case 18;
								case 9:
									num4 = 18;
									goto case 18;
								case 7:
									goto IL_0237;
								case 6:
									num4 = 14;
									goto case 14;
								case 2:
									if (num5 < num6)
									{
										num4 = 6;
										goto case 6;
									}
									num4 = 20;
									break;
								default:
									goto end_IL_0278;
								case 0:
									goto IL_02e5;
								case 23:
									goto IL_02ef;
								case 8:
									return;
								}
								num4 = ((num7 == 0) ? (x[282] - 29663) : (x[183] - 6699));
								continue;
								IL_0237:
								num4 = ((num7 == this.w[num9]) ? (k[97] - 23332) : (k[99] - 59248));
								continue;
								end_IL_0278:
								break;
							}
							num = 881692542;
							continue;
						case 1u:
							goto IL_02e5;
						case 4u:
							goto IL_02ef;
						case 3u:
							num = (int)(num2 * 1133662414) ^ -1056287590;
							continue;
						case 2u:
							num3 = k[317] - 2795;
							goto IL_0066;
						case 0u:
							break;
							IL_02ef:
							num7 = -1;
							num = 1506551280;
							continue;
							IL_02e5:
							num5 = 1;
							num = 407619709;
							continue;
							IL_0066:
							num4 = num3;
							num = 1257770521;
							continue;
						}
						break;
					}
				}
			}
		}

		private const int m_c = 16384;

		private const int l = 286;

		private const int m = 30;

		private const int m_d = 19;

		private const int b = 16;

		private const int m_k = 17;

		private const int m_g = 18;

		private const int e = 256;

		private static readonly int[] m_f;

		private static readonly byte[] m_k;

		private e m;

		private d m_p;

		private d b;

		private d u;

		private int i;

		private int v;

		private static readonly short[] m_x;

		private static readonly byte[] m_t;

		private static readonly short[] m_d;

		private static readonly byte[] m_f;

		private n.l w = new n.l();

		static t()
		{
			int[] array = global::c.l.x;
			char[] array2 = global::c.e.e.k;
			int num = 7;
			int num4 = default(int);
			while (true)
			{
				int num2 = 781162670;
				while (true)
				{
					uint num3;
					int num6;
					int num5;
					switch ((num3 = (uint)num2 ^ 0x4FC69CE4u) % 14u)
					{
					case 13u:
					{
						int[] array_ = new int[19];
						global::c.e.t.smethod_0((Array)array_, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
						global::c.e.t.m_f = array_;
						byte[] array_2 = new byte[16];
						global::c.e.t.smethod_0((Array)array_2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
						global::c.e.t.m_k = array_2;
						num = 18;
						num2 = 781162670;
						continue;
					}
					case 12u:
						num6 = 12;
						goto IL_0050;
					default:
						num6 = array2[271] - 26;
						goto IL_0050;
					case 10u:
						goto IL_0067;
					case 9u:
						goto IL_008f;
					case 8u:
						num2 = ((int)num3 * -1348365932) ^ 0x41D420FE;
						continue;
					case 6u:
						goto IL_00bf;
					case 5u:
						num2 = ((int)num3 * -1891403915) ^ 0x3F4638DF;
						continue;
					case 4u:
						while (true)
						{
							switch (num)
							{
							case 7:
								break;
							case 18:
								goto IL_0067;
							case 3:
								goto IL_008f;
							case 15:
								goto IL_00bf;
							case 19:
								if (num4 >= 256)
								{
									num = 10;
									goto case 10;
								}
								num = array[204] - 44022;
								continue;
							case 10:
								num = 6;
								goto case 6;
							case 6:
								num = ((num4 < 280) ? (array2[2] - 33245) : (array[265] - 17908));
								continue;
							case 17:
								global::c.e.t.m_f[num4] = 5;
								num = 11;
								goto case 11;
							case 11:
								num4++;
								num = 9;
								goto case 9;
							case 9:
								if (num4 < 30)
								{
									num = array2[233] - 57764;
									continue;
								}
								num = 20;
								return;
							case 16:
								if (num4 >= 286)
								{
									num = 2;
									goto case 2;
								}
								num = 1;
								goto case 1;
							case 2:
							case 13:
								global::c.e.t.m_d = new short[30];
								global::c.e.t.m_f = new byte[30];
								goto case 0;
							case 0:
								num4 = 0;
								num = array[35] - 15049;
								continue;
							case 1:
								global::c.e.t.m_x[num4] = g(-88 + num4 << 8);
								m_t[num4++] = 8;
								num = array2[462] - 38567;
								continue;
							case 14:
								num = array2[561] - 59172;
								continue;
							case 12:
								num = array[77] - 22964;
								continue;
							case 8:
								global::c.e.t.m_x[num4] = g(-256 + num4 << 9);
								m_t[num4++] = 7;
								num = 6;
								goto case 6;
							case 5:
								global::c.e.t.m_x[num4] = g(256 + num4 << 7);
								m_t[num4++] = 9;
								num = 19;
								goto case 19;
							case 4:
								global::c.e.t.m_d[num4] = g(num4 << 11);
								goto case 17;
							default:
								goto IL_02c9;
							case 20:
								return;
							}
							break;
						}
						goto case 13u;
					case 3u:
						m_t[num4++] = 8;
						num2 = ((int)num3 * -1812928954) ^ -1390722466;
						continue;
					case 2u:
						num = array[277] - 53059;
						num2 = ((int)num3 * -2125105619) ^ 0x500A8DE0;
						continue;
					case 1u:
						num4 = 0;
						num = 15;
						num2 = (int)(num3 * 1447413598) ^ -1512561126;
						continue;
					case 0u:
						num2 = (int)(num3 * 1152662499) ^ -1308217910;
						continue;
					case 7u:
						break;
						IL_02c9:
						num2 = 1725524927;
						continue;
						IL_00bf:
						if (num4 < 144)
						{
							num2 = 828746265;
							num5 = 828746265;
						}
						else
						{
							num2 = 1868375358;
							num5 = 1868375358;
						}
						continue;
						IL_0050:
						num = num6;
						num2 = 980516201;
						continue;
						IL_008f:
						global::c.e.t.m_x[num4] = g(48 + num4 << 8);
						num2 = 1304729959;
						continue;
						IL_0067:
						global::c.e.t.m_x = new short[286];
						m_t = new byte[286];
						num2 = 785903927;
						continue;
					}
					break;
				}
			}
		}

		public t(e e_0)
		{
			m = e_0;
			this.m_p = new d(this, 286, 257, 15);
			b = new d(this, 30, 1, 15);
			u = new d(this, 19, 4, 7);
			Array array = new short[16384];
			w.w = array as short[];
			object obj = new byte[16384];
			w.n = (byte[])obj;
		}

		public static short g(int int_0)
		{
			return (short)((global::c.e.t.m_k[int_0 & 0xF] << 12) | (global::c.e.t.m_k[(int_0 >> 4) & 0xF] << 8) | (global::c.e.t.m_k[(int_0 >> 8) & 0xF] << 4) | global::c.e.t.m_k[int_0 >> 12]);
		}

		public void p()
		{
			i = 0;
			v = 0;
		}

		private int y(int int_0)
		{
			char[] array = global::c.e.e.k;
			int[] array2 = default(int[]);
			int num4 = default(int);
			int num3 = default(int);
			while (true)
			{
				int num = 1284800007;
				while (true)
				{
					uint num2;
					int num7;
					switch ((num2 = (uint)num ^ 0x462BD0BAu) % 8u)
					{
					case 6u:
						num7 = 5;
						goto IL_000c;
					case 5u:
						array2 = global::c.l.x;
						num = ((int)num2 * -11647552) ^ 0x62B028FB;
						continue;
					case 4u:
					{
						int num8;
						if (int_0 != 255)
						{
							num = 1824216881;
							num8 = 1824216881;
						}
						else
						{
							num = 1538835988;
							num8 = 1538835988;
						}
						continue;
					}
					default:
						num7 = array[250] - 17125;
						goto IL_000c;
					case 2u:
						num = ((int)num2 * -688094769) ^ -268939924;
						continue;
					case 1u:
						num3 = 4;
						num = (int)(num2 * 1879321021) ^ -1565346433;
						continue;
					case 0u:
						while (true)
						{
							switch (num3)
							{
							case 0:
							case 1:
							case 4:
								break;
							case 2:
							case 8:
								num4 = 257;
								num3 = 7;
								goto case 7;
							case 7:
								if (int_0 < 8)
								{
									num3 = array[159] - 27410;
									continue;
								}
								num3 = 3;
								goto case 3;
							case 3:
								num4 += 4;
								int_0 >>= 1;
								num3 = array2[306] - 34802;
								continue;
							default:
								goto IL_00e6;
							case 5:
								return 285;
							case 6:
							{
								int num5 = num4;
								int num6 = int_0;
								global::c.e.e.k[511] = (char)(global::c.e.e.k[511] & int_0 & '2');
								return num5 + num6;
							}
							}
							break;
						}
						goto case 4u;
					case 7u:
						break;
						IL_00e6:
						num = 262840974;
						continue;
						IL_000c:
						num3 = num7;
						num = 1896714440;
						continue;
					}
					break;
				}
			}
		}

		private int q(int int_0)
		{
			char[] array = global::c.e.e.k;
			int num4 = default(int);
			int num3 = default(int);
			int[] array2 = default(int[]);
			while (true)
			{
				int num = 1577917261;
				while (true)
				{
					uint num2;
					int num5;
					int num6;
					switch ((num2 = (uint)num ^ 0x50267818u) % 13u)
					{
					case 12u:
						num4 = 0;
						num = 290107883;
						continue;
					case 11u:
						num3 = 4;
						num = (int)((num2 * 1606087168) ^ 0x71707622);
						continue;
					case 10u:
						num3 = array[548] - 41388;
						num = ((int)num2 * -727370487) ^ 0x6D3B4A9;
						continue;
					case 9u:
						num5 = 3;
						goto IL_004d;
					case 8u:
						int_0 >>= 1;
						num3 = array2[274] - 32545;
						num = ((int)num2 * -339111306) ^ -1500218147;
						continue;
					case 6u:
						goto IL_007f;
					case 5u:
						num = (int)((num2 * 1705882725) ^ 0x78920A09);
						continue;
					case 4u:
						num = (int)((num2 * 1069029967) ^ 0x35226464);
						continue;
					case 3u:
						goto IL_00ad;
					default:
						num5 = array2[122] - 5548;
						goto IL_004d;
					case 1u:
						array2 = global::c.l.x;
						num = (int)(num2 * 881018763) ^ -74916478;
						continue;
					case 0u:
						switch (num3)
						{
						case 4:
							break;
						case 1:
							goto IL_007f;
						case 0:
						case 5:
							goto IL_00ad;
						default:
							goto IL_0110;
						case 2:
						case 3:
						case 6:
							return num4 + int_0;
						}
						goto case 12u;
					case 7u:
						break;
						IL_0110:
						num = 475250373;
						continue;
						IL_00ad:
						if (int_0 < 4)
						{
							num = 944191948;
							num6 = 944191948;
						}
						else
						{
							num = 1746821129;
							num6 = 1746821129;
						}
						continue;
						IL_007f:
						num4 += 2;
						num = 1437934823;
						continue;
						IL_004d:
						num3 = num5;
						num = 1200564162;
						continue;
					}
					break;
				}
			}
		}

		public void k(int int_0)
		{
			int[] array = global::c.l.x;
			int num5 = default(int);
			int num3 = default(int);
			char[] array2 = default(char[]);
			while (true)
			{
				int num = 1997360639;
				while (true)
				{
					uint num2;
					int num4;
					int num6;
					switch ((num2 = (uint)num ^ 0x2BF09E7Bu) % 19u)
					{
					case 18u:
						m.g(u.w[global::c.e.t.m_f[num5]], 3);
						num = 1520250227;
						continue;
					case 17u:
						goto IL_0034;
					case 16u:
						goto IL_0066;
					case 15u:
						this.m_p.g();
						b.g();
						num = ((int)num2 * -172020693) ^ 0x4101C6C2;
						continue;
					case 13u:
						switch (num3)
						{
						case 9:
							break;
						case 5:
						case 6:
							goto IL_0034;
						case 3:
							goto IL_0066;
						default:
							goto IL_00dc;
						case 2:
							goto IL_00e6;
						case 4:
							goto IL_010d;
						case 7:
							goto IL_011d;
						case 0:
						case 8:
							goto IL_0132;
						case 1:
							this.m_p.i(u);
							b.i(u);
							return;
						}
						goto case 18u;
					case 4u:
						goto IL_00e6;
					case 12u:
						goto IL_010d;
					case 1u:
						goto IL_011d;
					case 9u:
						goto IL_0132;
					case 11u:
						num3 = 8;
						num = ((int)num2 * -2113228425) ^ 0x60B2FDB;
						continue;
					case 10u:
						num3 = array[1] - 15270;
						num = (int)(num2 * 179796893) ^ -3320161;
						continue;
					default:
						num4 = array[271] - 2079;
						goto IL_0186;
					case 7u:
						array2 = global::c.e.e.k;
						num = ((int)num2 * -197274588) ^ 0x462B4B82;
						continue;
					case 6u:
						num4 = array2[539] - 29459;
						goto IL_0186;
					case 5u:
						num3 = 5;
						num = (int)((num2 * 1943808690) ^ 0x2CDFA98D);
						continue;
					case 3u:
						num = ((int)num2 * -1787842906) ^ -421136137;
						continue;
					case 2u:
						num3 = 7;
						num = ((int)num2 * -696405793) ^ -553212672;
						continue;
					case 0u:
						num = (int)(num2 * 1330317674) ^ -1274324261;
						continue;
					case 14u:
						break;
						IL_0186:
						num3 = num4;
						num = 1100339259;
						continue;
						IL_0132:
						num5 = 0;
						num3 = array[168] - 30450;
						num = 1875834231;
						continue;
						IL_011d:
						u.g();
						num = 753420467;
						continue;
						IL_010d:
						num5++;
						num3 = 3;
						num = 808385093;
						continue;
						IL_00e6:
						m.g(this.m_p.s - 257, 5);
						num = 147830718;
						continue;
						IL_00dc:
						num = 1073523904;
						continue;
						IL_0066:
						if (num5 >= int_0)
						{
							num = 1786736600;
							num6 = 1786736600;
						}
						else
						{
							num = 1253894222;
							num6 = 1253894222;
						}
						continue;
						IL_0034:
						m.g(b.s - 1, 5);
						m.g(int_0 - 4, 4);
						num = 1308941263;
						continue;
					}
					break;
				}
			}
		}

		public void x()
		{
			char[] array = global::c.e.e.k;
			int num9 = default(int);
			int[] array2 = default(int[]);
			int num7 = default(int);
			int num4 = default(int);
			int num3 = default(int);
			int num5 = default(int);
			while (true)
			{
				int num = -531242168;
				while (true)
				{
					uint num2;
					int num6;
					int num11;
					switch ((num2 = (uint)num ^ 0xB3D739CAu) % 14u)
					{
					case 12u:
						num6 = 1;
						goto IL_000c;
					case 11u:
						while (true)
						{
							switch (num5)
							{
							case 16:
								if (num9 > 5)
								{
									num5 = array2[180] - 14333;
									continue;
								}
								num5 = 13;
								goto case 13;
							case 8:
								num5 = ((num9 <= 0) ? (array2[127] - 318) : (array2[92] - 15773));
								continue;
							case 1:
							{
								int num8 = y(num7);
								this.m_p.w(num8);
								num9 = (num8 - 261) / 4;
								num5 = 8;
								goto case 8;
							}
							case 4:
								goto IL_00c9;
							case 5:
								this.m_p.w(num7);
								goto case 11;
							case 12:
							case 14:
								goto IL_00e8;
							case 13:
								m.g(num7 & ((1 << num9) - 1), num9);
								goto case 15;
							case 15:
							{
								int num10 = q(num4);
								b.w(num10);
								num9 = num10 / 2 - 1;
								num5 = 7;
								goto case 7;
							}
							case 7:
								if (num9 > 0)
								{
									num5 = 2;
									goto case 2;
								}
								num5 = 11;
								goto case 11;
							case 2:
							case 10:
								m.g(num4 & ((1 << num9) - 1), num9);
								num5 = 11;
								goto case 11;
							case 11:
								num3++;
								num5 = 9;
								goto case 9;
							case 9:
								if (num3 < i)
								{
									num5 = 3;
									goto IL_018a;
								}
								num5 = 0;
								goto case 0;
							case 3:
							case 6:
								goto IL_018a;
							case 0:
								this.m_p.w(256);
								return;
							}
							break;
						}
						num = -1088243029;
						continue;
					case 3u:
						goto IL_00c9;
					case 10u:
						goto IL_00e8;
					case 5u:
						goto IL_018a;
					default:
						num6 = 5;
						goto IL_000c;
					case 8u:
						array2 = global::c.l.x;
						num = (int)((num2 * 248267373) ^ 0x3CF93292);
						continue;
					case 7u:
						num5 = 12;
						num = (int)((num2 * 1150984324) ^ 0x24FFCC1C);
						continue;
					case 6u:
						num5 = array[295] - 35179;
						num = ((int)num2 * -904043935) ^ -2054675176;
						continue;
					case 4u:
						num5 = 4;
						num = (int)((num2 * 257568812) ^ 0x53747DF);
						continue;
					case 2u:
						num = ((int)num2 * -464974841) ^ 0x1B8D0B41;
						continue;
					case 1u:
						num4 = w.w[num3];
						num = ((int)num2 * -1782473455) ^ -649518162;
						continue;
					case 0u:
						num = ((int)num2 * -407170741) ^ -835687415;
						continue;
					case 13u:
						break;
						IL_00e8:
						if (num4-- != 0)
						{
							num = -817636894;
							num11 = -817636894;
						}
						else
						{
							num = -1666784137;
							num11 = -1666784137;
						}
						continue;
						IL_000c:
						num5 = num6;
						num = -762040441;
						continue;
						IL_00c9:
						num3 = 0;
						num = -1804310542;
						continue;
						IL_018a:
						num7 = w.n[num3] & 0xFF;
						num = -521544343;
						continue;
					}
					break;
				}
			}
		}

		public void p(byte[] byte_0, int int_0, int int_1, bool bool_0)
		{
			int num = 3;
			while (true)
			{
				int num2 = -1839171407;
				while (true)
				{
					uint num3;
					e obj;
					switch ((num3 = (uint)num2 ^ 0x92EA019Bu) % 8u)
					{
					case 7u:
						num = 4;
						num2 = -949213553;
						continue;
					case 5u:
						p();
						num2 = ((int)num3 * -866534269) ^ -779607532;
						continue;
					case 4u:
						num2 = ((int)num3 * -373831804) ^ 0x16B8CAE1;
						continue;
					case 3u:
						goto IL_003d;
					case 2u:
						switch (num)
						{
						case 1:
						case 2:
							break;
						case 4:
							goto IL_003d;
						default:
							goto IL_006c;
						case 0:
						case 3:
							goto IL_0073;
						}
						goto case 7u;
					case 1u:
						goto IL_0073;
					default:
						return;
					case 6u:
						break;
					case 0u:
						return;
						IL_0073:
						m.g(bool_0 ? 1 : 0, 3);
						m.o();
						m.c(int_1);
						obj = m;
						global::c.e.e.k[571] = (char)((global::c.e.e.k[571] ^ int_0) & 'F');
						obj.c(~int_1);
						num2 = -1200229548;
						continue;
						IL_006c:
						num2 = -1959433518;
						continue;
						IL_003d:
						m.c(byte_0, int_0, int_1);
						num2 = -1398200978;
						continue;
					}
					break;
				}
			}
		}

		public void x(byte[] byte_0, int int_0, int int_1, bool bool_0)
		{
			int[] array = global::c.l.x;
			char[] array2 = global::c.e.e.k;
			int num10 = default(int);
			int num9 = default(int);
			int num8 = default(int);
			int num7 = default(int);
			int num5 = default(int);
			int num6 = default(int);
			int num3 = default(int);
			while (true)
			{
				int num = 1000020674;
				while (true)
				{
					uint num2;
					int num4;
					int num11;
					switch ((num2 = (uint)num ^ 0x6BE96529u) % 16u)
					{
					case 15u:
						num = ((int)num2 * -634032785) ^ 0x7132651D;
						continue;
					default:
						num4 = 1;
						goto IL_0024;
					case 13u:
						this.m_p.y();
						b.y();
						this.m_p.u(u);
						num = 798742379;
						continue;
					case 12u:
						goto IL_0060;
					case 11u:
						num3 = 23;
						num = ((int)num2 * -1180934863) ^ -2034998137;
						continue;
					case 10u:
						num = ((int)num2 * -272474549) ^ 0x141F0D92;
						continue;
					case 9u:
						num3 = 5;
						num = ((int)num2 * -2048400419) ^ -929857210;
						continue;
					case 8u:
						goto IL_00a8;
					case 7u:
						num = ((int)num2 * -690628550) ^ -1028994006;
						continue;
					case 5u:
						while (true)
						{
							switch (num3)
							{
							case 10:
								break;
							case 20:
								goto IL_0060;
							case 8:
								goto IL_00a8;
							case 27:
								num10++;
								num3 = 21;
								goto case 21;
							case 21:
								if (num10 >= 286)
								{
									num3 = array[122] - 5531;
									continue;
								}
								num3 = 16;
								goto case 16;
							case 16:
								num9 += this.m_p.s[num10] * m_t[num10];
								num3 = array[309] - 45496;
								continue;
							case 26:
								if (int_0 < 0)
								{
									num3 = array2[528] - 15880;
									continue;
								}
								num3 = 3;
								goto case 3;
							case 25:
								num9 = v;
								num10 = 0;
								num3 = array[209] - 38768;
								continue;
							case 19:
								num8++;
								num3 = 9;
								goto case 9;
							case 9:
								if (num8 >= 30)
								{
									num3 = 4;
									goto case 4;
								}
								num3 = 15;
								goto case 15;
							case 4:
							case 17:
								if (num7 >= num9)
								{
									num3 = 14;
									goto case 14;
								}
								num3 = array[111] - 33529;
								continue;
							case 14:
								num7 = num9;
								num3 = 26;
								goto case 26;
							case 15:
								num9 += b.s[num8] * global::c.e.t.m_f[num8];
								num3 = array[232] - 42300;
								continue;
							case 18:
								num8 = 0;
								num3 = array[75] - 36169;
								continue;
							case 7:
								if (num5 <= num6)
								{
									num3 = 2;
									goto case 2;
								}
								num3 = 28;
								goto IL_0309;
							case 2:
								num7 = 14 + num6 * 3 + u.q() + this.m_p.q() + b.q() + v;
								num3 = array[277] - 53049;
								continue;
							case 6:
								num6 = num5 + 1;
								num3 = 1;
								goto case 1;
							case 1:
								num5--;
								num3 = array[22] - 24264;
								continue;
							default:
								goto IL_02c0;
							case 5:
								goto IL_02ca;
							case 23:
								goto IL_02dc;
							case 28:
								goto IL_0309;
							case 3:
								if (int_1 + 4 < num7 >> 3)
								{
									num3 = 24;
									goto case 24;
								}
								num3 = 13;
								goto case 13;
							case 24:
								p(byte_0, int_0, int_1, bool_0);
								return;
							case 13:
								if (num7 == num9)
								{
									num3 = 11;
									goto case 11;
								}
								num3 = 12;
								goto case 12;
							case 11:
								m.g(2 + (bool_0 ? 1 : 0), 3);
								this.m_p.w(global::c.e.t.m_x, m_t);
								goto case 22;
							case 22:
								b.w(global::c.e.t.m_d, global::c.e.t.m_f);
								num3 = 0;
								goto case 0;
							case 0:
								x();
								p();
								return;
							case 12:
								m.g(4 + (bool_0 ? 1 : 0), 3);
								k(num6);
								x();
								p();
								return;
							}
							break;
						}
						goto case 13u;
					case 4u:
						goto IL_02ca;
					case 0u:
						goto IL_02dc;
					case 1u:
						goto IL_0309;
					case 3u:
						num4 = 6;
						goto IL_0024;
					case 2u:
						num3 = 8;
						num = ((int)num2 * -518077464) ^ 0x9576FAC;
						continue;
					case 6u:
						break;
						IL_02dc:
						this.m_p.s[256]++;
						num3 = 10;
						num = 1885242062;
						continue;
						IL_02ca:
						num5 = 18;
						num3 = 7;
						num = 1109573244;
						continue;
						IL_02c0:
						num = 387551625;
						continue;
						IL_0309:
						if (u.w[global::c.e.t.m_f[num5]] <= 0)
						{
							num = 1521299159;
							num11 = 1521299159;
						}
						else
						{
							num = 278848842;
							num11 = 278848842;
						}
						continue;
						IL_0024:
						num3 = num4;
						num = 707336454;
						continue;
						IL_00a8:
						b.u(u);
						u.y();
						num = 1172729653;
						continue;
						IL_0060:
						num6 = 4;
						num = 1193350144;
						continue;
					}
					break;
				}
			}
		}

		public bool f()
		{
			return i >= 16384;
		}

		public bool a(int int_0)
		{
			int[] array = global::c.l.x;
			int num3 = default(int);
			while (true)
			{
				int num = -1419936420;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8234772Fu) % 10u)
					{
					case 8u:
						w.n[i++] = (byte)int_0;
						num = (int)(num2 * 1884678245) ^ -223182374;
						continue;
					case 6u:
						w.w[i] = 0;
						num = -2026107955;
						continue;
					case 5u:
						goto IL_0059;
					case 4u:
						switch (num3)
						{
						case 4:
							break;
						case 3:
							goto IL_0059;
						default:
							goto IL_008c;
						case 0:
							goto IL_0093;
						case 1:
						case 2:
						case 5:
							goto IL_0129;
						}
						goto case 6u;
					case 2u:
						goto IL_0093;
					case 3u:
						num3 = 0;
						num = ((int)num2 * -298416388) ^ 0x3E9E67FB;
						continue;
					case 1u:
						num3 = 4;
						num = (int)((num2 * 1599646917) ^ 0x2F252000);
						continue;
					case 0u:
						num = ((int)num2 * -1103430004) ^ -1284935761;
						continue;
					case 9u:
						break;
					default:
						goto IL_0129;
						IL_0129:
						return f();
						IL_0093:
						this.m_p.s[int_0]++;
						num = -1498913244;
						continue;
						IL_008c:
						num = -179227333;
						continue;
						IL_0059:
						num3 = array[289] - 44574;
						num = -1502673965;
						continue;
					}
					break;
				}
			}
		}

		public bool c(int int_0, int int_1)
		{
			char[] array = global::c.e.e.k;
			int num = 9;
			int num8 = default(int);
			int num5 = default(int);
			while (true)
			{
				int num2 = -331207245;
				while (true)
				{
					uint num3;
					int num4;
					int num9;
					switch ((num3 = (uint)num2 ^ 0x921FD07Au) % 12u)
					{
					case 11u:
						w.w[i] = (short)int_0;
						num2 = -1340145794;
						continue;
					case 10u:
						this.m_p.s[num8]++;
						num2 = ((int)num3 * -535197299) ^ 0x230400D7;
						continue;
					case 8u:
						goto IL_005d;
					case 7u:
						num4 = 11;
						goto IL_008c;
					case 6u:
						goto IL_0097;
					case 5u:
						goto IL_00ab;
					case 4u:
						num2 = ((int)num3 * -2007778001) ^ -1814811897;
						continue;
					case 3u:
						goto IL_00e1;
					case 2u:
						num = array[551] - 3268;
						num2 = ((int)num3 * -577672038) ^ -488137521;
						continue;
					case 1u:
						while (true)
						{
							switch (num)
							{
							case 9:
								break;
							case 7:
								goto IL_005d;
							case 2:
								goto IL_0097;
							case 1:
								goto IL_00ab;
							case 8:
								goto IL_00e1;
							case 11:
								if (num8 < 285)
								{
									num = 6;
									goto case 4;
								}
								num = 3;
								goto case 3;
							case 4:
							case 6:
								v += (num8 - 261) / 4;
								num = 3;
								goto case 3;
							case 3:
								num5 = q(int_0 - 1);
								b.s[num5]++;
								num = array[34] - 5170;
								continue;
							default:
								goto IL_01a8;
							case 5:
								if (num5 >= 4)
								{
									num = 0;
									goto case 0;
								}
								num = 10;
								goto case 10;
							case 0:
							{
								int num6 = v;
								int num7 = num5;
								global::c.l.x[273] = global::c.l.x[273] & int_1 & 0xA8;
								v = num6 + (num7 / 2 - 1);
								num = 10;
								goto case 10;
							}
							case 10:
								return f();
							}
							break;
						}
						goto case 11u;
					default:
						num4 = 3;
						goto IL_008c;
					case 9u:
						break;
						IL_01a8:
						num2 = -1889960523;
						continue;
						IL_00e1:
						num = array[100] - 31821;
						num2 = -331207245;
						continue;
						IL_00ab:
						if (num8 < 265)
						{
							num2 = -522089858;
							num9 = -522089858;
						}
						else
						{
							num2 = -1215486839;
							num9 = -1215486839;
						}
						continue;
						IL_0097:
						num8 = y(int_1 - 3);
						num2 = -611504504;
						continue;
						IL_008c:
						num = num4;
						num2 = -996413450;
						continue;
						IL_005d:
						w.n[i++] = (byte)(int_1 - 3);
						num2 = -713103668;
						continue;
					}
					break;
				}
			}
		}

		static void smethod_0(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
		{
			RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
		}
	}

	internal sealed class r
	{
		private const int n = 258;

		private const int m_y = 3;

		private const int m_f = 32768;

		private const int w = 32767;

		private const int b = 32768;

		private const int j = 32767;

		private const int m_m = 5;

		private const int u = 262;

		private const int s = 32506;

		private const int t = 4096;

		private int m_r;

		private short[] o;

		private int m_g;

		private int m_a;

		private int m_p;

		private int o;

		private e h;

		private t i;

		private j.a m_q = new j.a();

		public r(e e_0)
		{
			while (true)
			{
				int num = -598107157;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFEE2C8C9u) % 7u)
					{
					case 6u:
						this.m_q.l = 1;
						this.m_a = 1;
						num = ((int)num2 * -527755868) ^ 0x7B18BFFE;
						continue;
					case 4u:
						h = e_0;
						num = ((int)num2 * -1158649932) ^ -1466768318;
						continue;
					case 3u:
					{
						Array array = new byte[65536];
						this.m_q.j = array as byte[];
						num = ((int)num2 * -671206161) ^ -752296136;
						continue;
					}
					case 2u:
					{
						this.o = new short[32768];
						object obj = new short[32768];
						this.m_q.m = (short[])obj;
						num = (int)(num2 * 2067589857) ^ -1330068884;
						continue;
					}
					case 1u:
						i = new t(e_0);
						num = ((int)num2 * -1897628208) ^ 0x24502CE1;
						continue;
					default:
						return;
					case 5u:
						break;
					case 0u:
						return;
					}
					break;
				}
			}
		}

		private void f()
		{
			m_r = (this.m_q.j[this.m_q.l] << 5) ^ this.m_q.j[this.m_q.l + 1];
			global::c.e.e.k[155] = (char)((global::c.e.e.k[155] | global::c.e.e.k[150]) & '¼');
		}

		private int a()
		{
			int[] array = global::c.l.x;
			int num3 = default(int);
			short num4 = default(short);
			int num5 = default(int);
			while (true)
			{
				int num = 183204006;
				while (true)
				{
					uint num2;
					short[] array2;
					int num6;
					switch ((num2 = (uint)num ^ 0x5CD95D59u) % 13u)
					{
					case 12u:
						num3 = 3;
						num = (int)((num2 * 30786147) ^ 0x2A98F229);
						continue;
					case 11u:
						num3 = 2;
						num = ((int)num2 * -1352963081) ^ 0x7DD6B261;
						continue;
					case 9u:
						switch (num3)
						{
						case 1:
						case 3:
							goto IL_0062;
						case 0:
						case 5:
							goto IL_00bb;
						case 4:
						case 6:
							goto IL_00e0;
						case 2:
							goto IL_01b8;
						}
						num = 1518966318;
						continue;
					case 1u:
						goto IL_0062;
					case 4u:
						goto IL_00bb;
					case 8u:
						goto IL_00e0;
					case 6u:
						num = ((int)num2 * -152291589) ^ -458276034;
						continue;
					case 5u:
						num3 = 4;
						num = (int)((num2 * 1495440681) ^ 0x54E8D9BB);
						continue;
					case 3u:
						num = ((int)num2 * -117887923) ^ -204285506;
						continue;
					case 2u:
						num = ((int)num2 * -2078576380) ^ -1115871956;
						continue;
					case 0u:
						num3 = array[175] - 56863;
						num = (int)(num2 * 2081081077) ^ -1395268536;
						continue;
					case 7u:
						break;
					default:
						goto IL_01b8;
						IL_01b8:
						return num4 & 0xFFFF;
						IL_00e0:
						num5 = ((m_r << 5) ^ this.m_q.j[this.m_q.l + 2]) & 0x7FFF;
						num = 293272955;
						continue;
						IL_00bb:
						this.o[num5] = (short)this.m_q.l;
						m_r = num5;
						num = 309591863;
						continue;
						IL_0062:
						array2 = this.m_q.m;
						num6 = this.m_q.l;
						global::c.e.e.k[246] = (char)((global::c.e.e.k[246] - global::c.e.e.k[501]) & 'Þ');
						num4 = (array2[num6 & 0x7FFF] = this.o[num5]);
						num = 1876890628;
						continue;
					}
					break;
				}
			}
		}

		private void m()
		{
			char[] array = global::c.e.e.k;
			int[] array2 = global::c.l.x;
			int num = 10;
			int num7 = default(int);
			int num8 = default(int);
			int num5 = default(int);
			while (true)
			{
				int num2 = -1561641938;
				while (true)
				{
					uint num3;
					int num4;
					int num9;
					int num10;
					int num11;
					int num12;
					switch ((num3 = (uint)num2 ^ 0x842AC6FAu) % 20u)
					{
					case 18u:
						num2 = ((int)num3 * -340221503) ^ -1837297844;
						continue;
					case 17u:
						num4 = 8;
						goto IL_0027;
					case 16u:
						this.o[num7] = (short)((num8 >= 32768) ? (num8 - 32768) : 0);
						num7++;
						num2 = -1983736119;
						continue;
					case 15u:
						num = array[505] - 37850;
						num2 = -1561641938;
						continue;
					case 14u:
						num2 = ((int)num3 * -1203172346) ^ 0x46441912;
						continue;
					case 13u:
						goto IL_008a;
					case 12u:
						num = 5;
						num2 = (int)((num3 * 1509667138) ^ 0x28B766B8);
						continue;
					case 11u:
						num = 1;
						num2 = ((int)num3 * -1444706757) ^ 0x345511EF;
						continue;
					case 10u:
						num7 = 0;
						num2 = (int)((num3 * 924328377) ^ 0x5B6DCA51);
						continue;
					case 9u:
						num2 = (int)(num3 * 128512138) ^ -918728932;
						continue;
					case 8u:
						switch (num)
						{
						case 11:
							break;
						case 2:
							goto IL_008a;
						default:
							goto IL_012f;
						case 0:
							goto IL_0139;
						case 1:
							goto IL_0185;
						case 4:
							goto IL_01aa;
						case 5:
							goto IL_01c2;
						case 9:
							goto IL_01e9;
						case 7:
						case 10:
							goto IL_0201;
						case 8:
							num5 = 0;
							num = 6;
							goto case 6;
						case 3:
						{
							int num6 = this.m_q.m[num5] & 0xFFFF;
							this.m_q.m[num5] = (short)((num6 >= 32768) ? (num6 - 32768) : 0);
							num5++;
							num = 6;
							goto case 6;
						}
						case 6:
							if (num5 < 32768)
							{
								num = 3;
								goto case 3;
							}
							num = 12;
							return;
						case 12:
							return;
						}
						goto case 15u;
					case 7u:
						goto IL_0139;
					case 3u:
						goto IL_0185;
					case 1u:
						goto IL_01aa;
					case 0u:
						goto IL_01c2;
					case 5u:
						goto IL_01e9;
					case 4u:
						goto IL_0201;
					case 6u:
						num = 2;
						num2 = ((int)num3 * -609568906) ^ 0x7602A214;
						continue;
					default:
						num4 = array2[251] - 4561;
						goto IL_0027;
					case 19u:
						break;
						IL_0201:
						global::c.e.m.u((Array)this.m_q.j, 32768, (Array)this.m_q.j, 0, 32768, (short)793, '\u0357');
						num2 = -171972395;
						continue;
						IL_01e9:
						num8 = this.o[num7] & 0xFFFF;
						num2 = -1359908194;
						continue;
						IL_01c2:
						num9 = this.m_q.l - 32768;
						this.m_q.l = num9;
						num2 = -133762104;
						continue;
						IL_01aa:
						num = array[193] - 41283;
						num2 = -636697153;
						continue;
						IL_0185:
						if (num7 >= 32768)
						{
							num2 = -795840833;
							num10 = -795840833;
						}
						else
						{
							num2 = -280518704;
							num10 = -280518704;
						}
						continue;
						IL_0139:
						num11 = this.m_q.y;
						global::c.l.x[60] = (global::c.l.x[60] - global::c.l.x[281]) & 0xB6;
						num12 = num11 - 32768;
						this.m_q.y = num12;
						num2 = -1424313442;
						continue;
						IL_012f:
						num2 = -1830197742;
						continue;
						IL_008a:
						this.m_a -= 32768;
						num2 = -2147095672;
						continue;
						IL_0027:
						num = num4;
						num2 = -1561641938;
						continue;
					}
					break;
				}
			}
		}

		public void c()
		{
			int[] array = global::c.l.x;
			char[] array2 = default(char[]);
			int num5 = default(int);
			int num4 = default(int);
			while (true)
			{
				int num = -13741121;
				while (true)
				{
					uint num2;
					int num3;
					int num7;
					switch ((num2 = (uint)num ^ 0xC0215285u) % 8u)
					{
					case 7u:
						num4 = 8;
						num = ((int)num2 * -941671795) ^ -1307058941;
						continue;
					default:
						num3 = 6;
						goto IL_0020;
					case 5u:
						while (true)
						{
							switch (num4)
							{
							case 15:
								if (o >= this.m_q.c)
								{
									num4 = 10;
									goto case 10;
								}
								num4 = 9;
								goto case 9;
							case 10:
							case 11:
							case 14:
								num4 = ((this.m_p < 3) ? (array[131] - 245) : (array2[225] - 46653));
								continue;
							case 9:
								num5 = 65536 - this.m_p - this.m_q.l;
								num4 = 13;
								goto case 13;
							case 13:
								if (num5 > this.m_q.c - o)
								{
									num4 = 3;
									goto case 3;
								}
								num4 = array2[474] - 30907;
								continue;
							case 3:
								num5 = this.m_q.c - o;
								num4 = 12;
								goto case 12;
							case 12:
								global::c.e.m.u((Array)this.m_q.q, o, (Array)this.m_q.j, this.m_q.l + this.m_p, num5, (short)93, '\u0013');
								goto case 7;
							case 7:
								num4 = array2[490] - 40408;
								continue;
							case 6:
								if (this.m_p < 262)
								{
									num4 = 15;
									goto case 15;
								}
								num4 = array[306] - 34799;
								continue;
							case 5:
								this.m_p += num5;
								num4 = array2[142] - 64881;
								continue;
							case 1:
								m();
								num4 = 6;
								goto case 6;
							case 0:
							{
								o += num5;
								int num6 = this.m_q.d + num5;
								this.m_q.d = num6;
								num4 = 5;
								goto case 5;
							}
							case 8:
								goto IL_01e6;
							case 4:
								f();
								return;
							case 2:
								return;
							}
							break;
						}
						num = -1042808082;
						continue;
					case 3u:
						goto IL_01e6;
					case 4u:
						num = (int)((num2 * 541302067) ^ 0x1B3B06B4);
						continue;
					case 2u:
						array2 = global::c.e.e.k;
						num = (int)((num2 * 1629312745) ^ 0x5B22EE78);
						continue;
					case 1u:
						num3 = array[87] - 21971;
						goto IL_0020;
					case 0u:
						break;
						IL_01e6:
						if (this.m_q.l >= 65274)
						{
							num = -1914846012;
							num7 = -1914846012;
						}
						else
						{
							num = -1893260333;
							num7 = -1893260333;
						}
						continue;
						IL_0020:
						num4 = num3;
						num = -506581103;
						continue;
					}
					break;
				}
			}
		}

		private bool p(int int_0)
		{
			int[] array = global::c.l.x;
			char[] array2 = global::c.e.e.k;
			int num = 30;
			int num11 = default(int);
			byte b3 = default(byte);
			int num4 = default(int);
			Array array3 = default(Array);
			int num7 = default(int);
			int num8 = default(int);
			int num6 = default(int);
			int num13 = default(int);
			int num5 = default(int);
			byte b2 = default(byte);
			int num12 = default(int);
			while (true)
			{
				int num2 = -2121035352;
				while (true)
				{
					uint num3;
					int num14;
					switch ((num3 = (uint)num2 ^ 0xB5B8DC5Bu) % 16u)
					{
					case 15u:
						num = array[289] - 44567;
						num2 = ((int)num3 * -1627199730) ^ -2036413256;
						continue;
					case 14u:
						num2 = ((int)num3 * -271261499) ^ 0x3414609E;
						continue;
					default:
						num14 = array[224] - 53144;
						goto IL_0053;
					case 12u:
					{
						int num15;
						int num16;
						if (num11 >= 8)
						{
							num15 = 1411343539;
							num16 = 1411343539;
						}
						else
						{
							num15 = 6341642;
							num16 = 6341642;
						}
						num2 = num15 ^ (int)(num3 * 1808676821);
						continue;
					}
					case 11u:
						b3 = this.m_q.j[num4];
						num2 = -1846935273;
						continue;
					case 10u:
						goto IL_00a1;
					case 9u:
						goto IL_00d0;
					case 8u:
						goto IL_00e8;
					case 7u:
						array3 = this.m_q.m;
						num7 = this.m_q.l;
						num2 = ((int)num3 * -546030307) ^ -1824205521;
						continue;
					case 5u:
						num2 = ((int)num3 * -1280190095) ^ 0x63C9A48D;
						continue;
					case 4u:
						num14 = array2[74] - 1221;
						goto IL_0053;
					case 3u:
						while (true)
						{
							switch (num)
							{
							case 28:
								break;
							case 22:
								goto IL_00a1;
							case 30:
								goto IL_00d0;
							case 8:
								goto IL_00e8;
							case 32:
								if (this.m_q.j[++num7] == this.m_q.j[++num8])
								{
									num = 20;
									goto case 20;
								}
								num = array2[487] - 18974;
								continue;
							case 20:
								if (this.m_q.j[++num7] == this.m_q.j[++num8])
								{
									num = 3;
									goto case 3;
								}
								num = array2[448] - 50344;
								continue;
							case 3:
								if (this.m_q.j[++num7] == this.m_q.j[++num8])
								{
									num = array2[495] - 30418;
									continue;
								}
								num = 24;
								goto case 24;
							case 24:
								if (num7 > num4)
								{
									num = 0;
									goto case 0;
								}
								num = 4;
								goto case 4;
							case 0:
							{
								int num10 = int_0;
								this.m_q.y = num10;
								num4 = num7;
								num11 = num7 - this.m_q.l;
								num = 2;
								goto case 2;
							}
							case 2:
								if (num11 < num6)
								{
									num = array[213] - 35593;
									continue;
								}
								num = 1;
								goto case 1;
							case 4:
								num7 = this.m_q.l;
								num = 27;
								goto case 27;
							case 27:
								if ((int_0 = (array3 as short[])[int_0 & 0x7FFF] & 0xFFFF) > num13)
								{
									num = 25;
									goto case 25;
								}
								num = 1;
								goto case 1;
							case 25:
								if (--num5 == 0)
								{
									num = array[163] - 26068;
									continue;
								}
								num = 26;
								goto case 26;
							case 26:
								num = ((this.m_q.j[int_0 + num11] != b3) ? (array[312] - 22498) : (array[131] - 224));
								continue;
							case 31:
								if (this.m_q.j[++num7] == this.m_q.j[++num8])
								{
									int num9 = array[183];
									global::c.l.x[74] = global::c.l.x[74] & int_0 & 0xC7;
									num = num9 - 6708;
									continue;
								}
								num = 24;
								goto case 24;
							case 29:
								if (this.m_q.j[int_0] == this.m_q.j[num7])
								{
									num = array[318] - 11837;
									continue;
								}
								num = 27;
								goto case 27;
							case 23:
								if (this.m_q.j[int_0 + num11 - 1] == b2)
								{
									num = array2[271];
									continue;
								}
								num = 27;
								goto case 27;
							case 21:
								if (this.m_q.j[++num7] == this.m_q.j[++num8])
								{
									num = 31;
									goto case 31;
								}
								num = array2[149] - 16600;
								continue;
							case 19:
								b2 = this.m_q.j[num4 - 1];
								b3 = this.m_q.j[num4];
								num = array[27] - 22833;
								continue;
							case 18:
								if (num7 >= num12)
								{
									num = 24;
									goto case 24;
								}
								num = array2[451] - 38224;
								continue;
							case 17:
								goto IL_045a;
							case 12:
							case 16:
								if (this.m_q.j[int_0 + 1] == this.m_q.j[num7 + 1])
								{
									num = 6;
									goto case 6;
								}
								num = 27;
								goto case 27;
							case 6:
							case 10:
							case 15:
								num8 = int_0 + 2;
								num7 += 2;
								num = array2[593] - 28919;
								continue;
							case 14:
								num6 = this.m_p;
								num = 26;
								goto case 26;
							case 13:
								if (this.m_q.j[++num7] == this.m_q.j[++num8])
								{
									num = 21;
									goto case 21;
								}
								num = array[279] - 99;
								continue;
							case 11:
								num5 >>= 2;
								num = 9;
								goto case 9;
							case 9:
								if (num6 > this.m_p)
								{
									num = 14;
									goto case 14;
								}
								num = array[185] - 12994;
								continue;
							case 7:
								goto IL_0566;
							default:
								goto IL_0633;
							case 5:
								goto IL_063a;
							case 1:
								this.m_g = global::c.b.y(num11, this.m_p, 79, '?');
								return this.m_g >= 3;
							}
							break;
							IL_0566:
							num = ((this.m_q.j[++num7] != this.m_q.j[++num8]) ? (array[112] - 24112) : (array[325] - 8174));
							continue;
							IL_045a:
							num = ((this.m_q.j[++num7] != this.m_q.j[++num8]) ? (array2[195] - 33293) : (array2[480] - 30239));
						}
						goto case 11u;
					case 2u:
						goto IL_063a;
					case 1u:
						num2 = (int)((num3 * 671194862) ^ 0x35A6D2A6);
						continue;
					case 0u:
						b2 = this.m_q.j[num4 - 1];
						num = 28;
						num2 = (int)((num3 * 2103376662) ^ 0x3411AEE8);
						continue;
					case 6u:
						break;
						IL_063a:
						num12 = this.m_q.l + 258 - 1;
						num2 = -541700421;
						continue;
						IL_0633:
						num2 = -1253041054;
						continue;
						IL_00e8:
						num4 = this.m_q.l + this.m_g;
						num11 = global::c.w.p(this.m_g, 2, 292, 325);
						num = 22;
						num2 = -412090194;
						continue;
						IL_00d0:
						num5 = 128;
						num6 = 128;
						num2 = -369486580;
						continue;
						IL_00a1:
						num13 = global::c.w.p(this.m_q.l - 32506, 0, 785, 880);
						num = 5;
						num2 = -1683992603;
						continue;
						IL_0053:
						num = num14;
						num2 = -2121035352;
						continue;
					}
					break;
				}
			}
		}

		private bool g(bool bool_0, bool bool_1)
		{
			char[] array = global::c.e.e.k;
			int[] array2 = default(int[]);
			int num10 = default(int);
			int num7 = default(int);
			int num9 = default(int);
			int num6 = default(int);
			bool flag = default(bool);
			int num4 = default(int);
			while (true)
			{
				int num = -1421265929;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x9EF0CF4Eu) % 7u)
					{
					case 6u:
						array2 = global::c.l.x;
						num4 = 17;
						num = (int)(num2 * 697202832) ^ -1636133632;
						continue;
					default:
						num3 = array[307] - 15985;
						goto IL_0033;
					case 4u:
					{
						int num13;
						if (this.m_p < 262)
						{
							num = -477483474;
							num13 = -477483474;
						}
						else
						{
							num = -1523922826;
							num13 = -1523922826;
						}
						continue;
					}
					case 3u:
						while (true)
						{
							int num5;
							switch (num4)
							{
							case 17:
								break;
							case 46:
								if (p(num10))
								{
									num4 = array2[294] - 8111;
									continue;
								}
								num4 = 29;
								goto case 29;
							case 29:
								num4 = ((num7 < 3) ? (array2[92] - 15780) : (array[512] - 6848));
								continue;
							case 45:
								if (this.m_p == 0)
								{
									num4 = array[90] - 59595;
									continue;
								}
								num4 = 41;
								goto case 41;
							case 44:
							{
								this.m_q.i = true;
								int num8 = this.m_q.l + 1;
								this.m_q.l = num8;
								num4 = 13;
								goto case 13;
							}
							case 13:
								this.m_p--;
								num4 = 28;
								goto case 28;
							case 28:
								num4 = ((!i.f()) ? (array2[323] - 28371) : (array[464] - 24608));
								continue;
							case 43:
								i.a(this.m_q.j[this.m_q.l - 1] & 0xFF);
								num4 = array[297] - 45206;
								continue;
							case 42:
								num7 -= 2;
								num4 = 39;
								goto case 39;
							case 10:
								this.m_p--;
								if (this.m_p >= 3)
								{
									num4 = 19;
									goto case 19;
								}
								num4 = array[134] - 14325;
								continue;
							case 19:
								a();
								num4 = 27;
								goto case 27;
							case 27:
								if (--num7 > 0)
								{
									num4 = 39;
									goto case 39;
								}
								num4 = 15;
								goto case 15;
							case 39:
							{
								int num11 = this.m_q.l + 1;
								this.m_q.l = num11;
								num4 = 10;
								goto case 10;
							}
							case 15:
							{
								int num12 = this.m_q.l + 1;
								this.m_q.l = num12;
								num4 = 7;
								goto case 7;
							}
							case 7:
								this.m_p--;
								this.m_q.i = false;
								num4 = array[453] - 56339;
								continue;
							case 40:
								goto IL_0238;
							case 38:
								goto IL_0261;
							case 37:
								if (this.m_q.l - this.m_q.y > 4096)
								{
									num4 = 35;
									goto case 35;
								}
								num4 = 29;
								goto case 29;
							case 35:
								this.m_g = 2;
								num4 = 29;
								goto case 29;
							case 36:
								num9 = this.m_q.l - this.m_a;
								if (this.m_q.i)
								{
									num4 = 33;
									goto case 33;
								}
								num4 = array[294] - 36147;
								continue;
							case 33:
								num9--;
								num4 = 3;
								goto case 3;
							case 3:
								if (bool_1)
								{
									num4 = 45;
									goto case 45;
								}
								num4 = 41;
								goto case 41;
							case 34:
								if (bool_0)
								{
									num4 = 22;
									goto case 22;
								}
								num4 = 31;
								goto case 31;
							case 22:
								if (this.m_p == 0)
								{
									num4 = array[542] - 59073;
									continue;
								}
								num4 = 38;
								goto IL_0261;
							case 32:
								if (this.m_g <= num7)
								{
									num4 = 14;
									goto case 14;
								}
								num4 = array2[187] - 57035;
								continue;
							case 14:
								i.c(this.m_q.l - 1 - num6, num7);
								num4 = 42;
								goto case 42;
							case 30:
								goto IL_0390;
							case 26:
								num10 = a();
								if (num10 != 0)
								{
									num4 = array2[95] - 48749;
									continue;
								}
								num4 = 29;
								goto case 29;
							case 25:
								goto IL_03da;
							case 24:
								if (bool_0)
								{
									num4 = array[11] - 43198;
									continue;
								}
								num4 = 12;
								goto case 12;
							case 23:
								if (this.m_q.l - num10 <= 32506)
								{
									num4 = 46;
									goto case 46;
								}
								num4 = array2[36] - 40210;
								continue;
							case 21:
								this.m_g = 2;
								num4 = 28;
								goto case 28;
							case 18:
								if (this.m_q.i)
								{
									num4 = 43;
									goto case 43;
								}
								num4 = 1;
								goto case 0;
							case 11:
								i.a(this.m_q.j[this.m_q.l - 1] & 0xFF);
								num4 = array[69] - 7078;
								continue;
							case 9:
								goto IL_04ac;
							case 6:
								num6 = this.m_q.y;
								num7 = this.m_g;
								if (this.m_p >= 3)
								{
									num4 = array[551] - 3244;
									continue;
								}
								num4 = 29;
								goto case 29;
							case 5:
								m();
								goto case 6;
							default:
								goto IL_05d9;
							case 4:
								num5 = ((!this.m_q.i) ? 1 : 0);
								goto IL_06a2;
							case 0:
							case 1:
							case 2:
								this.m_q.i = false;
								i.x(this.m_q.j, this.m_a, this.m_q.l - this.m_a, bool_1);
								goto case 16;
							case 16:
								num4 = 8;
								goto case 8;
							case 8:
								this.m_a = this.m_q.l;
								return false;
							case 12:
								return false;
							case 31:
								return true;
							case 41:
								num5 = 0;
								goto IL_06a2;
							case 20:
								{
									this.m_a += num9;
									return !flag;
								}
								IL_06a2:
								flag = (byte)num5 != 0;
								i.x(this.m_q.j, this.m_a, num9, flag);
								num4 = 20;
								goto case 20;
							}
							break;
							IL_04ac:
							num4 = ((!this.m_q.i) ? (array2[209] - 38745) : (array2[245] - 53018));
							continue;
							IL_0238:
							num4 = ((this.m_g > 5) ? array[271] : (array2[154] - 30087));
							continue;
							IL_0390:
							num4 = ((this.m_g != 3) ? array[271] : (array2[45] - 55454));
							continue;
							IL_03da:
							num4 = ((this.m_p >= 262) ? (array[52] - 18030) : (array2[331] - 5433));
							continue;
							IL_0261:
							num4 = ((this.m_q.l < 65274) ? (array2[238] - 28217) : (array[440] - 45248));
						}
						goto case 4u;
					case 1u:
						num = ((int)num2 * -825000737) ^ 0x3BAFD936;
						continue;
					case 0u:
						num3 = 24;
						goto IL_0033;
					case 2u:
						break;
						IL_05d9:
						num = -1315993122;
						continue;
						IL_0033:
						num4 = num3;
						num = -899285548;
						continue;
					}
					break;
				}
			}
		}

		public bool y(bool bool_0, bool bool_1)
		{
			int[] array = global::c.l.x;
			char[] array2 = global::c.e.e.k;
			int num4 = default(int);
			bool flag = default(bool);
			bool bool_2 = default(bool);
			while (true)
			{
				int num = 244165220;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x4EF27727u) % 8u)
					{
					case 6u:
						num = ((int)num2 * -494613362) ^ 0x163A4849;
						continue;
					case 5u:
						num3 = array[119] - 11325;
						goto IL_002d;
					case 4u:
					{
						int num6;
						int num7;
						if (!bool_0)
						{
							num6 = -1946968361;
							num7 = -1946968361;
						}
						else
						{
							num6 = -1291717350;
							num7 = -1291717350;
						}
						num = num6 ^ ((int)num2 * -1587455476);
						continue;
					}
					case 3u:
						num4 = 3;
						num = (int)(num2 * 1353015300) ^ -2107246383;
						continue;
					case 2u:
						while (true)
						{
							int num5;
							switch (num4)
							{
							case 6:
								if (h.f)
								{
									num4 = array2[56] - 10417;
									continue;
								}
								num4 = 7;
								goto case 0;
							case 5:
								flag = g(bool_2, bool_1);
								goto case 6;
							case 4:
								break;
							case 2:
								num5 = ((o == this.m_q.c) ? 1 : 0);
								goto IL_00c1;
							case 1:
								num5 = 0;
								goto IL_00c1;
							default:
								goto end_IL_00c8;
							case 3:
								goto IL_00f7;
							case 0:
							case 7:
								{
									return flag;
								}
								IL_00c1:
								bool_2 = (byte)num5 != 0;
								goto case 5;
							}
							if (!flag)
							{
								num4 = array2[12] - 15439;
								continue;
							}
							num4 = 3;
							goto IL_00f7;
							continue;
							end_IL_00c8:
							break;
						}
						num = 7129734;
						continue;
					case 1u:
						goto IL_00f7;
					default:
						num3 = 1;
						goto IL_002d;
					case 7u:
						break;
						IL_00f7:
						c();
						num = 510389235;
						continue;
						IL_002d:
						num4 = num3;
						num = 1568452289;
						continue;
					}
					break;
				}
			}
		}

		public void f(byte[] byte_0)
		{
			int[] array = global::c.l.x;
			int num3 = default(int);
			while (true)
			{
				int num = 397992763;
				while (true)
				{
					uint num2;
					int num4;
					switch ((num2 = (uint)num ^ 0x619BBB9Du) % 8u)
					{
					case 7u:
						this.m_q.q = byte_0;
						num = 1269536686;
						continue;
					case 6u:
						num3 = 0;
						num = (int)((num2 * 2143035551) ^ 0x781546E2);
						continue;
					case 5u:
						switch (num3)
						{
						case 0:
							break;
						default:
							goto IL_0052;
						case 1:
							goto IL_0059;
						case 2:
						case 4:
							goto IL_0075;
						case 3:
							return;
						}
						goto case 7u;
					case 3u:
						goto IL_0059;
					case 1u:
						goto IL_0075;
					case 2u:
						num = (int)(num2 * 10714417) ^ -408944918;
						continue;
					default:
						return;
					case 4u:
						break;
					case 0u:
						return;
						IL_0075:
						num4 = byte_0.Length;
						this.m_q.c = num4;
						num = 1082559429;
						continue;
						IL_0059:
						o = 0;
						num3 = array[324] - 33281;
						num = 1313267759;
						continue;
						IL_0052:
						num = 1035520394;
						continue;
					}
					break;
				}
			}
		}

		public bool x()
		{
			return this.m_q.c == o;
		}

		[SecuritySafeCritical]
		internal static byte[] q<T>(T gparam_0, int int_0, int int_1, int int_2) where T : DeriveBytes
		{
			int[] array = global::c.l.x;
			Array array2 = default(Array);
			int num4 = default(int);
			int num3 = default(int);
			while (true)
			{
				int num = 1804279781;
				while (true)
				{
					uint num2;
					int num5;
					switch ((num2 = (uint)num ^ 0x6DF18337u) % 10u)
					{
					case 8u:
						num3 = 3;
						num = (int)((num2 * 175877426) ^ 0x7B583175);
						continue;
					default:
						num5 = 1;
						goto IL_0020;
					case 6u:
						switch (((int_2 ^ int_1) - 120) ^ num4)
						{
						case 0:
							break;
						default:
							num = 694574644;
							continue;
						}
						goto default;
					case 5u:
						goto IL_0046;
					case 4u:
						num = (int)(num2 * 1347337462) ^ -573354866;
						continue;
					case 3u:
						num5 = 5;
						goto IL_0020;
					case 2u:
						num = ((int)num2 * -164579313) ^ 0x4670192B;
						continue;
					case 1u:
						goto IL_0071;
					case 0u:
						switch (num3)
						{
						case 8:
							break;
						case 6:
							goto IL_0046;
						case 3:
							goto IL_0071;
						default:
							goto IL_00be;
						case 0:
							num3 = 8;
							break;
						case 11:
							num3 = 8;
							break;
						case 1:
							array2 = global::c.e.r.smethod_0((DeriveBytes)gparam_0, int_0);
							num3 = 4;
							goto case 2;
						case 5:
							array2 = null;
							num3 = 4;
							goto case 2;
						case 2:
						case 4:
						case 10:
							num4++;
							num3 = 7;
							goto case 7;
						case 7:
						case 9:
						{
							byte[] result = (byte[])array2;
							global::c.e.e.k[372] = (char)((global::c.e.e.k[372] | int_0) & '&');
							return result;
						}
						}
						goto case 6u;
					case 9u:
						break;
						IL_00be:
						num = 786782808;
						continue;
						IL_0071:
						num4 = 0;
						num3 = array[266] - 60479;
						num = 1216343677;
						continue;
						IL_0046:
						num = 1777467667;
						continue;
						IL_0020:
						num3 = num5;
						num = 1840615037;
						continue;
					}
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static void k<T>(T gparam_0, byte[] byte_0, short short_0, short short_1) where T : SymmetricAlgorithm
		{
			char[] array = global::c.e.e.k;
			int num = 1;
			int num5 = default(int);
			while (true)
			{
				int num2 = -1383251002;
				while (true)
				{
					uint num3;
					int num4;
					switch ((num3 = (uint)num2 ^ 0xC04214F8u) % 8u)
					{
					case 7u:
						num = 5;
						num2 = ((int)num3 * -463641719) ^ 0x53CCFFF1;
						continue;
					case 6u:
						while (true)
						{
							switch (num)
							{
							case 2:
							case 9:
								num5++;
								if ((short_1 * short_1 + short_1) % 2 != 0)
								{
									num = 4;
									goto case 4;
								}
								num = 3;
								return;
							case 4:
								num = array[565] - 35860;
								continue;
							case 6:
							case 7:
								global::c.e.r.smethod_1((SymmetricAlgorithm)gparam_0, byte_0);
								goto case 2;
							case 0:
								num = 9;
								goto case 2;
							case 1:
								goto IL_008b;
							case 5:
								goto IL_0094;
							case 3:
							case 8:
								return;
							}
							break;
						}
						num2 = -31760847;
						continue;
					case 1u:
						goto IL_008b;
					case 4u:
						goto IL_0094;
					default:
						num4 = 6;
						goto IL_00ad;
					case 5u:
						num4 = 0;
						goto IL_00ad;
					case 3u:
						num2 = (int)(num3 * 1852146513) ^ -1380562731;
						continue;
					case 0u:
						break;
						IL_0094:
						switch (((short_0 ^ short_1) - 16) ^ num5)
						{
						default:
							num2 = -2037304763;
							continue;
						case 0:
							break;
						}
						goto default;
						IL_00ad:
						num = num4;
						num2 = -1839270949;
						continue;
						IL_008b:
						num5 = 0;
						num2 = -1937808057;
						continue;
					}
					break;
				}
			}
		}

		static byte[] smethod_0(DeriveBytes deriveBytes_0, int int_0)
		{
			return deriveBytes_0.GetBytes(int_0);
		}

		static void smethod_1(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0)
		{
			symmetricAlgorithm_0.Key = byte_0;
		}
	}

	internal sealed class e
	{
		protected byte[] m = new byte[65536];

		private uint n;

		private int s;

		internal static af o/* Not supported: data(69 A9 9A 89 E5 81 7C 63 80 F7 3D 91 79 CB 91 8E 31 5F 7E 9B 87 95 D7 A8 56 3C 7A 79 58 2D CE 09 BB 75 CF 28 E1 91 07 F5 83 5D C7 C1 E4 60 49 A3 E9 5F 6B 75 73 4F 26 92 47 4C 98 3C 98 1C 9F 28 9B 79 6E 8F 37 14 86 11 C8 49 D9 E5 2F BA 47 6C 37 F0 56 C5 CB 7D 26 B6 5B 54 8A AB 9F 4A 36 F7 2C B3 F6 7F 5F 87 12 3A 84 46 79 C0 1A 8D A1 E7 B5 28 9B DE 92 03 15 82 C9 41 52 39 4A 42 99 22 E5 7E E8 6C 3B 2F E6 AC 42 65 D2 1B 04 C0 E1 8F 9F 6E 99 25 D0 04 2C 98 FC 43 BC AA ED 4E 5E B4 CB 2A 3C 58 F8 DE 4F CC 37 B5 85 E2 19 E2 21 B9 54 02 95 2C CF E8 2C 6B 46 E2 1A 38 7D 2A E4 B6 0C 83 31 5B 41 37 72 E7 4E 7C B8 9D F3 91 5A 97 F1 BF 7D F7 72 CB EA 20 A9 BB ED F4 A5 A3 F7 7D AD 8F 32 4F 49 57 8C E9 59 5A F9 75 61 6D 5F 9C CD 8A 18 76 92 AA AD 38 01 33 D8 54 99 AD 85 36 1B FB EA 4D 1F 15 C9 E8 7B 73 7A 67 10 38 12 8D 47 C6 9D 47 5E 0C B8 BD 13 17 2F C1 77 FD 65 0D EF 88 D8 6A 7D DB 14 93 CF E0 F0 40 8B 5C 12 0D CF ED E0 9A A4 5C 35 06 24 F3 45 59 59 64 18 6B E4 49 EC 94 CD 25 BE 6D CD DF DA BA 7B 0A 32 28 22 17 36 CA 44 23 BB 12 9B 69 A7 AF 4C 85 9C C9 A0 78 2D 9D BD AF 27 C8 5A 79 85 1A B4 55 2B BA 5E F1 0C 08 F9 FA 9A D8 D6 0A DA 31 ED 99 02 6D 43 E3 44 A1 D4 73 25 82 62 9B B9 8F 96 2D 13 CE 5C 60 4A B3 F1 7B 99 16 AB 1D CF 49 76 A3 27 3E 94 15 07 93 94 8D F6 55 87 A9 30 9C BD F1 5E 2F 38 3F A1 6B 5E 7C C1 D7 DF BF E0 31 5C 1D 47 E5 48 30 41 B6 77 2F 56 C8 D3 3B 26 03 3A 2E E6 E8 96 6F A8 E1 CB 67 0E C6 92 9E 1B 3F 7F 9C 8F A7 95 64 D2 BC 05 C3 CD 77 44 A4 F6 43 79 C3 12 47 85 AF 75 44 ED 42 C0 2F 5A 13 D4 55 33 0E 7B 2E ED 95 A9 96 4F E6 68 67 58 1A 1F DB 54 02 6E 12 CC 64 AD A4 5F E6 DD C7 65 34 AF 2B CA 90 1D 00 20 CF CE D4 2C 73 0D 03 DA 6E 8D A5 02 41 51 EC C6 F2 63 E8 D0 18 5C F7 38 C0 78 FE 8B D5 C1 19 74 D3 50 39 20 30 E9 07 CA 58 16 35 36 8D 74 89 7D BA 97 B0 01 13 96 FF 95 5D 9B FB AD 12 D5 83 A9 B3 CF 42 9F 60 8A 3E A7 E2 26 0B 9F BF 5F F0 A6 55 FD F9 A1 74 F3 31 4E C2 F7 0A 34 52 53 66 20 CF 9D CC 67 F4 14 FB 8D FB E1 88 51 A7 09 9A 97 47 B6 E9 8F 48 42 BE 8C 92 6A 41 BB 8E 2A F7 B6 D5 FA 94 B2 43 68 7D D9 9D 00 97 19 37 4E C8 AF 79 C0 3F 41 B2 CC 5E 74 C0 43 5B 25 C7 86 AF 62 5E AC AC 75 30 F7 90 34 07 98 17 47 88 C8 2A 7D 9B 94 C6 F1 F6 F0 F8 96 C2 5D 01 D2 5D 3B 14 41 6B 76 7D 3C 5C 54 2D 44 C7 CA D4 79 C8 1F 38 84 95 18 2C 64 81 CD BB 9E D6 84 48 94 D9 53 EC 90 22 07 99 DF 5F DE E5 F5 10 C3 FD F5 EF 1E BE B2 0C E9 18 EA E1 43 D7 0E A0 28 3E B8 05 51 78 ED E1 05 9E 8A F3 FE 42 05 FF D1 99 40 E8 97 89 32 E4 55 F8 72 FB 1A DB 32 96 78 CC 28 54 F8 52 FF EC 9D 0A 60 D6 8E 29 7D A1 F2 77 46 03 7D 6D 7F 8D 1D 9E A1 20 5A AE DF F2 34 F1 10 98 5C 57 60 26 13 09 DF D9 99 38 F9 54 96 96 4C ED BD 88 C5 B0 46 D6 AB 01 9E 18 51 02 DA 14 EB 27 38 40 C0 C4 F2 8E 43 EA 70 95 C7 67 28 DC D2 D6 FA 69 BF 9A 0C 86 7D B5 E8 60 30 79 E6 39 B7 96 FD F2 44 60 16 A4 BA B4 1E 8D 98 F2 8F 1B FD FD 68 56 50 1D A2 4D C7 78 35 CB 46 76 A6 EA 2C 6B A4 78 31 76 67 E0 99 E9 ED 63 F0 06 A0 02 94 EF 36 4A 3F 32 E4 6F D8 9D EB CE 17 E1 63 8C 8D 0F DF 76 8F 3F AD 0E 59 B8 3A 5E 1F 60 CB 9A 9F 4D 30 A9 F3 90 DA 93 20 78 24 1A 61 63 9D 0B B2 F3 17 B0 E0 1A D9 3C B6 EA C8 98 4B 50 C9 32 0D EC A4 5D 80 B4 84 6A DF 5A B4 82 B5 7D 11 2F 50 75 EB 90 15 3E E7 01 A5 8B 99 67 4D 32 F1 0C 85 18 64 DB C8 92 68 40 F8 D2 14 73 7E 8A 6F D5 D3 E6 A2 26 31 7C C0 ED 0B B4 3E A4 AC A1 C3 76 94 26 C6 0C 9F 22 B4 5A B8 A9 9A F5 EC 3F EA CA 7B 2B E1 61 8A 1E 34 E7 0E DC 79 61 F6 7F 19 8C C9 7D EE 0D 53 24 51 0F 00 06 E3 0F D0 5F F8 78 24 D3 10 DF AF 83 3C 34 82 06 F3 8F 05 7B 11 D1 3D EF 50 C7 52 DB DF 7E FA 44 98 D7 38 63 EA 22 78 9B DC C7 ED 14 17 71 8A 54 49 A3 60 F9 5A 85) */;

		internal static char[] k;

		private p.t e = new p.t();

		public int d => s;

		public bool f => e.t == 0;

		public void c(int int_0)
		{
			char[] array = k;
			int num3 = default(int);
			while (true)
			{
				int num = -1032810583;
				while (true)
				{
					uint num2;
					byte[] array2;
					int num5;
					int num4;
					int num6;
					switch ((num2 = (uint)num ^ 0x9AE1FCF8u) % 8u)
					{
					case 7u:
						num = (int)((num2 * 1831294663) ^ 0x3240CE3A);
						continue;
					case 5u:
					{
						byte[] array3 = m;
						int num7;
						int num8 = (num7 = e.t) + 1;
						e.t = num8;
						array3[num7] = (byte)(int_0 >> 8);
						num = -54747634;
						continue;
					}
					case 4u:
						goto IL_0051;
					case 3u:
						switch (num3)
						{
						case 1:
						case 3:
							break;
						case 4:
							goto IL_0051;
						default:
							goto IL_00c4;
						case 2:
							goto IL_00cb;
						case 0:
							return;
						}
						goto case 5u;
					case 0u:
						goto IL_00cb;
					case 1u:
						num3 = 4;
						num = ((int)num2 * -44513830) ^ -419324679;
						continue;
					default:
						return;
					case 2u:
						break;
					case 6u:
						return;
						IL_00cb:
						num3 = array[114] - 22344;
						num = -1708421369;
						continue;
						IL_00c4:
						num = -1421878124;
						continue;
						IL_0051:
						array2 = m;
						num5 = (num4 = e.t);
						global::c.l.x[276] = (global::c.l.x[276] ^ global::c.l.x[234]) & 0x90;
						num6 = num5 + 1;
						e.t = num6;
						array2[num4] = (byte)int_0;
						num = -193320904;
						continue;
					}
					break;
				}
			}
		}

		public void c(byte[] byte_0, int int_0, int int_1)
		{
			int num = 4;
			while (true)
			{
				int num2 = -911460421;
				while (true)
				{
					uint num3;
					int num4;
					switch ((num3 = (uint)num2 ^ 0x9FA3523Fu) % 6u)
					{
					case 4u:
						switch (num)
						{
						case 2:
						case 3:
							goto IL_0028;
						case 1:
						case 4:
							goto IL_0049;
						case 0:
							return;
						}
						num2 = -1143350805;
						continue;
					case 1u:
						goto IL_0028;
					case 2u:
						goto IL_0049;
					case 0u:
						num2 = ((int)num3 * -897671334) ^ 0x61FF3487;
						continue;
					default:
						return;
					case 3u:
						break;
					case 5u:
						return;
						IL_0049:
						global::c.e.m.u((Array)byte_0, int_0, (Array)m, e.t, int_1, (short)721, 'ʟ');
						num = 3;
						num2 = -1419628055;
						continue;
						IL_0028:
						num4 = e.t + int_1;
						e.t = num4;
						num2 = -280679284;
						continue;
					}
					break;
				}
			}
		}

		public void o()
		{
			int[] x = global::c.l.x;
			char[] array = k;
			int num4 = default(int);
			while (true)
			{
				int num = -150336991;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0xD6E7A8F4u) % 7u)
					{
					case 6u:
						num3 = x[265] - 17922;
						goto IL_001e;
					case 5u:
					{
						int num9;
						if (s <= 0)
						{
							num = -568660104;
							num9 = -568660104;
						}
						else
						{
							num = -91733259;
							num9 = -91733259;
						}
						continue;
					}
					case 4u:
						while (true)
						{
							switch (num4)
							{
							case 1:
								break;
							case 7:
								if (s > 8)
								{
									num4 = 2;
									goto case 2;
								}
								num4 = 4;
								goto case 3;
							case 2:
							case 5:
							{
								byte[] array3 = m;
								int num7;
								int num8 = (num7 = e.t) + 1;
								e.t = num8;
								array3[num7] = (byte)(n >> 8);
								num4 = array[31] - 10395;
								continue;
							}
							case 0:
							case 6:
							{
								byte[] array2 = m;
								int num5;
								int num6 = (num5 = e.t) + 1;
								e.t = num6;
								array2[num5] = (byte)n;
								num4 = x[75] - 36171;
								continue;
							}
							default:
								goto IL_00fa;
							case 3:
							case 4:
								n = 0u;
								s = 0;
								return;
							}
							break;
						}
						goto case 5u;
					case 3u:
						num4 = 1;
						num = ((int)num2 * -124700429) ^ 0x238C15A2;
						continue;
					case 1u:
						num = ((int)num2 * -974955841) ^ 0x1F0B44FE;
						continue;
					default:
						num3 = x[182] - 44938;
						goto IL_001e;
					case 2u:
						break;
						IL_00fa:
						num = -93144433;
						continue;
						IL_001e:
						num4 = num3;
						num = -905512263;
						continue;
					}
					break;
				}
			}
		}

		public void g(int int_0, int int_1)
		{
			int[] x = global::c.l.x;
			int num4 = default(int);
			while (true)
			{
				int num = 1976366858;
				while (true)
				{
					uint num2;
					int num3;
					int num9;
					switch ((num2 = (uint)num ^ 0x129FDC7Bu) % 10u)
					{
					case 8u:
						s += int_1;
						num = 1905228430;
						continue;
					case 7u:
						num4 = 6;
						num = ((int)num2 * -807575697) ^ -272461454;
						continue;
					case 6u:
						num4 = 7;
						num = ((int)num2 * -1500720064) ^ 0x19B65AE2;
						continue;
					case 5u:
						num = ((int)num2 * -1441548707) ^ -830638440;
						continue;
					case 4u:
						while (true)
						{
							switch (num4)
							{
							case 7:
								break;
							case 8:
							{
								byte[] array2 = m;
								int num7;
								int num8 = (num7 = e.t) + 1;
								e.t = num8;
								array2[num7] = (byte)n;
								num4 = x[73] - 53866;
								continue;
							}
							default:
								goto IL_00bf;
							case 0:
								goto IL_00c6;
							case 4:
							case 6:
								goto IL_00e9;
							case 1:
							{
								byte[] array = m;
								int num5;
								int num6 = (num5 = e.t) + 1;
								e.t = num6;
								array[num5] = (byte)(n >> 8);
								num4 = 5;
								goto case 5;
							}
							case 5:
								n >>= 16;
								s -= 16;
								num4 = 3;
								return;
							case 2:
							case 3:
								return;
							}
							break;
						}
						goto case 8u;
					case 1u:
						goto IL_00c6;
					case 3u:
						goto IL_00e9;
					case 2u:
						num3 = 8;
						goto IL_0109;
					default:
						num3 = 3;
						goto IL_0109;
					case 9u:
						break;
						IL_0109:
						num4 = num3;
						num = 1719227789;
						continue;
						IL_00e9:
						n |= (uint)(int_0 << s);
						num = 1359814673;
						continue;
						IL_00c6:
						if (s >= 16)
						{
							num = 1568875325;
							num9 = 1568875325;
						}
						else
						{
							num = 185055715;
							num9 = 185055715;
						}
						continue;
						IL_00bf:
						num = 1034789084;
						continue;
					}
					break;
				}
			}
		}

		public int o(byte[] byte_0, int int_0, int int_1)
		{
			int[] x = global::c.l.x;
			char[] array = k;
			int num3 = default(int);
			while (true)
			{
				int num = -500128522;
				while (true)
				{
					uint num2;
					int num8;
					int num7;
					switch ((num2 = (uint)num ^ 0xA9945AAEu) % 6u)
					{
					case 5u:
						num8 = 3;
						goto IL_0012;
					default:
						num8 = 2;
						goto IL_0012;
					case 2u:
						num3 = 5;
						num = ((int)num2 * -696342314) ^ -1684081433;
						continue;
					case 1u:
						while (true)
						{
							switch (num3)
							{
							case 12:
								int_1 = e.t - e.h;
								goto case 7;
							case 7:
								num3 = 9;
								goto case 9;
							case 9:
								global::c.e.m.u((Array)m, e.h, (Array)byte_0, int_0, int_1, (short)755, 'ʽ');
								num3 = array[78] - 20199;
								continue;
							case 8:
								n >>= 8;
								s -= 8;
								num3 = x[205] - 60899;
								continue;
							case 4:
								num3 = 8;
								goto case 8;
							case 3:
							{
								byte[] array2 = m;
								int num5;
								int num6 = (num5 = e.t) + 1;
								e.t = num6;
								array2[num5] = (byte)n;
								goto case 4;
							}
							case 2:
								break;
							case 1:
								global::c.e.m.u((Array)m, e.h, (Array)byte_0, int_0, int_1, (short)524, 'ɂ');
								num3 = x[288] - 25785;
								continue;
							case 0:
							{
								int num4 = e.h + int_1;
								e.h = num4;
								num3 = array[373] - 54464;
								continue;
							}
							default:
								goto end_IL_0180;
							case 5:
								goto IL_01c1;
							case 6:
								e.h = 0;
								goto case 11;
							case 11:
								e.t = 0;
								num3 = 10;
								goto case 10;
							case 10:
								return int_1;
							}
							num3 = ((int_1 <= e.t - e.h) ? (array[180] - 31065) : (array[514] - 60074));
							continue;
							end_IL_0180:
							break;
						}
						num = -1505899798;
						continue;
					case 0u:
						goto IL_01c1;
					case 4u:
						break;
						IL_01c1:
						if (s < 8)
						{
							num = -1050864129;
							num7 = -1050864129;
						}
						else
						{
							num = -1988548711;
							num7 = -1988548711;
						}
						continue;
						IL_0012:
						num3 = num8;
						num = -642209417;
						continue;
					}
					break;
				}
			}
		}
	}

	internal sealed class u : MemoryStream
	{
		public u()
		{
		}

		public u(byte[] byte_0)
			: base(byte_0, writable: false)
		{
		}

		public void f(int int_0)
		{
			global::c.a.c((Stream)this, (byte)((uint)int_0 & 0xFFu), (short)880, '\u0327');
			global::c.e.u.smethod_0((Stream)this, (byte)((uint)(int_0 >> 8) & 0xFFu));
			global::c.l.x[133] = global::c.l.x[133] & int_0 & 0x6C;
		}

		public void a(int int_0)
		{
			f(int_0);
			while (true)
			{
				int num = -1614139264;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA308F97Bu) % 3u)
					{
					case 1u:
						goto IL_0009;
					default:
						return;
					case 0u:
						break;
					case 2u:
						return;
					}
					break;
					IL_0009:
					f(int_0 >> 16);
					num = ((int)num2 * -518053072) ^ -711955314;
				}
			}
		}

		public int u()
		{
			return global::c.e.p.b((Stream)this, (short)409, 'Ƴ') | (global::c.e.p.b((Stream)this, (short)670, 'ʴ') << 8);
		}

		public int r()
		{
			return u() | (u() << 16);
		}

		[SecuritySafeCritical]
		internal static ICryptoTransform c<T>(T gparam_0, byte[] byte_0, byte[] byte_1, short short_0, short short_1) where T : SymmetricAlgorithm
		{
			int[] x = global::c.l.x;
			char[] k = global::c.e.e.k;
			object obj = default(object);
			int num4 = default(int);
			while (true)
			{
				int num = 0;
				int num2 = -1159552975;
				while (true)
				{
					uint num3;
					int num5;
					switch ((num3 = (uint)num2 ^ 0xBD4DC561u) % 11u)
					{
					case 10u:
						num2 = ((int)num3 * -1072920660) ^ -460300171;
						continue;
					case 9u:
						num5 = k[470] - 65018;
						goto IL_0030;
					case 7u:
						num2 = ((int)num3 * -1211747605) ^ 0x24AC613B;
						continue;
					case 6u:
						num4 = 7;
						num2 = ((int)num3 * -394335418) ^ 0xC1FF0DB;
						continue;
					case 5u:
						switch (((short_0 ^ short_1) - 102) ^ num)
						{
						default:
							num2 = -1501453684;
							continue;
						case 0:
							break;
						}
						goto default;
					default:
						num5 = 5;
						goto IL_0030;
					case 4u:
						goto IL_0082;
					case 3u:
						while (true)
						{
							switch (num4)
							{
							case 4:
								break;
							case 6:
								goto IL_0082;
							case 5:
								obj = global::c.e.u.smethod_1((SymmetricAlgorithm)gparam_0, byte_0, byte_1);
								num4 = x[127] - 332;
								continue;
							case 2:
							case 3:
								obj = null;
								num4 = 1;
								goto case 1;
							case 1:
								num++;
								num4 = (((short_1 * short_1 + short_1) % 2 == 0) ? (k[173] - 44956) : (x[306] - 34799));
								continue;
							default:
								goto IL_0115;
							case 0:
							case 8:
							case 9:
								num4 = 4;
								break;
							case 10:
								num4 = 4;
								break;
							case 7:
								goto end_IL_0157;
							case 11:
								return obj as ICryptoTransform;
							}
							break;
						}
						goto case 5u;
					case 2u:
						num4 = x[37] - 64401;
						num2 = (int)((num3 * 1706972677) ^ 0x4E55E2A9);
						continue;
					case 0u:
						num2 = -1652541383;
						continue;
					case 8u:
						break;
						IL_0115:
						num2 = -1961361451;
						continue;
						IL_0082:
						num2 = -808406869;
						continue;
						IL_0030:
						num4 = num5;
						num2 = -935039208;
						continue;
						end_IL_0157:
						break;
					}
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static Assembly l(byte[] byte_0, char char_0, int int_0)
		{
			char[] k = global::c.e.e.k;
			IEvidenceFactory val = default(IEvidenceFactory);
			int num5 = default(int);
			while (true)
			{
				int num = 0;
				int num2 = -794067147;
				while (true)
				{
					uint num3;
					int num4;
					switch ((num3 = (uint)num2 ^ 0xBF95A2B2u) % 10u)
					{
					case 9u:
						num5 = k[400] - 57836;
						num2 = ((int)num3 * -944657431) ^ -1661099984;
						continue;
					case 8u:
						while (true)
						{
							switch (num5)
							{
							case 10:
								val = (IEvidenceFactory)(object)global::c.e.u.smethod_2(byte_0);
								num5 = k[535] - 56156;
								continue;
							case 3:
								val = null;
								num5 = k[207] - 15903;
								continue;
							case 2:
								goto IL_008d;
							case 9:
								num5 = 1;
								goto IL_0098;
							case 1:
							case 4:
								goto IL_0098;
							case 6:
								goto end_IL_00f4;
							case 0:
							case 8:
								num++;
								num5 = 7;
								goto case 5;
							case 5:
							case 7:
								return val as Assembly;
							}
							break;
						}
						num2 = -455146570;
						continue;
					case 0u:
						goto IL_008d;
					case 6u:
						goto IL_0098;
					default:
						num4 = 10;
						goto IL_00b2;
					case 7u:
						num4 = k[97] - 23342;
						goto IL_00b2;
					case 5u:
						num2 = ((int)num3 * -1776073173) ^ 0x2BA25DFB;
						continue;
					case 3u:
						num2 = (int)(num3 * 832093363) ^ -8369873;
						continue;
					case 2u:
						num2 = -959559068;
						continue;
					case 4u:
						break;
						IL_0098:
						switch (((char_0 ^ int_0) - 86) ^ num)
						{
						default:
							num2 = -1058274249;
							continue;
						case 0:
							break;
						}
						goto default;
						IL_00b2:
						num5 = num4;
						num2 = -959559068;
						continue;
						IL_008d:
						num5 = 6;
						num2 = -578799173;
						continue;
						end_IL_00f4:
						break;
					}
					break;
				}
			}
		}

		static void smethod_0(Stream stream_0, byte byte_0)
		{
			stream_0.WriteByte(byte_0);
		}

		static ICryptoTransform smethod_1(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0, byte[] byte_1)
		{
			return symmetricAlgorithm_0.CreateDecryptor(byte_0, byte_1);
		}

		static Assembly smethod_2(byte[] byte_0)
		{
			return Assembly.Load(byte_0);
		}
	}

	internal sealed class i
	{
		internal byte[] w;

		internal i()
		{
		}
	}

	public static string e;

	private static bool p(Assembly assembly_0, Assembly assembly_1)
	{
		char[] array = global::c.e.e.k;
		object obj = default(object);
		object obj2 = default(object);
		int num5 = default(int);
		int num4 = default(int);
		int[] array2 = default(int[]);
		while (true)
		{
			int num = -450737593;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xC3CBEA33u) % 11u)
				{
				case 10u:
					num = ((int)num2 * -467018091) ^ -1503856360;
					continue;
				case 9u:
				{
					int num6;
					if ((byte[])obj == null != !(obj2 is byte[]))
					{
						num = -1744652435;
						num6 = -1744652435;
					}
					else
					{
						num = -1945220999;
						num6 = -1945220999;
					}
					continue;
				}
				case 8u:
					num3 = 10;
					goto IL_0050;
				case 6u:
					goto IL_005b;
				case 5u:
					num4 = 4;
					num = (int)((num2 * 458045325) ^ 0x773D3FBF);
					continue;
				case 4u:
					while (true)
					{
						switch (num4)
						{
						case 5:
							break;
						case 6:
							goto IL_005b;
						case 0:
						case 13:
							if (obj is byte[])
							{
								num4 = array[547] - 42035;
								continue;
							}
							num4 = 2;
							goto case 2;
						case 8:
						case 12:
							if (num5 < ((byte[])obj).Length)
							{
								num4 = 1;
								goto case 1;
							}
							num4 = 2;
							goto case 2;
						case 1:
							if (((byte[])obj)[num5] != ((byte[])obj2)[num5])
							{
								num4 = array[318] - 21041;
								continue;
							}
							num4 = 7;
							goto case 7;
						case 7:
						case 9:
							num5++;
							num4 = array2[306] - 34797;
							continue;
						case 11:
							num5 = 0;
							num4 = array[474] - 30907;
							continue;
						default:
							goto IL_0154;
						case 4:
							goto IL_015b;
						case 3:
							return false;
						case 10:
							return false;
						case 2:
							return true;
						}
						break;
					}
					goto case 9u;
				case 2u:
					goto IL_015b;
				case 3u:
					num4 = 6;
					num = ((int)num2 * -806338296) ^ 0x23D5F9DA;
					continue;
				case 1u:
					array2 = global::c.l.x;
					num = ((int)num2 * -883508497) ^ 0x63C25D9E;
					continue;
				default:
					num3 = 13;
					goto IL_0050;
				case 7u:
					break;
					IL_015b:
					obj2 = j.t(global::c.f.s(assembly_0, 697, 765), 130, 205);
					num = -841276446;
					continue;
					IL_0154:
					num = -650811575;
					continue;
					IL_005b:
					obj = j.t(global::c.f.s(assembly_1, 527, 587), 778, 837);
					num4 = 5;
					num = -1872766063;
					continue;
					IL_0050:
					num4 = num3;
					num = -983456174;
					continue;
				}
				break;
			}
		}
	}

	private static ICryptoTransform p(byte[] byte_0, byte[] byte_1, bool bool_0)
	{
		int[] array = global::c.l.x;
		char[] array2 = global::c.e.e.k;
		object obj = global::c.e.smethod_0();
		IDisposable disposable;
		try
		{
			int num = 3;
			while (true)
			{
				IL_00bd:
				int num2 = 1932856092;
				while (true)
				{
					uint num3;
					int num4;
					switch ((num3 = (uint)num2 ^ 0x1513C7E9u) % 5u)
					{
					case 4u:
					{
						ICryptoTransform cryptoTransform;
						switch (num)
						{
						default:
							num2 = 2092901631;
							continue;
						case 2:
						case 3:
							break;
						case 1:
							cryptoTransform = m.q(obj as SymmetricAlgorithm, byte_0, byte_1, 653, 726);
							goto IL_00f4;
						case 0:
						case 4:
						case 5:
							{
								cryptoTransform = u.c(obj as SymmetricAlgorithm, byte_0, byte_1, 618, 524);
								goto IL_00f4;
							}
							IL_00f4:
							disposable = cryptoTransform;
							goto end_IL_0097;
						}
						goto case 1u;
					}
					case 1u:
					{
						int num6;
						if (bool_0)
						{
							num2 = 99783948;
							num6 = 99783948;
						}
						else
						{
							num2 = 1385043816;
							num6 = 1385043816;
						}
						continue;
					}
					default:
					{
						char num5 = array2[41];
						global::c.e.e.k[433] = (char)(global::c.e.e.k[433] & global::c.e.e.k[575] & '¹');
						num4 = num5 - 50514;
						goto IL_008c;
					}
					case 0u:
						num4 = 1;
						goto IL_008c;
					case 3u:
						break;
						IL_008c:
						num = num4;
						num2 = 1932856092;
						continue;
					}
					goto IL_00bd;
					continue;
					end_IL_0097:
					break;
				}
				break;
			}
		}
		finally
		{
			int num7 = 5;
			while (true)
			{
				IL_019d:
				int num8 = 1713114048;
				while (true)
				{
					uint num3;
					int num9;
					switch ((num3 = (uint)num8 ^ 0x1513C7E9u) % 6u)
					{
					case 5u:
					{
						int num10;
						if ((SymmetricAlgorithm)obj == null)
						{
							num8 = 1760051845;
							num10 = 1760051845;
						}
						else
						{
							num8 = 518099326;
							num10 = 518099326;
						}
						continue;
					}
					case 4u:
						num8 = (int)(num3 * 34059101) ^ -875591462;
						continue;
					case 3u:
						switch (num7)
						{
						case 2:
						case 5:
							break;
						default:
							num8 = 1681433668;
							continue;
						case 1:
						case 4:
							global::c.e.smethod_1((IDisposable)(SymmetricAlgorithm)obj);
							goto end_IL_0173;
						case 0:
						case 3:
							goto end_IL_0173;
						}
						goto case 5u;
					default:
						num9 = 0;
						goto IL_015b;
					case 1u:
						num9 = array[181] - 40518;
						goto IL_015b;
					case 0u:
						break;
						IL_015b:
						num7 = num9;
						num8 = 794288139;
						continue;
					}
					goto IL_019d;
					continue;
					end_IL_0173:
					break;
				}
				break;
			}
		}
		return (ICryptoTransform)disposable;
	}

	private static ICryptoTransform f(byte[] byte_0, byte[] byte_1, bool bool_0)
	{
		int[] array = global::c.l.x;
		char[] array2 = global::c.e.e.k;
		object obj = global::c.e.smethod_2();
		object obj2;
		try
		{
			int num = 1;
			while (true)
			{
				IL_009e:
				int num2 = -1713470640;
				while (true)
				{
					uint num3;
					int num4;
					switch ((num3 = (uint)num2 ^ 0xE9A7CECBu) % 6u)
					{
					case 4u:
						num4 = 0;
						goto IL_001a;
					case 3u:
					{
						ICryptoTransform cryptoTransform;
						switch (num)
						{
						default:
							num2 = -73003397;
							continue;
						case 1:
						case 3:
							break;
						case 0:
							cryptoTransform = m.q((SymmetricAlgorithm)(DESCryptoServiceProvider)obj, byte_0, byte_1, (short)208, 139);
							goto IL_00d5;
						case 2:
						case 4:
						case 5:
							{
								cryptoTransform = u.c((SymmetricAlgorithm)(DESCryptoServiceProvider)obj, byte_0, byte_1, (short)282, (short)380);
								goto IL_00d5;
							}
							IL_00d5:
							obj2 = cryptoTransform;
							goto end_IL_0074;
						}
						goto case 0u;
					}
					case 0u:
					{
						int num5;
						if (bool_0)
						{
							num2 = -560110399;
							num5 = -560110399;
						}
						else
						{
							num2 = -677771787;
							num5 = -677771787;
						}
						continue;
					}
					default:
						num4 = 5;
						goto IL_001a;
					case 1u:
						num2 = (int)((num3 * 680668928) ^ 0x682D9650);
						continue;
					case 5u:
						break;
						IL_001a:
						num = num4;
						num2 = -1331339472;
						continue;
					}
					goto IL_009e;
					continue;
					end_IL_0074:
					break;
				}
				break;
			}
		}
		finally
		{
			int num6 = 2;
			while (true)
			{
				IL_018a:
				int num7 = -1013032777;
				while (true)
				{
					uint num3;
					int num8;
					switch ((num3 = (uint)num7 ^ 0xE9A7CECBu) % 6u)
					{
					case 4u:
						switch (num6)
						{
						default:
							num7 = -1695178566;
							continue;
						case 1:
						case 2:
						case 3:
							break;
						case 0:
						case 4:
							global::c.e.smethod_1((IDisposable)(obj as DESCryptoServiceProvider));
							goto end_IL_0160;
						case 5:
							goto end_IL_0160;
						}
						goto case 3u;
					case 3u:
					{
						int num9;
						if ((DESCryptoServiceProvider)obj != null)
						{
							num7 = -2122271235;
							num9 = -2122271235;
						}
						else
						{
							num7 = -1943586531;
							num9 = -1943586531;
						}
						continue;
					}
					case 2u:
						num8 = array[349] - 45810;
						goto IL_0138;
					case 1u:
						num7 = ((int)num3 * -1047214258) ^ -8887723;
						continue;
					default:
						num8 = array2[140] - 5902;
						goto IL_0138;
					case 5u:
						break;
						IL_0138:
						num6 = num8;
						num7 = -595871764;
						continue;
					}
					goto IL_018a;
					continue;
					end_IL_0160:
					break;
				}
				break;
			}
		}
		ICryptoTransform result = (ICryptoTransform)obj2;
		global::c.e.e.k[218] = (char)((global::c.e.e.k[218] * global::c.e.e.k[252]) & '?');
		return result;
	}

	public static byte[] s(byte[] byte_0)
	{
		int[] array = global::c.l.x;
		char[] array8 = default(char[]);
		_Assembly val2 = default(_Assembly);
		IEvidenceFactory val = default(IEvidenceFactory);
		int num21 = default(int);
		object obj = default(object);
		object obj3 = default(object);
		int num13 = default(int);
		int num14 = default(int);
		int num15 = default(int);
		int num16 = default(int);
		int num20 = default(int);
		Array array5 = default(Array);
		int num19 = default(int);
		object obj4 = default(object);
		Array array3 = default(Array);
		int num18 = default(int);
		short num17 = default(short);
		int num5 = default(int);
		int num12 = default(int);
		Array array4 = default(Array);
		int num4 = default(int);
		Array array2 = default(Array);
		object obj7 = default(object);
		Array array10 = default(Array);
		object obj9 = default(object);
		while (true)
		{
			int num = -1649486058;
			while (true)
			{
				int num3;
				uint num2;
				switch ((num2 = (uint)num ^ 0xA4548AB6u) % 9u)
				{
				case 8u:
					array8 = global::c.e.e.k;
					num = ((int)num2 * -1010457157) ^ 0x3A266D89;
					continue;
				case 7u:
					num4 = 1;
					num = (int)((num2 * 1813641699) ^ 0x1F9755A2);
					continue;
				case 6u:
					val2 = (_Assembly)(object)global::c.e.smethod_3();
					num = -1030736833;
					continue;
				case 5u:
					num3 = array[260] - 62065;
					goto IL_0056;
				case 4u:
				{
					val = (IEvidenceFactory)(object)global::c.g.x(342, 367);
					int num32;
					int num33;
					if ((object)(val2 as Assembly) == (Assembly)(object)val)
					{
						num32 = 1672818530;
						num33 = 1672818530;
					}
					else
					{
						num32 = 1380743700;
						num33 = 1380743700;
					}
					num = num32 ^ (int)(num2 * 2015861196);
					continue;
				}
				case 2u:
					while (true)
					{
						int num22;
						switch (num4)
						{
						case 1:
							break;
						case 35:
						{
							Array array12 = new byte[num21];
							global::c.b.w((Stream)(obj as u), array12 as byte[], 0, num21, (short)631, 'ȫ');
							num4 = array[48] - 33531;
							continue;
						}
						case 34:
							obj = new u(byte_0);
							obj3 = new byte[0];
							num13 = ((u)obj).r();
							num4 = array8[192] - 58152;
							continue;
						case 33:
							if (num14 == 1)
							{
								num4 = 10;
								goto case 10;
							}
							num4 = array[95] - 48742;
							continue;
						case 10:
							num15 = (obj as u).r();
							obj3 = new byte[num15];
							num16 = 0;
							num4 = 9;
							goto case 9;
						case 9:
							if (num16 >= num15)
							{
								num4 = array8[172] - 27005;
								continue;
							}
							num4 = 28;
							goto case 28;
						case 28:
						{
							int num31 = (obj as u).r();
							num20 = ((u)obj).r();
							array5 = new byte[num31];
							num4 = array8[169] - 51763;
							continue;
						}
						case 31:
							if (num19 == 8)
							{
								num4 = array8[169] - 51761;
								continue;
							}
							num4 = 8;
							goto case 8;
						case 30:
							if (num14 == 2)
							{
								num4 = 20;
								goto case 20;
							}
							goto IL_0782;
						case 20:
						{
							byte[] array6 = new byte[8];
							global::c.e.smethod_5((Array)array6, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
							obj4 = array6;
							byte[] array7 = new byte[8];
							global::c.e.smethod_5((Array)array7, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
							array3 = array7;
							num4 = array8[344] - 31137;
							continue;
						}
						case 29:
							if (num18 == 0)
							{
								num4 = array8[440] - 45222;
								continue;
							}
							num4 = 8;
							goto case 8;
						case 27:
							if (num13 == 67324752)
							{
								num4 = array8[535] - 56143;
								continue;
							}
							num4 = 16;
							goto case 16;
						case 16:
							num14 = num13 >> 24;
							num13 -= num14 << 24;
							num4 = array8[486] - 61326;
							continue;
						case 7:
						case 26:
							if (num13 == 67324752)
							{
								num4 = 25;
								goto case 25;
							}
							num4 = array[104] - 24107;
							continue;
						case 25:
							if (num17 == 20)
							{
								num4 = 29;
								goto case 29;
							}
							num4 = 8;
							goto case 8;
						case 24:
							num5 = (obj as u).r();
							num21 = ((u)obj).u();
							num12 = (obj as u).u();
							num4 = 2;
							goto case 2;
						case 2:
							if (num21 > 0)
							{
								num4 = 35;
								goto case 35;
							}
							num4 = array8[516] - 20542;
							continue;
						case 23:
						{
							object obj6 = new g(array5 as byte[]);
							(obj6 as g).s((byte[])obj3, num16, num20);
							goto case 17;
						}
						case 17:
							num4 = 0;
							goto case 0;
						case 0:
							num16 += num20;
							num4 = 9;
							goto case 9;
						case 21:
							num17 = (short)((u)obj).u();
							num18 = ((u)obj).u();
							num19 = (obj as u).u();
							num4 = 26;
							goto case 7;
						case 15:
							goto IL_0357;
						case 13:
							if (num12 > 0)
							{
								num4 = array[197] - 40886;
								continue;
							}
							num4 = 11;
							goto case 11;
						case 11:
							array2 = new byte[n((Stream)(obj as u), (short)714, 729) - n((Stream)(obj as u), (short)322, 342)];
							num4 = array8[38] - 47645;
							continue;
						case 6:
							if (num13 == 8223355)
							{
								num4 = array[109] - 54905;
								continue;
							}
							goto IL_0a20;
						case 5:
							(obj as u).r();
							(obj as u).r();
							((u)obj).r();
							num4 = 24;
							goto case 24;
						case 4:
						{
							object obj5 = new byte[num12];
							global::c.b.w((Stream)(u)obj, obj5 as byte[], 0, num12, (short)82, '\u000e');
							num4 = 11;
							goto case 11;
						}
						case 3:
							global::c.b.w((Stream)(u)obj, (byte[])array5, 0, (array5 as byte[]).Length, (short)968, 'Δ');
							num4 = array[277] - 53051;
							continue;
						default:
							goto IL_053f;
						case 14:
						{
							IDisposable disposable = f(obj4 as byte[], (byte[])array3, bool_0: true);
							try
							{
								int num6 = 5;
								while (true)
								{
									IL_0664:
									int num7 = -1804712626;
									while (true)
									{
										switch ((num2 = (uint)num7 ^ 0xA4548AB6u) % 7u)
										{
										case 6u:
											num6 = array[346] - 43970;
											num7 = ((int)num2 * -1910067082) ^ -289617031;
											continue;
										case 3u:
											obj3 = s((byte[])array4);
											num7 = -190783411;
											continue;
										case 2u:
											goto IL_05e8;
										case 1u:
											switch (num6)
											{
											case 0:
											case 4:
												break;
											case 1:
											case 2:
											case 5:
												goto IL_05e8;
											default:
												goto IL_0623;
											case 3:
												goto end_IL_0637;
											}
											goto case 3u;
										case 0u:
											num7 = ((int)num2 * -388472311) ^ -228767635;
											continue;
										default:
											goto end_IL_0637;
										case 5u:
											break;
										case 4u:
											goto end_IL_0637;
											IL_0623:
											num7 = -2042476378;
											continue;
											IL_05e8:
											array4 = global::c.e.smethod_6((ICryptoTransform)disposable, byte_0, 4, byte_0.Length - 4);
											num7 = -1481516592;
											continue;
										}
										goto IL_0664;
										continue;
										end_IL_0637:
										break;
									}
									break;
								}
							}
							finally
							{
								int num8 = 5;
								while (true)
								{
									IL_06f1:
									int num9 = -973576681;
									while (true)
									{
										int num11;
										switch ((num2 = (uint)num9 ^ 0xA4548AB6u) % 5u)
										{
										case 3u:
											num11 = 4;
											goto IL_0676;
										default:
											num11 = 0;
											goto IL_0676;
										case 1u:
											switch (num8)
											{
											default:
												num9 = -202380465;
												continue;
											case 1:
											case 2:
											case 5:
											case 6:
												break;
											case 3:
											case 4:
												global::c.e.smethod_1((IDisposable)(disposable as ICryptoTransform));
												goto end_IL_06cc;
											case 0:
												goto end_IL_06cc;
											}
											goto case 0u;
										case 0u:
										{
											int num10;
											if ((ICryptoTransform)disposable == null)
											{
												num9 = -576472244;
												num10 = -576472244;
											}
											else
											{
												num9 = -2023503167;
												num10 = -2023503167;
											}
											continue;
										}
										case 4u:
											break;
											IL_0676:
											num8 = num11;
											num9 = -973576681;
											continue;
										}
										goto IL_06f1;
										continue;
										end_IL_06cc:
										break;
									}
									break;
								}
							}
							goto IL_0782;
						}
						case 18:
							global::c.b.w((Stream)(obj as u), array2 as byte[], 0, ((byte[])array2).Length, (short)1002, 'ζ');
							goto case 19;
						case 19:
							num4 = 12;
							goto case 12;
						case 12:
						{
							object obj2 = new g(array2 as byte[]);
							obj3 = new byte[num5];
							((g)obj2).s(obj3 as byte[], 0, (obj3 as byte[]).Length);
							num4 = 22;
							goto case 22;
						}
						case 22:
							array2 = null;
							goto IL_0a0d;
						case 8:
							throw global::c.e.smethod_4(global::c.t.h(3, 1517858947, '×'));
						case 32:
							{
								return null;
							}
							IL_0782:
							num22 = 2;
							while (true)
							{
								int num23 = -555051973;
								while (true)
								{
									byte[] array9;
									switch ((num2 = (uint)num23 ^ 0xA4548AB6u) % 8u)
									{
									case 6u:
									{
										byte[] array11 = new byte[16];
										global::c.e.smethod_5((Array)array11, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
										obj7 = array11;
										num22 = array[41] - 32973;
										num23 = (int)(num2 * 1360463352) ^ -1789602773;
										continue;
									}
									case 5u:
										switch (num22)
										{
										case 0:
										case 3:
										case 5:
											goto IL_07e3;
										case 1:
										case 2:
										case 6:
											goto end_IL_0836;
										case 4:
											goto IL_0864;
										}
										num23 = -1902782939;
										continue;
									case 1u:
										goto IL_07e3;
									case 3u:
										break;
									case 2u:
										num23 = (int)((num2 * 1122491974) ^ 0x13B33B87);
										continue;
									case 0u:
										num22 = 5;
										num23 = ((int)num2 * -1115948342) ^ 0x771257AC;
										continue;
									case 4u:
										goto end_IL_082c;
									default:
										goto IL_0864;
										IL_07e3:
										array9 = new byte[16];
										global::c.e.smethod_5((Array)array9, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
										array10 = array9;
										num23 = -987243320;
										continue;
										end_IL_0836:
										break;
									}
									if (num14 != 3)
									{
										goto end_IL_085d;
									}
									num23 = -244445154;
									continue;
									IL_0864:
									object obj8 = p(array10 as byte[], obj7 as byte[], bool_0: true);
									try
									{
										int num24 = 4;
										while (true)
										{
											IL_0905:
											int num25 = -994648795;
											while (true)
											{
												switch ((num2 = (uint)num25 ^ 0xA4548AB6u) % 5u)
												{
												case 4u:
													num24 = array[264] - 50014;
													num25 = ((int)num2 * -397703968) ^ -1741635931;
													continue;
												case 3u:
													obj9 = global::c.e.smethod_6((ICryptoTransform)obj8, byte_0, 4, byte_0.Length - 4);
													num25 = -708005070;
													continue;
												case 1u:
													switch (num24)
													{
													case 0:
													case 3:
													case 4:
														break;
													default:
														goto IL_08db;
													case 1:
													case 2:
													case 5:
														goto IL_090c;
													}
													goto case 3u;
												case 2u:
													break;
												default:
													goto IL_090c;
													IL_090c:
													obj3 = s(obj9 as byte[]);
													goto end_IL_08e0;
													IL_08db:
													num25 = -1387325999;
													continue;
												}
												goto IL_0905;
												continue;
												end_IL_08e0:
												break;
											}
											break;
										}
									}
									finally
									{
										int num26 = 3;
										while (true)
										{
											IL_09c5:
											int num27 = -341557291;
											while (true)
											{
												int num28;
												switch ((num2 = (uint)num27 ^ 0xA4548AB6u) % 6u)
												{
												case 5u:
													switch (num26)
													{
													default:
														num27 = -941246268;
														continue;
													case 1:
													case 2:
													case 3:
													case 4:
														break;
													case 0:
													case 5:
														global::c.e.smethod_1((IDisposable)(ICryptoTransform)obj8);
														goto end_IL_099c;
													case 6:
														goto end_IL_099c;
													}
													goto case 2u;
												case 2u:
												{
													int num29;
													if (obj8 is ICryptoTransform)
													{
														num27 = -1047739887;
														num29 = -1047739887;
													}
													else
													{
														num27 = -299064082;
														num29 = -299064082;
													}
													continue;
												}
												default:
													num28 = array8[546] - 46085;
													goto IL_0981;
												case 3u:
													num27 = (int)(num2 * 1690642479) ^ -609519034;
													continue;
												case 1u:
													num28 = 5;
													goto IL_0981;
												case 0u:
													break;
													IL_0981:
													num26 = num28;
													num27 = -1789398677;
													continue;
												}
												goto IL_09c5;
												continue;
												end_IL_099c:
												break;
											}
											break;
										}
									}
									goto end_IL_085d;
									continue;
									end_IL_082c:
									break;
								}
								continue;
								end_IL_085d:
								break;
							}
							goto IL_0a0d;
							IL_0a0d:
							while (true)
							{
								global::c.e.smethod_7((Stream)(u)obj);
								int num30 = -456139568;
								while (true)
								{
									switch ((num2 = (uint)num30 ^ 0xA4548AB6u) % 5u)
									{
									case 2u:
										obj = null;
										num30 = -1475640687;
										continue;
									case 0u:
										num30 = -2072395924;
										continue;
									case 1u:
										break;
									case 3u:
										goto end_IL_0a0d;
									default:
										return obj3 as byte[];
									}
									break;
								}
								continue;
								end_IL_0a0d:
								break;
							}
							goto IL_0a20;
							IL_0a20:
							throw global::c.e.smethod_4(global::c.t.h(4, 1517858973, 'º'));
						}
						break;
						IL_0357:
						num4 = (p(val as Assembly, (Assembly)(object)val2) ? (array[311] - 53252) : (array8[509] - 2941));
					}
					goto case 6u;
				default:
					num3 = 34;
					goto IL_0056;
				case 0u:
					num = ((int)num2 * -290709941) ^ 0x3DC7AE4F;
					continue;
				case 3u:
					break;
					IL_053f:
					num = -1072853966;
					continue;
					IL_0056:
					num4 = num3;
					num = -1284170426;
					continue;
				}
				break;
			}
		}
	}

	public static byte[] k(byte[] byte_0)
	{
		return s(byte_0, 1, null, null);
	}

	public static byte[] k(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		return s(byte_0, 2, byte_1, byte_2);
	}

	public static byte[] s(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		return s(byte_0, 3, byte_1, byte_2);
	}

	private static byte[] s(byte[] byte_0, int int_0, byte[] byte_1, byte[] byte_2)
	{
		char[] array = global::c.e.e.k;
		int[] array2 = global::c.l.x;
		Array array8 = default(Array);
		try
		{
			int num = 37;
			object obj = default(object);
			Array array6 = default(Array);
			long num13 = default(long);
			long long_2 = default(long);
			object obj4 = default(object);
			uint num19 = default(uint);
			uint num15 = default(uint);
			long num20 = default(long);
			object obj6 = default(object);
			object obj7 = default(object);
			int num17 = default(int);
			long long_3 = default(long);
			long long_ = default(long);
			int num14 = default(int);
			object obj3 = default(object);
			int num16 = default(int);
			int num18 = default(int);
			object obj9 = default(object);
			int num30 = default(int);
			object obj5 = default(object);
			object obj10 = default(object);
			int num32 = default(int);
			Array array3 = default(Array);
			Array array7 = default(Array);
			int num29 = default(int);
			Array array5 = default(Array);
			object obj8 = default(object);
			Array array4 = default(Array);
			while (true)
			{
				IL_0a45:
				int num2 = 828314174;
				while (true)
				{
					uint num3;
					int num4;
					switch ((num3 = (uint)num2 ^ 0x2D5B28C9u) % 7u)
					{
					case 6u:
						obj = new u();
						num2 = 96511163;
						continue;
					case 4u:
						while (true)
						{
							switch (num)
							{
							case 37:
							case 49:
								break;
							case 58:
								((u)obj).a((int)(30 + ((byte[])array6).Length + num13));
								num = 42;
								goto case 42;
							case 42:
								(obj as u).f(0);
								global::c.b.g((Stream)(obj as u), long_2, SeekOrigin.Begin, '@', (short)54);
								num = array2[67] - 55294;
								continue;
							case 57:
							{
								uint[] array9 = new uint[256];
								global::c.e.smethod_5((Array)array9, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
								obj4 = array9;
								num19 = uint.MaxValue;
								num15 = uint.MaxValue;
								num = array2[122] - 5497;
								continue;
							}
							case 56:
								((u)obj).a(byte_0.Length);
								((u)obj).f(((byte[])array6).Length);
								num = array2[291] - 946;
								continue;
							case 55:
								(obj as u).f(0);
								((u)obj).f(8);
								((u)obj).a((int)num20);
								num = array2[28] - 62780;
								continue;
							case 54:
								if (((p)obj6).c)
								{
									num = 33;
									goto case 33;
								}
								num = 21;
								goto case 21;
							case 21:
								obj7 = new byte[512];
								num17 = (obj6 as p).a(obj7 as byte[]);
								if (num17 > 0)
								{
									num = array[267] - 51148;
									continue;
								}
								num = 33;
								goto case 33;
							case 33:
								long_3 = n((Stream)(obj as u), (short)496, 484);
								m.i((Stream)(obj as u), long_, (short)262, (short)341);
								num = array[284] - 49194;
								continue;
							case 53:
								(obj as u).a(25000571);
								(obj as u).a(byte_0.Length);
								num = 15;
								goto case 15;
							case 15:
								num14 = 0;
								num = 26;
								goto case 26;
							case 26:
								if (num14 < byte_0.Length)
								{
									num = 44;
									goto case 44;
								}
								num = 30;
								goto case 30;
							case 44:
								obj3 = new byte[global::c.b.y(2097151, byte_0.Length - num14, 782, ';')];
								num = array[501] - 39622;
								continue;
							case 52:
								num16 = 0;
								num18 = byte_0.Length;
								num = array2[229] - 63011;
								continue;
							case 51:
								num = array2[62] - 25267;
								continue;
							case 50:
								obj9 = new byte[512];
								num30 = (obj5 as p).a((byte[])obj9);
								if (num30 > 0)
								{
									num = 22;
									goto case 22;
								}
								num = 16;
								goto case 16;
							case 22:
								x((Stream)(obj as u), (byte[])obj9, 0, num30, '\u032c', (short)788);
								goto case 12;
							case 12:
								num = ((!(obj5 as p).e) ? (array[506] - 30702) : (array[66] - 12075));
								continue;
							case 16:
								((p)obj5).w();
								num = 29;
								goto case 29;
							case 10:
								obj10 = new byte[512];
								num32 = (obj5 as p).a((byte[])obj10);
								if (num32 > 0)
								{
									num = 11;
									goto case 11;
								}
								num = 0;
								goto case 0;
							case 11:
								x((Stream)(obj as u), (byte[])obj10, 0, num32, 'ȷ', (short)527);
								goto case 29;
							case 29:
								if (!(obj5 as p).c)
								{
									num = 10;
									goto case 10;
								}
								num = 0;
								goto case 0;
							case 0:
								num13 = (obj5 as p).p;
								(obj as u).a(33639248);
								((u)obj).f(20);
								num = 20;
								goto case 20;
							case 20:
								(obj as u).f(20);
								(obj as u).f(0);
								(obj as u).f(8);
								num = 28;
								goto case 28;
							case 28:
								((u)obj).a((int)num20);
								(obj as u).a((int)num15);
								(obj as u).a((int)num13);
								num = array[247] - 18138;
								continue;
							case 48:
								x((Stream)(u)obj, (byte[])array6, 0, ((byte[])array6).Length, '\u0335', (short)781);
								num = 35;
								goto case 35;
							case 35:
								((p)obj5).p(byte_0);
								num = array2[238] - 28211;
								continue;
							case 6:
							case 47:
								x((Stream)(obj as u), (byte[])array6, 0, (array6 as byte[]).Length, 'Æ', (short)254);
								num = 3;
								goto case 3;
							case 3:
								(obj as u).a(101010256);
								((u)obj).f(0);
								((u)obj).f(0);
								num = 34;
								goto case 34;
							case 34:
								(obj as u).f(1);
								(obj as u).f(1);
								(obj as u).a(46 + ((byte[])array6).Length);
								num = 58;
								goto case 58;
							case 46:
								((p)obj6).w();
								num = 54;
								goto case 54;
							case 45:
								((u)obj).a(41777787);
								array3 = s(byte_0, 1, null, null);
								num = array2[154] - 30076;
								continue;
							case 31:
							case 43:
								(obj as u).a(((byte[])obj3).Length);
								obj6 = new p();
								(obj6 as p).p((byte[])obj3);
								num = 4;
								goto case 4;
							case 4:
								if ((obj6 as p).e)
								{
									num = array2[291] - 918;
									continue;
								}
								num = 7;
								goto case 7;
							case 7:
								array7 = new byte[512];
								num29 = (obj6 as p).a(array7 as byte[]);
								if (num29 > 0)
								{
									num = array2[334] - 7546;
									continue;
								}
								num = 46;
								goto case 46;
							case 39:
								num14 += ((byte[])obj3).Length;
								num = 26;
								goto case 26;
							case 38:
								(obj as u).a((int)num15);
								long_2 = n((Stream)(obj as u), (short)610, 630);
								num = array[256] - 38349;
								continue;
							case 36:
								x((Stream)(obj as u), array7 as byte[], 0, num29, 'Ù', (short)225);
								goto case 4;
							case 32:
								(obj as u).a(0);
								(obj as u).a(byte_0.Length);
								num = 2;
								goto case 2;
							case 2:
								array6 = global::c.g.a(w(627, 'ɤ'), global::c.t.h(4, 1517859186, '\u0098'), 340, 277);
								num = 23;
								goto case 23;
							case 23:
								((u)obj).f((array6 as byte[]).Length);
								(obj as u).f(0);
								num = array2[18] - 54926;
								continue;
							case 27:
							{
								obj5 = new p();
								DateTime dateTime_ = global::c.f.g(255, '\u00b8');
								num20 = (uint)((((global::c.f.n(ref dateTime_, 'ʗ', 683) - 1980) & 0x7F) << 25) | (global::c.f.n(ref dateTime_, '6', 11) << 21) | (global::c.f.n(ref dateTime_, 'Ǘ', 489) << 16) | (global::c.f.n(ref dateTime_, '\u0016', 41) << 11) | (global::c.f.n(ref dateTime_, '\u0336', 886) << 5) | (int)((uint)global::c.u.l(ref dateTime_, 455, 'Ǧ') >> 1));
								num = 57;
								goto case 57;
							}
							case 25:
							{
								if (int_0 == 2)
								{
									num = 45;
									goto case 45;
								}
								int num21 = 3;
								while (true)
								{
									int num22 = 884105758;
									while (true)
									{
										switch ((num3 = (uint)num22 ^ 0x2D5B28C9u) % 10u)
										{
										case 9u:
											array5 = s(byte_0, 1, null, null);
											num22 = 1099305962;
											continue;
										case 8u:
											num21 = 4;
											num22 = ((int)num3 * -1026871433) ^ -1990638165;
											continue;
										case 7u:
											switch (num21)
											{
											case 1:
											case 6:
												break;
											default:
												goto IL_0aa1;
											case 4:
												goto IL_0aa8;
											case 3:
											case 5:
												goto end_IL_0b13;
											case 0:
											case 2:
												goto IL_0b49;
											}
											goto case 9u;
										case 6u:
											goto IL_0aa8;
										case 1u:
											break;
										case 3u:
											num21 = array[362] - 63217;
											num22 = ((int)num3 * -826386504) ^ 0x5C310565;
											continue;
										case 2u:
											num22 = ((int)num3 * -468191429) ^ 0x73BCA172;
											continue;
										case 0u:
											num22 = ((int)num3 * -1712112849) ^ -755117546;
											continue;
										case 5u:
											goto end_IL_0b08;
										default:
											goto IL_0b49;
											IL_0aa8:
											(obj as u).a(58555003);
											num22 = 1589692070;
											continue;
											IL_0aa1:
											num22 = 1876143094;
											continue;
											end_IL_0b13:
											break;
										}
										if (int_0 != 3)
										{
											goto end_IL_0b42;
										}
										num22 = 1490970879;
										continue;
										IL_0b49:
										IDisposable disposable = p(byte_1, byte_2, bool_0: false);
										try
										{
											int num23 = 1;
											while (true)
											{
												IL_0bfa:
												int num24 = 631288201;
												while (true)
												{
													switch ((num3 = (uint)num24 ^ 0x2D5B28C9u) % 5u)
													{
													case 4u:
														global::c.e.smethod_8((Stream)(obj as u), obj8 as byte[], 0, ((byte[])obj8).Length);
														num24 = 1446183402;
														continue;
													case 1u:
														switch (num23)
														{
														case 4:
														case 5:
															break;
														default:
															goto IL_0b9e;
														case 0:
														case 1:
														case 2:
														case 3:
															goto IL_0ba5;
														}
														goto case 4u;
													case 0u:
														goto IL_0ba5;
													default:
														goto end_IL_0bd5;
													case 2u:
														break;
													case 3u:
														goto end_IL_0bd5;
														IL_0ba5:
														obj8 = global::c.e.smethod_6(disposable as ICryptoTransform, (byte[])array5, 0, (array5 as byte[]).Length);
														num23 = array2[92] - 15785;
														num24 = 631288201;
														continue;
														IL_0b9e:
														num24 = 1083574394;
														continue;
													}
													goto IL_0bfa;
													continue;
													end_IL_0bd5:
													break;
												}
												break;
											}
										}
										finally
										{
											int num25 = 3;
											while (true)
											{
												IL_0c98:
												int num26 = 238503057;
												while (true)
												{
													int num27;
													switch ((num3 = (uint)num26 ^ 0x2D5B28C9u) % 5u)
													{
													case 4u:
														switch (num25)
														{
														default:
															num26 = 1906501159;
															continue;
														case 1:
														case 3:
														case 4:
															break;
														case 0:
														case 2:
															global::c.e.smethod_1((IDisposable)(ICryptoTransform)disposable);
															goto end_IL_0c73;
														case 5:
														case 6:
															goto end_IL_0c73;
														}
														goto case 0u;
													case 0u:
													{
														int num28;
														if (!(disposable is ICryptoTransform))
														{
															num26 = 117331919;
															num28 = 117331919;
														}
														else
														{
															num26 = 1800887683;
															num28 = 1800887683;
														}
														continue;
													}
													case 3u:
														num27 = 2;
														goto IL_0c5b;
													default:
														num27 = array[242] - 49920;
														goto IL_0c5b;
													case 2u:
														break;
														IL_0c5b:
														num25 = num27;
														num26 = 238503057;
														continue;
													}
													goto IL_0c98;
													continue;
													end_IL_0c73:
													break;
												}
												break;
											}
										}
										goto end_IL_0b42;
										continue;
										end_IL_0b08:
										break;
									}
									continue;
									end_IL_0b42:
									break;
								}
								goto case 30;
							}
							case 24:
								if (--num18 < 0)
								{
									num = 19;
									goto case 19;
								}
								num = array[351] - 44925;
								continue;
							case 19:
								num15 ^= num19;
								(obj as u).a(67324752);
								(obj as u).f(20);
								num = 55;
								goto case 55;
							case 18:
								((u)obj).f(0);
								(obj as u).f(0);
								(obj as u).f(0);
								goto case 51;
							case 17:
								x((Stream)(obj as u), (byte[])obj7, 0, num17, 'ƽ', (short)389);
								goto case 54;
							case 14:
								((u)obj).a((int)(obj6 as p).p);
								m.i((Stream)(obj as u), long_3, (short)682, (short)761);
								num = array2[68] - 40557;
								continue;
							case 13:
								if (int_0 == 1)
								{
									num = 53;
									goto case 53;
								}
								num = array[569] - 3896;
								continue;
							case 9:
								num15 = ((uint[])obj4)[(num15 ^ byte_0[num16++]) & 0xFF] ^ (num15 >> 8);
								num = 24;
								goto case 24;
							case 8:
								((u)obj).f(0);
								(obj as u).a(0);
								((u)obj).a(0);
								num = array2[177] - 10656;
								continue;
							case 5:
								m.u((Array)byte_0, num14, (Array)(byte[])obj3, 0, ((byte[])obj3).Length, (short)406, 'Ǚ');
								num = 1;
								goto case 1;
							case 1:
								long_ = n((Stream)(obj as u), (short)493, 505);
								(obj as u).a(0);
								num = array[501] - 39584;
								continue;
							default:
								goto IL_09c3;
							case 40:
								(obj as u).a((int)num13);
								goto case 30;
							case 41:
							{
								object obj2 = f(byte_1, byte_2, bool_0: false);
								try
								{
									int num7 = 5;
									while (true)
									{
										IL_0d8e:
										int num8 = 1473670289;
										while (true)
										{
											switch ((num3 = (uint)num8 ^ 0x2D5B28C9u) % 7u)
											{
											case 6u:
												global::c.e.smethod_8((Stream)(obj as u), (byte[])array4, 0, (array4 as byte[]).Length);
												num8 = 829841308;
												continue;
											case 5u:
												goto IL_0cf6;
											case 4u:
												num7 = 2;
												num8 = ((int)num3 * -946841961) ^ 0x2E4D12C5;
												continue;
											case 2u:
												num8 = ((int)num3 * -600690780) ^ 0x2036769D;
												continue;
											case 1u:
												switch (num7)
												{
												case 2:
													break;
												case 0:
												case 3:
												case 4:
												case 5:
													goto IL_0cf6;
												default:
													goto IL_0d5c;
												case 1:
													goto end_IL_0d61;
												}
												goto case 6u;
											default:
												goto end_IL_0d61;
											case 3u:
												break;
											case 0u:
												goto end_IL_0d61;
												IL_0d5c:
												num8 = 650327993;
												continue;
												IL_0cf6:
												array4 = global::c.e.smethod_6(obj2 as ICryptoTransform, (byte[])array3, 0, (array3 as byte[]).Length);
												num8 = 21456472;
												continue;
											}
											goto IL_0d8e;
											continue;
											end_IL_0d61:
											break;
										}
										break;
									}
								}
								finally
								{
									int num9 = 5;
									while (true)
									{
										IL_0e2c:
										int num10 = 733685947;
										while (true)
										{
											int num11;
											switch ((num3 = (uint)num10 ^ 0x2D5B28C9u) % 5u)
											{
											case 4u:
												switch (num9)
												{
												default:
													num10 = 567196677;
													continue;
												case 0:
												case 4:
												case 5:
												case 6:
													break;
												case 3:
													global::c.e.smethod_1((IDisposable)(obj2 as ICryptoTransform));
													goto end_IL_0e07;
												case 1:
												case 2:
													goto end_IL_0e07;
												}
												goto case 3u;
											case 3u:
											{
												int num12;
												if (obj2 is ICryptoTransform)
												{
													num10 = 2065561526;
													num12 = 2065561526;
												}
												else
												{
													num10 = 691535735;
													num12 = 691535735;
												}
												continue;
											}
											default:
												num11 = array[415] - 21239;
												goto IL_0dfb;
											case 1u:
												num11 = 3;
												goto IL_0dfb;
											case 0u:
												break;
												IL_0dfb:
												num9 = num11;
												num10 = 733685947;
												continue;
											}
											goto IL_0e2c;
											continue;
											end_IL_0e07:
											break;
										}
										break;
									}
								}
								goto case 30;
							}
							case 30:
								while (true)
								{
									IL_0e9f:
									global::c.e.smethod_9((Stream)(u)obj);
									int num31 = 716336337;
									while (true)
									{
										switch ((num3 = (uint)num31 ^ 0x2D5B28C9u) % 5u)
										{
										case 2u:
											global::c.e.smethod_7((Stream)(u)obj);
											num31 = 1151904910;
											continue;
										case 1u:
											array8 = global::c.e.smethod_10((MemoryStream)(u)obj);
											num31 = ((int)num3 * -1489218061) ^ -754175913;
											continue;
										case 0u:
											num31 = 2130829290;
											continue;
										default:
											goto end_IL_0e7a;
										case 4u:
											break;
										case 3u:
											goto end_IL_0e7a;
										}
										goto IL_0e9f;
										continue;
										end_IL_0e7a:
										break;
									}
									break;
								}
								goto end_IL_0a18;
							}
							break;
						}
						goto case 6u;
					default:
						num4 = array2[3] - 24215;
						goto IL_09d3;
					case 2u:
					{
						int num5;
						int num6;
						if (int_0 == 0)
						{
							num5 = -1452092283;
							num6 = -1452092283;
						}
						else
						{
							num5 = -1052653027;
							num6 = -1052653027;
						}
						num2 = num5 ^ ((int)num3 * -1986995993);
						continue;
					}
					case 1u:
						num4 = array[71] - 36806;
						goto IL_09d3;
					case 0u:
						num2 = (int)(num3 * 1778964795) ^ -922714102;
						continue;
					case 5u:
						break;
						IL_09c3:
						num2 = 2070060039;
						continue;
						IL_09d3:
						num = num4;
						num2 = 1011833749;
						continue;
					}
					goto IL_0a45;
					continue;
					end_IL_0a18:
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			global::c.e.e = global::c.e.smethod_12(global::c.t.x(int_0, 427466849, 3), global::c.e.smethod_11(ex));
			throw;
		}
		return (byte[])array8;
	}

	[SecuritySafeCritical]
	internal static MethodInfo a<T>(T gparam_0, char char_0, int int_0) where T : Assembly
	{
		char[] array = global::c.e.e.k;
		int[] array2 = global::c.l.x;
		int num5 = default(int);
		_MethodInfo val = default(_MethodInfo);
		int num4 = default(int);
		while (true)
		{
			int num = -920749923;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x95B10DEAu) % 11u)
				{
				case 10u:
					num5 = 0;
					num = -1160817571;
					continue;
				case 8u:
					num = (int)((num2 * 75358664) ^ 0x5F62B107);
					continue;
				default:
					num3 = array[12] - 15438;
					goto IL_003a;
				case 6u:
					num4 = array[285] - 65140;
					num = ((int)num2 * -1101796026) ^ -716661967;
					continue;
				case 5u:
					while (true)
					{
						switch (num4)
						{
						case 4:
							break;
						case 7:
						case 10:
							num5++;
							num4 = array2[264] - 50005;
							continue;
						case 8:
							val = (_MethodInfo)(object)global::c.e.smethod_13((Assembly)gparam_0);
							num4 = 10;
							goto case 7;
						case 5:
							num4 = array2[116] - 54355;
							continue;
						case 0:
							val = null;
							num4 = array[362] - 63207;
							continue;
						default:
							goto IL_00e1;
						case 1:
						case 3:
							goto IL_00e8;
						case 6:
						case 9:
							num4 = 2;
							goto IL_00f1;
						case 2:
							goto IL_00f1;
						case 11:
							return (MethodInfo)(object)val;
						}
						break;
					}
					goto case 10u;
				case 0u:
					goto IL_00e8;
				case 1u:
					goto IL_00f1;
				case 4u:
					num4 = 2;
					num = (int)((num2 * 1225509722) ^ 0x7A6E4D27);
					continue;
				case 3u:
					num = ((int)num2 * -411215772) ^ -1619352995;
					continue;
				case 2u:
					num3 = 0;
					goto IL_003a;
				case 9u:
					break;
					IL_00f1:
					switch (((char_0 ^ int_0) - 28) ^ num5)
					{
					case 0:
						break;
					default:
						num = -1982346406;
						continue;
					}
					goto default;
					IL_00e8:
					num = -2017539858;
					continue;
					IL_00e1:
					num = -1035726931;
					continue;
					IL_003a:
					num4 = num3;
					num = -1761416591;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void x<T>(T gparam_0, byte[] byte_0, int int_0, int int_1, char char_0, short short_0) where T : Stream
	{
		int[] array = global::c.l.x;
		int num4 = default(int);
		int num3 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		while (true)
		{
			int num = -1820449783;
			while (true)
			{
				uint num2;
				int num7;
				switch ((num2 = (uint)num ^ 0xC594C0CBu) % 7u)
				{
				default:
					num7 = array[343] - 45794;
					goto IL_0018;
				case 5u:
				{
					int num8 = short_0 ^ char_0;
					global::c.e.e.k[44] = (char)((global::c.e.e.k[44] * int_1) & '\u009b');
					switch ((num8 - 56) ^ num4)
					{
					case 0:
						break;
					default:
						num = -1011946903;
						continue;
					}
					goto default;
				}
				case 4u:
					num7 = 2;
					goto IL_0018;
				case 3u:
					while (true)
					{
						switch (num3)
						{
						case 6:
							break;
						case 0:
						case 8:
							num4++;
							goto case 1;
						case 1:
							num5 = 394;
							num6 = 120;
							goto case 5;
						case 5:
							if (197 >= num5 / 2 - num6)
							{
								num3 = array[310] - 18333;
								continue;
							}
							num3 = 6;
							break;
						case 3:
							global::c.e.smethod_8((Stream)gparam_0, byte_0, int_0, int_1);
							goto case 0;
						case 2:
							num3 = array[204] - 44019;
							continue;
						default:
							goto IL_00d0;
						case 4:
							goto IL_00d7;
						case 7:
							return;
						}
						break;
					}
					goto case 5u;
				case 0u:
					goto IL_00d7;
				case 1u:
					num3 = 4;
					num = ((int)num2 * -275672760) ^ -756093362;
					continue;
				case 2u:
					break;
					IL_00d7:
					num4 = 0;
					num3 = 6;
					num = -9775394;
					continue;
					IL_00d0:
					num = -457401760;
					continue;
					IL_0018:
					num3 = num7;
					num = -9775394;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static byte[] d<T>(T gparam_0, short short_0, int int_0) where T : MemoryStream
	{
		char[] array = global::c.e.e.k;
		int[] array2 = global::c.l.x;
		object obj = default(object);
		int num4 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = -854353733;
			while (true)
			{
				uint num2;
				int num5;
				switch ((num2 = (uint)num ^ 0x990B51C3u) % 10u)
				{
				case 9u:
					num5 = array[250] - 17123;
					goto IL_001e;
				case 8u:
					switch (((short_0 ^ int_0) - 62) ^ num4)
					{
					default:
						num = -617812700;
						continue;
					case 0:
						break;
					}
					goto default;
				default:
					num5 = array[450] - 59960;
					goto IL_001e;
				case 7u:
					while (true)
					{
						switch (num3)
						{
						case 5:
						case 8:
							break;
						case 11:
							obj = global::c.e.smethod_10((MemoryStream)gparam_0);
							num3 = array2[131] - 241;
							continue;
						default:
							goto IL_00a5;
						case 1:
							goto IL_00ac;
						case 2:
						case 3:
							num3 = 8;
							break;
						case 4:
							goto IL_00bd;
						case 7:
						case 9:
							num3 = 8;
							break;
						case 10:
							obj = null;
							num3 = 6;
							goto case 6;
						case 6:
							num4++;
							num3 = 0;
							goto case 0;
						case 0:
							return (byte[])obj;
						}
						break;
					}
					goto case 8u;
				case 6u:
					goto IL_00ac;
				case 5u:
					goto IL_00bd;
				case 4u:
					num = ((int)num2 * -226008069) ^ 0x14FB303D;
					continue;
				case 3u:
					num3 = 1;
					num = ((int)num2 * -744767072) ^ -64006312;
					continue;
				case 1u:
					num3 = 8;
					num = (int)(num2 * 637343131) ^ -12744743;
					continue;
				case 2u:
					break;
					IL_00bd:
					num = -327269116;
					continue;
					IL_00ac:
					num4 = 0;
					num = -1967741968;
					continue;
					IL_00a5:
					num = -875998890;
					continue;
					IL_001e:
					num3 = num5;
					num = -1149545416;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static StringBuilder h<T, U>(U gparam_0, T gparam_1, short short_0, int int_0) where U : StringBuilder
	{
		int[] array = global::c.l.x;
		char[] array2 = default(char[]);
		object obj = default(object);
		int num4 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = 1588177318;
			while (true)
			{
				uint num2;
				int num5;
				switch ((num2 = (uint)num ^ 0x17FD589Au) % 12u)
				{
				case 11u:
					num4 = 0;
					num3 = array2[159] - 27407;
					num = 1319816551;
					continue;
				case 10u:
					goto IL_0026;
				default:
					num5 = array[166] - 64733;
					goto IL_004e;
				case 8u:
					array2 = global::c.e.e.k;
					num = ((int)num2 * -494818958) ^ 0xA45E7BE;
					continue;
				case 7u:
					num5 = array[95] - 48771;
					goto IL_004e;
				case 6u:
					switch (num3)
					{
					case 0:
						break;
					case 5:
					case 9:
						goto IL_0026;
					default:
						goto IL_00b4;
					case 2:
						goto IL_00bb;
					case 3:
						num3 = 9;
						goto IL_0026;
					case 11:
						num3 = 9;
						goto IL_0026;
					case 1:
						obj = null;
						num3 = 7;
						goto case 7;
					case 6:
						obj = global::c.e.smethod_14((StringBuilder)gparam_0, (object)gparam_1);
						num3 = 7;
						goto case 7;
					case 7:
					case 8:
						num4++;
						num3 = 4;
						goto case 4;
					case 4:
					case 10:
						return (StringBuilder)obj;
					}
					goto case 11u;
				case 2u:
					goto IL_00bb;
				case 5u:
					num = (int)((num2 * 1303284676) ^ 0x38F0BC30);
					continue;
				case 3u:
					num3 = array[67] - 55334;
					num = (int)((num2 * 1897443943) ^ 0x7E7E23DA);
					continue;
				case 1u:
					num = ((int)num2 * -1564756723) ^ 0x7AC9836D;
					continue;
				case 0u:
					num = (int)(num2 * 1102003884) ^ -2080701083;
					continue;
				case 9u:
					break;
					IL_00bb:
					num = 2113104369;
					continue;
					IL_00b4:
					num = 1380827812;
					continue;
					IL_0026:
					switch (((short_0 ^ int_0) - 62) ^ num4)
					{
					default:
						num = 741553797;
						continue;
					case 0:
						break;
					}
					goto default;
					IL_004e:
					num3 = num5;
					num = 948275332;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void o<T>(T gparam_0, short short_0, int int_0) where T : Control
	{
		char[] array = global::c.e.e.k;
		int[] array2 = global::c.l.x;
		int num5 = default(int);
		int num6 = default(int);
		int num7 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 1974947899;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x7D8EFAC0u) % 10u)
				{
				case 9u:
					switch (((short_0 ^ int_0) - 120) ^ num5)
					{
					default:
						num = 492055452;
						continue;
					case 0:
						break;
					}
					goto default;
				default:
					num3 = array[196] - 39769;
					goto IL_003a;
				case 8u:
					goto IL_0045;
				case 7u:
					num = (int)((num2 * 507876318) ^ 0x54D5B32D);
					continue;
				case 6u:
					num = ((int)num2 * -582191710) ^ -308298001;
					continue;
				case 5u:
					num4 = 4;
					num = ((int)num2 * -2121410536) ^ 0x5A40E339;
					continue;
				case 3u:
					while (true)
					{
						switch (num4)
						{
						case 4:
							break;
						case 3:
							goto IL_0045;
						case 7:
							num4 = array2[56] - 56536;
							continue;
						default:
							goto IL_00c3;
						case 5:
						case 9:
							global::c.e.smethod_15((Control)(object)gparam_0);
							goto case 2;
						case 2:
							num5++;
							num6 = 345;
							num7 = 525;
							goto case 1;
						case 1:
						case 6:
							if (5250 <= num7 - num6 * 10)
							{
								num4 = 8;
								goto case 8;
							}
							num4 = 0;
							return;
						case 8:
							num4 = 4;
							break;
						case 0:
							return;
						}
						break;
					}
					goto case 9u;
				case 1u:
					num4 = 3;
					num = (int)(num2 * 485982156) ^ -1381142761;
					continue;
				case 0u:
					num3 = 7;
					goto IL_003a;
				case 4u:
					break;
					IL_00c3:
					num = 620731684;
					continue;
					IL_0045:
					num5 = 0;
					num = 1266574503;
					continue;
					IL_003a:
					num4 = num3;
					num = 283524318;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Process c(short short_0, int int_0)
	{
		int[] array = global::c.l.x;
		int num5 = default(int);
		int num4 = default(int);
		char[] array2 = default(char[]);
		Component component = default(Component);
		while (true)
		{
			int num = 221584968;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xC3C1AFBu) % 10u)
				{
				default:
					num3 = array[175] - 56863;
					goto IL_0018;
				case 7u:
					num = (int)(num2 * 1879046163) ^ -2129733979;
					continue;
				case 6u:
					num5 = 0;
					num4 = array[288] - 25780;
					num = 1040284046;
					continue;
				case 5u:
					goto IL_0050;
				case 4u:
					num4 = 7;
					num = ((int)num2 * -1682559594) ^ 0xF483D06;
					continue;
				case 3u:
					array2 = global::c.e.e.k;
					num = (int)((num2 * 370443679) ^ 0x5E531814);
					continue;
				case 2u:
					goto IL_0098;
				case 1u:
					while (true)
					{
						switch (num4)
						{
						case 7:
							break;
						case 5:
							goto IL_0050;
						case 9:
							goto IL_0098;
						case 3:
						case 6:
							component = null;
							num4 = array[297] - 25325;
							continue;
						case 1:
						case 4:
							num4 = array[313] - 20793;
							continue;
						case 2:
							num5++;
							num4 = array2[461] - 14814;
							continue;
						case 0:
							component = global::c.e.smethod_16();
							num4 = array[137] - 55307;
							continue;
						default:
							goto IL_0122;
						case 8:
						case 10:
							return component as Process;
						}
						break;
					}
					goto case 6u;
				case 0u:
					num3 = 6;
					goto IL_0018;
				case 9u:
					break;
					IL_0122:
					num = 1942852827;
					continue;
					IL_0098:
					num = 712183465;
					continue;
					IL_0050:
					switch (((int_0 ^ short_0) - 108) ^ num5)
					{
					case 0:
						break;
					default:
						num = 805689389;
						continue;
					}
					goto default;
					IL_0018:
					num4 = num3;
					num = 2122084106;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Encoding w(short short_0, char char_0)
	{
		char[] array = global::c.e.e.k;
		int num5 = default(int);
		int[] array2 = default(int[]);
		object obj = default(object);
		int num3 = default(int);
		while (true)
		{
			int num = 2050205623;
			while (true)
			{
				uint num2;
				int num4;
				switch ((num2 = (uint)num ^ 0x46623CCDu) % 12u)
				{
				case 11u:
					num5 = 0;
					num = 1845392737;
					continue;
				case 10u:
					array2 = global::c.l.x;
					num = ((int)num2 * -576957098) ^ 0x146C4F94;
					continue;
				case 9u:
					num = ((int)num2 * -1670341024) ^ -1630966635;
					continue;
				case 8u:
					num = ((int)num2 * -1464944400) ^ 0x3ADD97F5;
					continue;
				case 6u:
					goto IL_0054;
				case 5u:
					num = ((int)num2 * -1388217628) ^ 0x48F187B6;
					continue;
				case 4u:
					while (true)
					{
						switch (num3)
						{
						case 2:
						case 6:
						case 7:
							break;
						case 11:
							goto IL_0054;
						case 10:
							num5++;
							if ((short_0 * short_0 + short_0) % 2 != 0)
							{
								num3 = 4;
								goto case 4;
							}
							num3 = array2[282] - 29665;
							continue;
						case 4:
							num3 = array2[104] - 24107;
							continue;
						case 5:
							obj = null;
							num3 = 10;
							goto case 10;
						case 1:
							obj = global::c.e.smethod_17();
							num3 = 10;
							goto case 10;
						default:
							goto IL_00ea;
						case 3:
							num3 = 8;
							goto IL_00f3;
						case 8:
							goto IL_00f3;
						case 0:
						case 9:
							return obj as Encoding;
						}
						break;
					}
					goto case 11u;
				case 3u:
					goto IL_00f3;
				default:
					num4 = 1;
					goto IL_010c;
				case 1u:
					num4 = array[396] - 40969;
					goto IL_010c;
				case 0u:
					num3 = 8;
					num = (int)(num2 * 1742819006) ^ -366587707;
					continue;
				case 7u:
					break;
					IL_00f3:
					switch (((short_0 ^ char_0) - 23) ^ num5)
					{
					default:
						num = 1572960516;
						continue;
					case 0:
						break;
					}
					goto default;
					IL_010c:
					num3 = num4;
					num = 56663012;
					continue;
					IL_00ea:
					num = 96149975;
					continue;
					IL_0054:
					num3 = 2;
					num = 1020301813;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static long n<T>(T gparam_0, short short_0, int int_0) where T : Stream
	{
		int[] array = global::c.l.x;
		char[] array2 = default(char[]);
		long result = default(long);
		int num5 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = 1167643808;
			while (true)
			{
				uint num2;
				int num4;
				switch ((num2 = (uint)num ^ 0x11301FE1u) % 11u)
				{
				case 10u:
					array2 = global::c.e.e.k;
					num = (int)((num2 * 72004729) ^ 0x117130A2);
					continue;
				case 9u:
					num = 630326217;
					continue;
				case 8u:
					while (true)
					{
						switch (num3)
						{
						case 6:
						case 9:
							break;
						case 4:
							result = 11L;
							num3 = array[222] - 29364;
							continue;
						case 0:
							num3 = array2[533] - 3302;
							continue;
						default:
							goto IL_0090;
						case 2:
						case 8:
							num3 = 11;
							goto IL_009a;
						case 11:
							goto IL_009a;
						case 7:
						case 12:
							goto IL_00cc;
						case 3:
							result = global::c.e.smethod_19((Stream)gparam_0);
							num3 = 10;
							goto case 10;
						case 5:
							result = global::c.e.smethod_18((Stream)gparam_0);
							num3 = 10;
							goto case 10;
						case 10:
							num5++;
							num3 = 1;
							goto case 1;
						case 1:
							return result;
						}
						break;
					}
					goto case 9u;
				case 2u:
					goto IL_009a;
				default:
					goto IL_00b7;
				case 1u:
					goto IL_00cc;
				case 7u:
					num = ((int)num2 * -986375497) ^ 0x3645150F;
					continue;
				case 6u:
					num4 = 4;
					goto IL_00c4;
				case 5u:
					num3 = array[185] - 13013;
					num = ((int)num2 * -1488354341) ^ 0x18A0688B;
					continue;
				case 3u:
					num = ((int)num2 * -1492484125) ^ 0x4845F235;
					continue;
				case 0u:
					break;
					IL_00cc:
					num5 = 0;
					num3 = 11;
					num = 622078883;
					continue;
					IL_009a:
					switch (((int_0 ^ short_0) - 19) ^ num5)
					{
					case 0:
						goto IL_00b7;
					case 1:
						goto IL_00ba;
					}
					num = 1162845417;
					continue;
					IL_00ba:
					num4 = array[79] - 51187;
					goto IL_00c4;
					IL_00b7:
					num4 = 5;
					goto IL_00c4;
					IL_00c4:
					num3 = num4;
					num = 560153029;
					continue;
					IL_0090:
					num = 1997278105;
					continue;
				}
				break;
			}
		}
	}

	static RijndaelManaged smethod_0()
	{
		return new RijndaelManaged();
	}

	static void smethod_1(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static DESCryptoServiceProvider smethod_2()
	{
		return new DESCryptoServiceProvider();
	}

	static Assembly smethod_3()
	{
		return Assembly.GetCallingAssembly();
	}

	static FormatException smethod_4(string string_0)
	{
		return new FormatException(string_0);
	}

	static void smethod_5(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
	{
		RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
	}

	static byte[] smethod_6(ICryptoTransform icryptoTransform_0, byte[] byte_0, int int_0, int int_1)
	{
		return icryptoTransform_0.TransformFinalBlock(byte_0, int_0, int_1);
	}

	static void smethod_7(Stream stream_0)
	{
		stream_0.Close();
	}

	static void smethod_8(Stream stream_0, byte[] byte_0, int int_0, int int_1)
	{
		stream_0.Write(byte_0, int_0, int_1);
	}

	static void smethod_9(Stream stream_0)
	{
		stream_0.Flush();
	}

	static byte[] smethod_10(MemoryStream memoryStream_0)
	{
		return memoryStream_0.ToArray();
	}

	static string smethod_11(Exception exception_0)
	{
		return exception_0.Message;
	}

	static string smethod_12(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static MethodInfo smethod_13(Assembly assembly_0)
	{
		return assembly_0.EntryPoint;
	}

	static StringBuilder smethod_14(StringBuilder stringBuilder_0, object object_0)
	{
		return stringBuilder_0.Append(object_0);
	}

	static void smethod_15(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static Process smethod_16()
	{
		return Process.GetCurrentProcess();
	}

	static Encoding smethod_17()
	{
		return Encoding.UTF8;
	}

	static long smethod_18(Stream stream_0)
	{
		return stream_0.Length;
	}

	static long smethod_19(Stream stream_0)
	{
		return stream_0.Position;
	}
}
