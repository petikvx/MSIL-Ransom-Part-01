using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace c;

internal static class v
{
	internal sealed class h
	{
		private const int t = 0;

		private const int v = 1;

		private const int p = 2;

		private const int w = 3;

		private const int k = 4;

		private const int j = 5;

		private const int e = 6;

		private const int i = 7;

		private const int m = 8;

		private const int y = 9;

		private const int u = 10;

		private const int d = 11;

		private const int x = 12;

		internal static readonly int[] a;

		internal static readonly int[] r;

		internal static readonly int[] d;

		internal static readonly int[] c;

		internal int n;

		internal int g;

		internal int o;

		internal int l;

		internal int b;

		internal bool m;

		internal e x;

		internal x k;

		internal b g;

		internal t g;

		internal t p;

		public h(byte[] byte_0)
		{
			x = new e();
			k = new x();
			n = 2;
			global::c.j.s(byte_0.Length, x, 0, byte_0);
		}

		static h()
		{
			int num = 3;
			while (true)
			{
				int num2 = -1449593272;
				while (true)
				{
					uint num3;
					int[] array_;
					int[] array_2;
					int[] array_3;
					switch ((num3 = (uint)num2 ^ 0xD7C831FAu) % 8u)
					{
					case 7u:
						num = 1;
						num2 = -1944244021;
						continue;
					case 5u:
					{
						int[] array_4 = new int[29];
						h.smethod_0((Array)array_4, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
						r = array_4;
						num2 = ((int)num3 * -703341878) ^ -1436179513;
						continue;
					}
					case 3u:
						goto IL_003c;
					case 2u:
						switch (num)
						{
						case 0:
							break;
						case 3:
							goto IL_003c;
						default:
							goto IL_0074;
						case 1:
						case 2:
							goto IL_007b;
						case 4:
							return;
						}
						goto case 7u;
					case 0u:
						goto IL_007b;
					case 1u:
						num2 = ((int)num3 * -1513513361) ^ 0x65083477;
						continue;
					default:
						return;
					case 6u:
						break;
					case 4u:
						return;
						IL_007b:
						array_ = new int[30];
						h.smethod_0((Array)array_, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
						d = array_;
						array_2 = new int[30];
						h.smethod_0((Array)array_2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
						c = array_2;
						num2 = -41282834;
						continue;
						IL_0074:
						num2 = -897225855;
						continue;
						IL_003c:
						array_3 = new int[29];
						h.smethod_0((Array)array_3, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
						a = array_3;
						num2 = -180563497;
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

	internal sealed class e
	{
		internal byte[] m;

		internal int x;

		internal int a;

		internal uint k;

		internal int g;

		public int f => g;

		public int e
		{
			get
			{
				int num = a;
				int num2 = x;
				global::c.h.d[266] = (byte)((global::c.h.d[266] ^ global::c.h.d[118]) & 0xD4);
				return num - num2 + (g >> 3);
			}
		}

		public bool i => x == a;
	}

	internal sealed class x
	{
		private const int a = 32768;

		private const int r = 32767;

		internal byte[] m = new byte[32768];

		internal int d;

		internal int c;
	}

	internal sealed class t
	{
		private const int x = 15;

		internal short[] k;

		public static readonly t g;

		public static readonly t s;

		static t()
		{
			char[] array = global::c.x.s;
			object obj = default(object);
			int num5 = default(int);
			byte[] d = default(byte[]);
			int num3 = default(int);
			while (true)
			{
				int num = 1460198917;
				while (true)
				{
					uint num2;
					int num4;
					int num6;
					switch ((num2 = (uint)num ^ 0x4E068E1Au) % 12u)
					{
					case 11u:
						obj = new byte[288];
						num5 = 0;
						num = 1593965791;
						continue;
					case 10u:
						while (true)
						{
							switch (num3)
							{
							case 14:
								break;
							case 18:
								(obj as byte[])[num5++] = 9;
								num3 = 15;
								goto case 15;
							case 15:
								if (num5 < 256)
								{
									num3 = 18;
									goto case 18;
								}
								num3 = 2;
								goto case 2;
							case 2:
							case 4:
								num3 = 6;
								goto case 6;
							case 6:
								num3 = ((num5 < 280) ? (d[158] - 23) : (array[419] - 52331));
								continue;
							case 17:
								g = new t(obj as byte[]);
								obj = new byte[32];
								num5 = 0;
								num3 = array[402] - 5973;
								continue;
							case 13:
								if (num5 < 32)
								{
									num3 = d[276];
									continue;
								}
								num3 = 5;
								goto case 5;
							case 12:
								num3 = ((num5 < 288) ? (array[85] - 43804) : d[151]);
								continue;
							case 11:
								((byte[])obj)[num5++] = 8;
								num3 = 12;
								goto case 12;
							case 10:
								num3 = 12;
								goto case 12;
							case 3:
							case 9:
								(obj as byte[])[num5++] = 5;
								num3 = 13;
								goto case 13;
							case 8:
								(obj as byte[])[num5++] = 7;
								num3 = array[454] - 7992;
								continue;
							case 0:
								num3 = 15;
								goto case 15;
							default:
								goto IL_0180;
							case 1:
								goto IL_018a;
							case 7:
								goto IL_01af;
							case 5:
							case 16:
								s = new t(obj as byte[]);
								return;
							}
							break;
						}
						goto case 11u;
					case 4u:
						goto IL_018a;
					case 7u:
						goto IL_01af;
					case 8u:
						num = (int)(num2 * 1396083088) ^ -1464727836;
						continue;
					case 6u:
						num3 = 14;
						num = ((int)num2 * -1666405959) ^ 0x38322EE2;
						continue;
					case 5u:
						num3 = 1;
						num = ((int)num2 * -972320148) ^ -410034440;
						continue;
					case 3u:
						d = global::c.h.d;
						num = (int)((num2 * 1834388113) ^ 0xF62B1A3);
						continue;
					case 2u:
						num4 = array[279] - 50457;
						goto IL_021d;
					default:
						num4 = array[238] - 41663;
						goto IL_021d;
					case 0u:
						num3 = array[128] - 25891;
						num = (int)(num2 * 609630691) ^ -338377420;
						continue;
					case 9u:
						break;
						IL_021d:
						num3 = num4;
						num = 2136343626;
						continue;
						IL_01af:
						(obj as byte[])[num5++] = 8;
						num = 795480298;
						continue;
						IL_018a:
						if (num5 >= 144)
						{
							num = 456812776;
							num6 = 456812776;
						}
						else
						{
							num = 348881483;
							num6 = 348881483;
						}
						continue;
						IL_0180:
						num = 1671798733;
						continue;
					}
					break;
				}
			}
		}

		public t(byte[] byte_0)
		{
			global::c.j.n(byte_0, this);
		}
	}

	internal sealed class b
	{
		private const int g = 0;

		private const int s = 1;

		private const int j = 2;

		private const int u = 3;

		private const int v = 4;

		private const int q = 5;

		internal static readonly int[] g;

		internal static readonly int[] p;

		internal byte[] x;

		internal byte[] w;

		internal t w;

		internal int e;

		internal int t;

		internal int o;

		internal int f;

		internal int l;

		internal int n;

		internal byte a;

		internal int i;

		internal static readonly int[] l;

		static b()
		{
			char[] array = global::c.x.s;
			int num = 1;
			while (true)
			{
				int num2 = 720742470;
				while (true)
				{
					uint num3;
					int[] array_;
					int[] array_2;
					switch ((num3 = (uint)num2 ^ 0x3F949888u) % 8u)
					{
					case 7u:
					{
						int[] array_3 = new int[3];
						b.smethod_0((Array)array_3, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
						p = array_3;
						num2 = 1099394656;
						continue;
					}
					case 6u:
						switch (num)
						{
						case 3:
							break;
						default:
							goto IL_0047;
						case 0:
						case 2:
							goto IL_004e;
						case 1:
						case 4:
							goto IL_006c;
						}
						goto case 7u;
					case 1u:
						goto IL_004e;
					case 3u:
						goto IL_006c;
					case 4u:
						num2 = ((int)num3 * -529351639) ^ -623774358;
						continue;
					case 0u:
						num = array[215] - 16374;
						num2 = ((int)num3 * -668393851) ^ 0x4F42774C;
						continue;
					default:
						return;
					case 5u:
						break;
					case 2u:
						return;
						IL_006c:
						array_ = new int[3];
						b.smethod_0((Array)array_, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
						g = array_;
						num2 = 1487982655;
						continue;
						IL_004e:
						array_2 = new int[19];
						b.smethod_0((Array)array_2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
						l = array_2;
						num2 = 104630162;
						continue;
						IL_0047:
						num2 = 8206259;
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

	internal sealed class n
	{
		private const int g = 4;

		private const int p = 8;

		private const int l = 16;

		private const int h = 20;

		private const int m_f = 28;

		private const int y = 30;

		internal int o = 16;

		internal long x;

		internal w w;

		internal u a;

		public long f => this.x;

		public bool i
		{
			get
			{
				char[] s = global::c.x.s;
				int num4 = default(int);
				while (true)
				{
					int num = -1294446665;
					while (true)
					{
						uint num2;
						int num3;
						switch ((num2 = (uint)num ^ 0xF34E1FA9u) % 7u)
						{
						default:
						{
							char num6 = s[589];
							global::c.x.s[619] = (char)((global::c.x.s[619] + global::c.h.d[253]) & '\u008e');
							num3 = num6 - 60484;
							goto IL_0040;
						}
						case 5u:
						{
							int num5;
							if (o != 30)
							{
								num = -1141619494;
								num5 = -1141619494;
							}
							else
							{
								num = -665897624;
								num5 = -665897624;
							}
							continue;
						}
						case 4u:
							num = ((int)num2 * -2040511813) ^ 0x3B029137;
							continue;
						case 3u:
							switch (num4)
							{
							case 2:
							case 3:
								break;
							default:
								num = -1371836314;
								continue;
							case 4:
								return w.v == 0;
							case 0:
							case 1:
							case 5:
								return false;
							}
							goto case 5u;
						case 1u:
							num4 = 2;
							num = (int)((num2 * 1331497431) ^ 0x3A148FD1);
							continue;
						case 0u:
							num3 = 4;
							goto IL_0040;
						case 2u:
							break;
							IL_0040:
							num4 = num3;
							num = -2000515691;
							continue;
						}
						break;
					}
				}
			}
		}

		public bool x => global::c.j.te(a);

		public n()
		{
			while (true)
			{
				int num = -1523074456;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC6E97AFCu) % 3u)
					{
					case 1u:
						goto IL_0010;
					default:
						return;
					case 2u:
						break;
					case 0u:
						return;
					}
					break;
					IL_0010:
					w = new w();
					a = new u(w);
					num = ((int)num2 * -231540395) ^ -1812099256;
				}
			}
		}
	}

	internal sealed class j
	{
		public sealed class m
		{
			public short[] a;

			public byte[] y;

			public int u;

			public int j;

			internal short[] w;

			internal int[] y;

			internal int q;

			internal j v;

			public m(j j_0, int int_0, int int_1, int int_2)
			{
				while (true)
				{
					int num = 733777750;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x44F09AC4u) % 7u)
						{
						case 6u:
							a = new short[int_0];
							num = 1823954138;
							continue;
						case 4u:
							q = int_2;
							num = ((int)num2 * -1623711488) ^ 0x71BA79AA;
							continue;
						case 3u:
							v = j_0;
							num = (int)((num2 * 971521772) ^ 0x5AFA9372);
							continue;
						case 2u:
							u = int_1;
							num = ((int)num2 * -223411891) ^ 0x13612C71;
							continue;
						case 1u:
							num = ((int)num2 * -301422152) ^ -160677232;
							continue;
						case 5u:
							break;
						default:
							y = new int[int_2];
							return;
						}
						break;
					}
				}
			}
		}

		private const int a = 16384;

		private const int w = 286;

		private const int s = 30;

		private const int n = 19;

		private const int h = 16;

		private const int f = 17;

		private const int y = 18;

		private const int c = 256;

		internal static readonly int[] y;

		internal static readonly byte[] u;

		internal w y;

		internal m v;

		internal m w;

		internal m j;

		internal short[] g;

		internal byte[] j;

		internal int l;

		internal int b;

		internal static readonly short[] j;

		internal static readonly byte[] q;

		internal static readonly short[] c;

		internal static readonly byte[] p;

		static j()
		{
			byte[] d = global::c.h.d;
			int num4 = default(int);
			char[] array = default(char[]);
			int num3 = default(int);
			while (true)
			{
				int num = -648565325;
				while (true)
				{
					uint num2;
					int num5;
					int num6;
					int[] array_2;
					switch ((num2 = (uint)num ^ 0x9292B4D9u) % 18u)
					{
					case 17u:
						num = ((int)num2 * -124197134) ^ 0x28600967;
						continue;
					case 16u:
						while (true)
						{
							switch (num3)
							{
							case 20:
								c[num4] = global::c.j.r(num4 << 11);
								goto case 14;
							case 14:
								p[num4] = 5;
								num3 = 4;
								goto case 4;
							case 4:
								num4++;
								num3 = array[10] - 58915;
								continue;
							case 18:
								num3 = 0;
								goto case 0;
							case 10:
								j[num4] = global::c.j.r(-256 + num4 << 9);
								q[num4++] = 7;
								num3 = 0;
								goto case 0;
							case 0:
								if (num4 < 280)
								{
									num3 = 10;
									goto case 10;
								}
								num3 = d[233] + d[94];
								continue;
							case 15:
							case 17:
								num3 = ((num4 < 286) ? d[94] : (array[532] - 65303));
								continue;
							case 16:
								j[num4] = global::c.j.r(256 + num4 << 7);
								q[num4++] = 9;
								num3 = 13;
								goto case 13;
							case 13:
								if (num4 < 256)
								{
									num3 = 16;
									goto case 16;
								}
								num3 = 18;
								goto case 18;
							case 9:
								num3 = 15;
								goto case 15;
							case 7:
								if (num4 < 30)
								{
									num3 = array[355] - 24063;
									continue;
								}
								num3 = 3;
								return;
							case 6:
								c = new short[30];
								p = new byte[30];
								num4 = 0;
								num3 = 7;
								goto case 7;
							case 5:
								j[num4] = global::c.j.r(-88 + num4 << 8);
								q[num4++] = 8;
								num3 = array[503] - 16339;
								continue;
							case 1:
								num3 = 13;
								goto case 13;
							case 8:
								goto IL_01c7;
							case 11:
								goto IL_01e3;
							case 12:
								goto IL_01fc;
							case 19:
								goto IL_021d;
							case 2:
							case 3:
								return;
							}
							break;
						}
						num = -1057958761;
						continue;
					case 8u:
						goto IL_01c7;
					case 9u:
						goto IL_01e3;
					case 6u:
						goto IL_01fc;
					case 12u:
						goto IL_021d;
					case 15u:
						num = (int)(num2 * 378235393) ^ -1193079004;
						continue;
					case 14u:
					{
						byte[] array_ = new byte[16];
						global::c.v.j.smethod_0((Array)array_, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
						u = array_;
						num = ((int)num2 * -1529524830) ^ -1713060854;
						continue;
					}
					case 11u:
						q = new byte[286];
						num = ((int)num2 * -333109990) ^ 0x395EF4AD;
						continue;
					case 10u:
						q[num4++] = 8;
						num3 = d[171] - 1;
						num = ((int)num2 * -691579676) ^ -681480699;
						continue;
					case 7u:
						num5 = 1;
						goto IL_02c3;
					default:
						num5 = d[39] - 208;
						goto IL_02c3;
					case 4u:
						array = global::c.x.s;
						num = ((int)num2 * -918734008) ^ -1668189084;
						continue;
					case 3u:
						num3 = 12;
						num = ((int)num2 * -1078270745) ^ -2128413290;
						continue;
					case 2u:
						num4 = 0;
						num3 = d[111] - d[14];
						num = (int)((num2 * 1259509572) ^ 0x2FFA6B28);
						continue;
					case 1u:
						num3 = d[13] - d[31];
						num = ((int)num2 * -619158336) ^ 0x8E0B6A4;
						continue;
					case 0u:
						num = (int)(num2 * 1815616968) ^ -1751424659;
						continue;
					case 13u:
						break;
						IL_02c3:
						num3 = num5;
						num = -1661884723;
						continue;
						IL_021d:
						if (num4 < 144)
						{
							num = -2077139166;
							num6 = -2077139166;
						}
						else
						{
							num = -1500272260;
							num6 = -1500272260;
						}
						continue;
						IL_01c7:
						j[num4] = global::c.j.r(48 + num4 << 8);
						num = -1951929221;
						continue;
						IL_01fc:
						array_2 = new int[19];
						global::c.v.j.smethod_0((Array)array_2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
						global::c.v.j.y = array_2;
						num = -1371373567;
						continue;
						IL_01e3:
						j = new short[286];
						num = -1115065260;
						continue;
					}
					break;
				}
			}
		}

		public j(w w_0)
		{
			while (true)
			{
				int num = 1451995200;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x587AC9B1u) % 9u)
					{
					case 8u:
						this.j = new byte[16384];
						num = ((int)num2 * -113694823) ^ 0x51CCBB92;
						continue;
					case 7u:
						v = new m(this, 286, 257, 15);
						num = (int)(num2 * 1799007064) ^ -1341780693;
						continue;
					case 6u:
						num = (int)((num2 * 1411252844) ^ 0x5111D7EC);
						continue;
					case 5u:
						y = w_0;
						num = ((int)num2 * -1369877292) ^ -1463511247;
						continue;
					case 3u:
						g = new short[16384];
						num = 846295003;
						continue;
					case 2u:
						this.j = new m(this, 19, 4, 7);
						num = ((int)num2 * -1621654696) ^ -2015661240;
						continue;
					case 1u:
						w = new m(this, 30, 1, 15);
						num = 369822234;
						continue;
					default:
						return;
					case 0u:
						break;
					case 4u:
						return;
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

	internal sealed class u
	{
		private const int x = 258;

		private const int b = 3;

		private const int w = 32768;

		private const int p = 32767;

		private const int c = 32768;

		private const int m_u = 32767;

		private const int i = 5;

		private const int t = 262;

		private const int r = 32506;

		private const int d = 4096;

		internal int v;

		internal short[] p;

		internal short[] x;

		internal int h;

		internal int s;

		internal bool a;

		internal int y;

		internal int f;

		internal int o;

		internal byte[] h;

		internal byte[] x;

		internal int a;

		internal int n;

		internal int e;

		internal w g;

		internal j r;

		public u(w w_0)
		{
			g = w_0;
			r = new j(w_0);
			h = new byte[65536];
			p = new short[32768];
			this.x = new short[32768];
			f = 1;
			y = 1;
		}
	}

	internal sealed class w
	{
		protected internal byte[] h = new byte[65536];

		internal int q;

		internal int v;

		internal uint y;

		internal int h;

		public int g => h;

		public bool p => v == 0;
	}

	internal sealed class a : MemoryStream
	{
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 526)]
		private struct y
		{
		}

		private static readonly object j;

		private static readonly Array q;

		private static readonly object p;

		internal static y w/* Not supported: data(08 00 02 00 08 00 30 12 05 05 24 32 06 25 BE 03 EA 12 CA 19 A6 12 2D 12 47 05 B8 64 BF 64 B9 64 73 7D 21 76 CF 76 AF 61 8E 56 BA 41 13 67 57 F2 46 F2 55 F2 29 C0 5E D7 F7 F1 AC E0 9F EB FB E0 2B E0 51 F7 5F C0 53 D7 FB F1 AB E0 92 EB DA E0 02 E0 14 F7 38 C0 E3 A4 EB A4 E0 A4 26 B6 83 B6 F2 A1 D5 96 F0 81 4A A7 06 B6 07 BD 2C B5 21 B5 28 B5 B1 A7 51 A7 2A B0 41 87 3B 90 9E B6 E3 A7 FF AC B1 A7 47 A7 3F B0 1C 87 2A 90 D4 92 D5 92 D1 92 CA B7 08 8D 18 8D 0E 8D 4C 9F 44 88 01 BF 1C A8 E8 8E AE 9F EF 94 CB 9F 4E 9F 3E 88 33 BF 18 A8 A5 8E C2 9F 94 94 C6 9F BB 63 B1 63 BC 63 FC 46 44 60 18 71 2C 7A 73 71 8C 71 F8 66 AA 51 8E 46 3B 60 97 5D 81 5D 9F 5D B1 6F 82 78 27 5E 73 4F 51 44 01 4F F5 4F 9D 58 87 6F D0 78 20 5E 62 4F 54 44 0E 4F F7 4F BC 58 F4 6F 97 78 3C 5E 68 4F 42 44 38 4F EA BF E4 BF E3 BF FB BA CC 8D E9 9A 4E BC 1F AD 05 A6 32 AD 81 AD FE BA C6 8D E3 9A 44 BC 14 AD 18 A6 A8 4B 36 4B A2 4B D0 59 F8 4E 89 79 FD 6E 5C 48 00 59 3E 52 63 59 98 59 A8 4E DE 79 AE 6E 5C 48 15 59 38 52 32 59 CC 59 A9 4E C6 79 AA 6E 55 48 5A 59 3B 52 7D 59 95 59 F3 4E 8E 79 F9 6E 40 48 0A 59 6B 52 36 59 9E 59 A9 4E 8D 79 AB 6E 08 48 43 59 52 52 2A 59 F6 59 E7 4E 98 79 B7 6E 3A 48 5C 59 7A 52 61 59 C7 59 A9 4E 87 79 BB 6E 5F 48 5A 59 5A 52 3C 59 F5 59 91 4E A7 79 81 6E 3A 48 59 59 7C 52 1A 59 FA 59 AF 4E BA 79 8D 6E 2E 48 74 59 7C 52 16 59 C0 59 A8 4E DB 79 99 6E 35 48 62 59 7A 52 61 59 F9 59 91 4E 92 79 99 6E 25 48 5C 59 7C 52 06 59 9E 59 9A 4E 8C 79 B8 6E 14 48 60 59 85 BF 86 BF 8E BF F2 8D D0 9A 72 BC 85 0B 86 0B 89 0B 72 08 21 19 10 12 09 B9 0A B9 04 B9 9E A0 C1 AB 3E AB) */;

		public a()
		{
		}

		public a(byte[] byte_0)
			: base(byte_0, writable: false)
		{
		}

		static a()
		{
			char[] s = global::c.x.s;
			char[] array = default(char[]);
			int num3 = default(int);
			byte[] d = default(byte[]);
			while (true)
			{
				int num = -1132238271;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC250A59Cu) % 21u)
					{
					case 20u:
						array[0] = 'ᦧ';
						num = (int)(num2 * 287652787) ^ -1945495615;
						continue;
					case 19u:
						num = (int)(num2 * 251940592) ^ -1034734935;
						continue;
					case 18u:
						num3 = d[14] - 164;
						num = (int)(num2 * 1106765779) ^ -374550416;
						continue;
					case 16u:
						p = new string[14];
						j = array;
						num = (int)(num2 * 1854057234) ^ -1409353758;
						continue;
					case 15u:
						d = global::c.h.d;
						num3 = 7;
						num = (int)(num2 * 1833904796) ^ -1281856731;
						continue;
					case 13u:
						num = (int)((num2 * 1202245401) ^ 0x77CD4D52);
						continue;
					case 12u:
					{
						char[] array_ = new char[263];
						v.a.smethod_3((Array)array_, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
						q = array_;
						num = -86105237;
						continue;
					}
					case 11u:
						goto IL_00ca;
					case 10u:
						num3 = 5;
						num = (int)((num2 * 437977155) ^ 0x1D33BC04);
						continue;
					case 9u:
						num3 = 1;
						num = (int)((num2 * 1741724261) ^ 0x57178AE9);
						continue;
					case 8u:
						num = ((int)num2 * -1798786083) ^ -283570807;
						continue;
					case 7u:
						goto IL_0118;
					case 5u:
						goto IL_012a;
					case 4u:
						goto IL_013c;
					case 3u:
						goto IL_014b;
					case 2u:
						switch (num3)
						{
						case 7:
							break;
						case 1:
							goto IL_00ca;
						case 2:
							goto IL_0118;
						case 0:
							goto IL_012a;
						case 5:
							goto IL_013c;
						case 6:
							goto IL_014b;
						default:
							goto IL_0194;
						case 3:
							goto IL_019b;
						case 4:
							return;
						}
						goto case 12u;
					case 0u:
						goto IL_019b;
					case 1u:
						array[3] = '╧';
						num = ((int)num2 * -1748845896) ^ -405069732;
						continue;
					default:
						return;
					case 6u:
						break;
					case 14u:
						return;
					case 17u:
						return;
						IL_019b:
						array[5] = 'գ';
						num = -1114457614;
						continue;
						IL_0194:
						num = -1911212177;
						continue;
						IL_014b:
						array = new char[8] { '\0', '\0', '\0', '\0', '\0', '\0', '\0', 'ዸ' };
						num3 = s[48] - 65318;
						num = -549849006;
						continue;
						IL_013c:
						array[2] = 'υ';
						num = -1107492802;
						continue;
						IL_012a:
						array[6] = 'ህ';
						num = -765567946;
						continue;
						IL_0118:
						array[4] = '㉃';
						num = -228108957;
						continue;
						IL_00ca:
						array[1] = 'ነ';
						num = -113887461;
						continue;
					}
					break;
				}
			}
		}

		internal static string u(int int_0, int int_1, Type type_0, int int_2)
		{
			char[] s = global::c.x.s;
			byte[] d = global::c.h.d;
			char[] array3 = default(char[]);
			int num9 = default(int);
			int num10 = default(int);
			int num8 = default(int);
			int num6 = default(int);
			char[] array2 = default(char[]);
			char[] array = default(char[]);
			StringBuilder stringBuilder = default(StringBuilder);
			char c2 = default(char);
			int num7 = default(int);
			int num11 = default(int);
			string text = default(string);
			int num5 = default(int);
			while (true)
			{
				int num = int_2 ^ 0x578158D5 ^ int_0;
				int num2 = 464262529;
				while (true)
				{
					uint num3;
					int num4;
					int num12;
					switch ((num3 = (uint)num2 ^ 0x10FABCCEu) % 11u)
					{
					case 10u:
						num5 = 1;
						num2 = 1243403698;
						continue;
					case 9u:
						num2 = (int)((num3 * 589073795) ^ 0x514C7E74);
						continue;
					case 8u:
						num2 = 1253851450;
						continue;
					case 7u:
						array3 = (char[])q;
						num2 = (int)((num3 * 594035927) ^ 0x3ABF602B);
						continue;
					case 6u:
					{
						char[] array5 = array3;
						num9 = array5[num];
						num9 = array5[num + 2] ^ num9;
						num5 = 13;
						num2 = (int)((num3 * 1488612752) ^ 0x7ABF1914);
						continue;
					}
					case 5u:
						goto IL_007e;
					case 4u:
						while (true)
						{
							switch (num5)
							{
							case 16:
								break;
							case 13:
								goto IL_007e;
							case 17:
								if (num10 <= num8)
								{
									num5 = d[290] - 211;
									continue;
								}
								num5 = 9;
								goto case 5;
							case 14:
							{
								char[] array4 = array3;
								char[] obj = (char[])j;
								num6 = num;
								array2 = obj;
								array = array4;
								num5 = 3;
								goto case 3;
							}
							case 3:
								stringBuilder = v.a.smethod_0();
								c2 = array[num6];
								num7 = array[num6 + 1] ^ c2;
								num5 = s[244] - 41183;
								continue;
							case 12:
								num11 = array2.Length;
								num10 = 1;
								num5 = s[546] - 45493;
								continue;
							case 11:
								num10++;
								num5 = s[422] - 55653;
								continue;
							case 10:
								v.a.smethod_1(stringBuilder, (char)(c2 ^ array[num6 + num8 - num10] ^ array2[(num10 + num6 + 17) % num11]));
								goto case 2;
							case 2:
								num5 = 11;
								goto case 11;
							case 8:
								num8 = (num8 << 15) | (array[num6++] ^ c2);
								num5 = 12;
								goto case 12;
							case 7:
								num6 += 3;
								num8 = (num7 & 0x1F) | ((num7 & 0xFFC0) >> 1);
								num5 = 4;
								goto case 4;
							case 4:
								if (((uint)num7 & 0x20u) != 0)
								{
									num5 = 8;
									goto case 8;
								}
								num5 = 12;
								goto case 12;
							default:
								goto IL_01fd;
							case 1:
								goto end_IL_022a;
							case 0:
							case 15:
								return text;
							case 5:
							case 9:
								text = v.a.smethod_2((object)stringBuilder);
								((string[])p)[num9] = text;
								num5 = 6;
								goto case 6;
							case 6:
								return text;
							}
							break;
						}
						goto case 10u;
					default:
						num4 = 14;
						goto IL_0206;
					case 2u:
						num4 = 15;
						goto IL_0206;
					case 0u:
						num2 = ((int)num3 * -1495486177) ^ 0x15D9C33E;
						continue;
					case 1u:
						break;
						IL_0206:
						num5 = num4;
						num2 = 1253851450;
						continue;
						IL_01fd:
						num2 = 485011490;
						continue;
						IL_007e:
						if ((text = ((string[])p)[num9]) == null)
						{
							num2 = 1270729896;
							num12 = 1270729896;
						}
						else
						{
							num2 = 1631286837;
							num12 = 1631286837;
						}
						continue;
						end_IL_022a:
						break;
					}
					break;
				}
			}
		}

		static StringBuilder smethod_0()
		{
			return new StringBuilder();
		}

		static StringBuilder smethod_1(StringBuilder stringBuilder_0, char char_0)
		{
			return stringBuilder_0.Append(char_0);
		}

		static string smethod_2(object object_0)
		{
			return object_0.ToString();
		}

		static void smethod_3(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
		{
			RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
		}
	}

	public static string a;
}
