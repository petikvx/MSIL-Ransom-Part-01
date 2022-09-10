using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Security;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;
using a;

namespace c;

internal sealed class v : Form
{
	private m.c e = new m.c();

	public v()
	{
		y();
	}

	private void p(object sender, EventArgs e)
	{
		int[] x = l.x;
		int num = 4;
		while (true)
		{
			int num2 = 529919402;
			while (true)
			{
				switch ((uint)(num2 ^ 0xC5C308F) % 6u)
				{
				case 3u:
					v.smethod_1(0);
					num2 = 1212794604;
					continue;
				case 2u:
					goto IL_001a;
				case 1u:
					switch (num)
					{
					case 2:
						break;
					case 0:
					case 1:
						goto IL_001a;
					default:
						goto IL_0049;
					case 4:
						goto IL_0050;
					case 3:
						return;
					}
					goto case 3u;
				case 0u:
					goto IL_0050;
				default:
					return;
				case 4u:
					break;
				case 5u:
					return;
					IL_0050:
					m.g = new a(global::c.e.a(v.smethod_0(global::c.w.c(j.c())), 'S', 79), new object[0]);
					num2 = 1845221445;
					continue;
					IL_0049:
					num2 = 450474159;
					continue;
					IL_001a:
					num = x[325] - 8189;
					num2 = 529919402;
					continue;
				}
				break;
			}
		}
	}

	public static byte[] a(byte[] byte_0, MemoryStream memoryStream_0, ICryptoTransform icryptoTransform_0)
	{
		char[] array = global::c.e.e.k;
		int[] x = l.x;
		object obj = v.smethod_2((Stream)memoryStream_0, icryptoTransform_0, CryptoStreamMode.Write);
		object obj2 = default(object);
		try
		{
			int num = 2;
			while (true)
			{
				IL_00ef:
				int num2 = 583102960;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num2 ^ 0x3650EEAFu) % 8u)
					{
					case 7u:
						switch (num)
						{
						case 0:
							goto IL_0041;
						case 3:
							goto IL_0057;
						case 1:
						case 2:
						case 4:
						case 5:
							goto IL_0070;
						}
						num2 = 1883329644;
						continue;
					case 4u:
						goto IL_0041;
					case 6u:
						goto IL_0057;
					case 3u:
						goto IL_0070;
					case 1u:
						num = x[332] - 61255;
						num2 = ((int)num3 * -668349618) ^ 0x47570C9;
						continue;
					case 0u:
						num2 = (int)(num3 * 1285006275) ^ -546456616;
						continue;
					default:
						goto end_IL_00bd;
					case 5u:
						break;
					case 2u:
						goto end_IL_00bd;
						IL_0070:
						global::c.e.x((Stream)(obj as CryptoStream), byte_0, 0, byte_0.Length, 'Ğ', (short)294);
						num2 = 1458495318;
						continue;
						IL_0057:
						obj2 = global::c.e.d(memoryStream_0, 211, 237);
						num2 = 1415047749;
						continue;
						IL_0041:
						w(obj as CryptoStream, '^', 13);
						num2 = 2069643465;
						continue;
					}
					goto IL_00ef;
					continue;
					end_IL_00bd:
					break;
				}
				break;
			}
		}
		finally
		{
			int num4 = 2;
			while (true)
			{
				IL_0196:
				int num5 = 685807909;
				while (true)
				{
					uint num3;
					int num6;
					switch ((num3 = (uint)num5 ^ 0x3650EEAFu) % 5u)
					{
					case 3u:
						switch (num4)
						{
						default:
							num5 = 1442803535;
							continue;
						case 0:
						case 2:
						case 3:
						case 5:
						case 6:
							break;
						case 1:
							v.smethod_3((IDisposable)(obj as CryptoStream));
							goto end_IL_0170;
						case 4:
							goto end_IL_0170;
						}
						goto case 2u;
					case 2u:
					{
						int num7;
						if ((CryptoStream)obj != null)
						{
							num5 = 285432578;
							num7 = 285432578;
						}
						else
						{
							num5 = 358716497;
							num7 = 358716497;
						}
						continue;
					}
					case 1u:
						num6 = x[232] - 42318;
						goto IL_015b;
					default:
						num6 = array[31] - 10395;
						goto IL_015b;
					case 4u:
						break;
						IL_015b:
						num4 = num6;
						num5 = 685807909;
						continue;
					}
					goto IL_0196;
					continue;
					end_IL_0170:
					break;
				}
				break;
			}
		}
		return (byte[])obj2;
	}

	protected override void o(bool disposing)
	{
		int[] x = l.x;
		int num3 = default(int);
		while (true)
		{
			int num = -309920021;
			while (true)
			{
				uint num2;
				int num5;
				int num4;
				switch ((num2 = (uint)num ^ 0x81A4F9FAu) % 6u)
				{
				case 5u:
					num5 = 5;
					goto IL_000c;
				default:
					num5 = 4;
					goto IL_000c;
				case 2u:
					while (true)
					{
						switch (num3)
						{
						case 5:
							if (e.f != null)
							{
								num3 = x[41] - 32976;
								continue;
							}
							num3 = 4;
							goto case 0;
						case 2:
						case 6:
							goto IL_005b;
						case 1:
						case 3:
							v.smethod_3((IDisposable)e.f);
							goto case 0;
						case 0:
						case 4:
							((Form)this).Dispose(disposing);
							return;
						}
						break;
					}
					num = -845197500;
					continue;
				case 0u:
					goto IL_005b;
				case 1u:
					num3 = 6;
					num = ((int)num2 * -1632102951) ^ -938189229;
					continue;
				case 4u:
					break;
					IL_005b:
					if (disposing)
					{
						num = -2027297929;
						num4 = -2027297929;
					}
					else
					{
						num = -1536297259;
						num4 = -1536297259;
					}
					continue;
					IL_000c:
					num3 = num5;
					num = -844088262;
					continue;
				}
				break;
			}
		}
	}

	private void y()
	{
		int num = 1;
		while (true)
		{
			int num2 = -437842293;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xAA6AFE78u) % 13u)
				{
				case 11u:
					global::c.e.p.o<Form>((Form)(object)this, new Size(120, 0), 497, 414);
					num2 = (int)((num3 * 1260586098) ^ 0x10171303);
					continue;
				case 10u:
					m.q<ContainerControl>((ContainerControl)(object)this, new SizeF(6f, 13f), 764, (short)716);
					num2 = -101690811;
					continue;
				case 9u:
					num = 5;
					num2 = ((int)num3 * -107507150) ^ -1836293279;
					continue;
				case 8u:
					num = 4;
					num2 = (int)(num3 * 1095041115) ^ -328203715;
					continue;
				case 7u:
					goto IL_0082;
				case 6u:
					switch (num)
					{
					case 0:
						break;
					case 3:
						goto IL_0082;
					default:
						goto IL_00d2;
					case 1:
						goto IL_00d9;
					case 2:
						goto IL_00f0;
					case 4:
						goto IL_00f9;
					case 5:
						goto IL_0119;
					case 6:
						goto IL_018b;
					}
					goto case 10u;
				case 5u:
					goto IL_00d9;
				case 0u:
					goto IL_00f0;
				case 1u:
					goto IL_00f9;
				case 3u:
					goto IL_0119;
				case 2u:
					num2 = ((int)num3 * -836735118) ^ 0x4BEDBFF1;
					continue;
				case 4u:
					break;
				default:
					goto IL_018b;
					IL_018b:
					((Control)this).ResumeLayout(false);
					return;
					IL_0119:
					t.q<ContainerControl>((ContainerControl)(object)this, (AutoScaleMode)1, 'Ο', (short)915);
					num2 = -640755077;
					continue;
					IL_00f9:
					((Form)this).set_StartPosition((FormStartPosition)1);
					((Form)this).add_Load((EventHandler)p);
					num2 = -1410668375;
					continue;
					IL_00f0:
					num = 3;
					num2 = -437842293;
					continue;
					IL_00d9:
					global::c.e.o<Control>((Control)(object)this, (short)541, 613);
					num2 = -876052341;
					continue;
					IL_00d2:
					num2 = -128911052;
					continue;
					IL_0082:
					global::c.p.v<Form>((Form)(object)this, (FormBorderStyle)5, '\u031b', 893);
					((Control)this).set_Name(t.h(8, 1517859042, '8'));
					num2 = -422886824;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void w<T>(T gparam_0, char char_0, short short_0) where T : CryptoStream
	{
		int num = 5;
		int num5 = default(int);
		int num6 = default(int);
		while (true)
		{
			int num2 = 2095145983;
			while (true)
			{
				uint num3;
				int num4;
				switch ((num3 = (uint)num2 ^ 0x5150C74Bu) % 8u)
				{
				case 7u:
					num = 6;
					num2 = (int)(num3 * 599047603) ^ -1520080424;
					continue;
				case 6u:
					num2 = ((int)num3 * -12259309) ^ 0x7D8DEA75;
					continue;
				default:
					num4 = 3;
					goto IL_002e;
				case 4u:
					switch (num)
					{
					case 1:
						num = 4;
						goto case 4;
					case 3:
						v.smethod_4((CryptoStream)gparam_0);
						goto case 4;
					case 5:
						goto IL_007f;
					case 4:
					case 8:
						num5++;
						num6 = char_0 * char_0;
						num6 = char_0 + num6;
						num = 2;
						goto case 2;
					case 2:
					{
						int num7 = num6;
						l.x[150] = (l.x[150] * short_0) & 0xB0;
						if (num7 % 2 != 0)
						{
							num = 6;
							goto IL_00bb;
						}
						num = 0;
						return;
					}
					case 6:
					case 9:
						goto IL_00bb;
					case 0:
					case 7:
						return;
					}
					num2 = 16785113;
					continue;
				case 2u:
					goto IL_007f;
				case 3u:
					goto IL_00bb;
				case 1u:
					num4 = 1;
					goto IL_002e;
				case 0u:
					break;
					IL_007f:
					num5 = 0;
					num2 = 1350528164;
					continue;
					IL_00bb:
					switch (((short_0 ^ char_0) - 83) ^ num5)
					{
					case 0:
						break;
					default:
						num2 = 1037744858;
						continue;
					}
					goto default;
					IL_002e:
					num = num4;
					num2 = 2095145983;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string q(byte[] byte_0, char char_0, int int_0)
	{
		int[] x = l.x;
		char[] array = global::c.e.e.k;
		int num4 = default(int);
		IComparable<string> comparable = default(IComparable<string>);
		int num3 = default(int);
		int num5 = default(int);
		while (true)
		{
			int num = -1145776492;
			while (true)
			{
				uint num2;
				int num6;
				switch ((num2 = (uint)num ^ 0xCB86D9D6u) % 10u)
				{
				case 9u:
					num6 = 5;
					goto IL_0012;
				case 8u:
					num = ((int)num2 * -1755387389) ^ 0x37A3E5A8;
					continue;
				case 7u:
					switch (((int_0 ^ char_0) - 61) ^ num4)
					{
					default:
						num = -1799959771;
						continue;
					case 0:
						break;
					}
					goto default;
				default:
					num6 = 4;
					goto IL_0012;
				case 5u:
					goto IL_004e;
				case 3u:
					num = (int)(num2 * 2062415961) ^ -1073553420;
					continue;
				case 2u:
					num3 = x[318] - 11838;
					num = (int)(num2 * 761206511) ^ -1776250411;
					continue;
				case 1u:
					while (true)
					{
						switch (num3)
						{
						case 11:
							break;
						case 10:
							goto IL_004e;
						case 3:
						case 7:
							goto IL_009a;
						case 6:
							num3 = array[530] - 35747;
							continue;
						case 5:
							comparable = null;
							goto case 6;
						case 1:
						case 4:
							comparable = v.smethod_5(byte_0);
							num3 = 2;
							goto case 2;
						case 2:
							num4++;
							num5 = char_0 * char_0;
							num5 = char_0 + num5;
							num3 = array[453] - 56357;
							continue;
						default:
							goto IL_012a;
						case 8:
							goto IL_013a;
						case 9:
							num3 = 11;
							break;
						case 0:
							return (string)comparable;
						}
						break;
						IL_009a:
						if (num5 % 2 == 0)
						{
							num3 = array[304] - 45993;
							continue;
						}
						num3 = 11;
						break;
					}
					goto case 7u;
				case 0u:
					goto IL_013a;
				case 4u:
					break;
					IL_013a:
					num4 = 0;
					num = -323998200;
					continue;
					IL_012a:
					num = -823737837;
					continue;
					IL_004e:
					num3 = x[330] - 63419;
					num = -795411091;
					continue;
					IL_0012:
					num3 = num6;
					num = -795411091;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static char k<T>(T gparam_0, int int_0, int int_1, int int_2) where T : string
	{
		char[] array = global::c.e.e.k;
		int num4 = default(int);
		int[] x = default(int[]);
		char result = default(char);
		int num5 = default(int);
		int num6 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = -1758926117;
			while (true)
			{
				uint num2;
				int num7;
				switch ((num2 = (uint)num ^ 0xB37C7A79u) % 11u)
				{
				case 10u:
					num = (int)(num2 * 2101651252) ^ -1226270850;
					continue;
				case 9u:
					num4 = 0;
					num3 = 10;
					num = -2138464050;
					continue;
				case 8u:
					num = (int)(num2 * 914875720) ^ -590834515;
					continue;
				case 7u:
					num = (int)((num2 * 181258387) ^ 0x34D64C93);
					continue;
				default:
					num7 = 5;
					goto IL_0051;
				case 5u:
					num7 = 0;
					goto IL_0051;
				case 3u:
					goto IL_005f;
				case 2u:
					goto IL_0077;
				case 1u:
					x = l.x;
					num = (int)(num2 * 864100023) ^ -1403031071;
					continue;
				case 0u:
					while (true)
					{
						switch (num3)
						{
						case 4:
							break;
						case 6:
							goto IL_005f;
						case 3:
						case 10:
							goto IL_0077;
						case 5:
						case 8:
							result = v.smethod_6((string)gparam_0, int_0);
							num3 = array[318] - 21042;
							continue;
						case 7:
							num3 = x[103] - 65043;
							continue;
						default:
							goto IL_010a;
						case 0:
							result = '#';
							goto case 9;
						case 9:
							num3 = 2;
							goto case 2;
						case 2:
							num4++;
							num5 = 1703;
							num6 = 2900209;
							num3 = 1;
							goto case 1;
						case 1:
							num6 = num5 + num6;
							if (num6 % 2 != 0)
							{
								num3 = 10;
								goto IL_0077;
							}
							num3 = 11;
							goto case 11;
						case 11:
							return result;
						}
						break;
					}
					goto case 9u;
				case 4u:
					break;
					IL_010a:
					num = -1997964448;
					continue;
					IL_0077:
					switch (((int_2 ^ int_1) - 6) ^ num4)
					{
					case 0:
						break;
					default:
						num = -892205508;
						continue;
					}
					goto default;
					IL_005f:
					num3 = array[190] - 39401;
					num = -595232741;
					continue;
					IL_0051:
					num3 = num7;
					num = -1501257003;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void c<T>(T gparam_0, short short_0, short short_1)
	{
		int[] x = l.x;
		char[] array = global::c.e.e.k;
		int num5 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = 1997571908;
			while (true)
			{
				uint num2;
				int num4;
				switch ((num2 = (uint)num ^ 0x54556131u) % 10u)
				{
				case 9u:
					switch (((short_0 ^ short_1) - 22) ^ num5)
					{
					default:
						num = 331896244;
						continue;
					case 0:
						break;
					}
					goto default;
				default:
					num4 = 4;
					goto IL_002e;
				case 8u:
					goto IL_0039;
				case 7u:
					while (true)
					{
						switch (num3)
						{
						case 1:
							break;
						case 6:
							goto IL_0039;
						case 0:
							num3 = array[551] - 3263;
							continue;
						default:
							goto IL_007e;
						case 3:
						case 4:
							v.smethod_7((object)gparam_0);
							goto case 7;
						case 7:
						case 8:
							num5++;
							goto case 5;
						case 5:
							num3 = 2;
							return;
						case 2:
							return;
						}
						break;
					}
					goto case 9u;
				case 5u:
					num = (int)(num2 * 1030967562) ^ -962701616;
					continue;
				case 3u:
					num4 = x[146] - 49129;
					goto IL_002e;
				case 2u:
					num = ((int)num2 * -1617368603) ^ -991620242;
					continue;
				case 1u:
					num3 = 6;
					num = ((int)num2 * -1336989420) ^ -1576305818;
					continue;
				case 0u:
					num3 = x[100] - 18684;
					num = (int)(num2 * 904206477) ^ -169832475;
					continue;
				case 6u:
					break;
					IL_007e:
					num = 245312935;
					continue;
					IL_0039:
					num5 = 0;
					num = 1374544185;
					continue;
					IL_002e:
					num3 = num4;
					num = 1619370052;
					continue;
				}
				break;
			}
		}
	}

	static Assembly smethod_0(byte[] byte_0)
	{
		return Class1.Load(byte_0);
	}

	static void smethod_1(int int_0)
	{
		Environment.Exit(int_0);
	}

	static CryptoStream smethod_2(Stream stream_0, ICryptoTransform icryptoTransform_0, CryptoStreamMode cryptoStreamMode_0)
	{
		return new CryptoStream(stream_0, icryptoTransform_0, cryptoStreamMode_0);
	}

	static void smethod_3(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static void smethod_4(CryptoStream cryptoStream_0)
	{
		cryptoStream_0.FlushFinalBlock();
	}

	static string smethod_5(byte[] byte_0)
	{
		return Convert.ToBase64String(byte_0);
	}

	static char smethod_6(string string_0, int int_0)
	{
		return string_0[int_0];
	}

	static void smethod_7(object object_0)
	{
		Monitor.Enter(object_0);
	}
}
