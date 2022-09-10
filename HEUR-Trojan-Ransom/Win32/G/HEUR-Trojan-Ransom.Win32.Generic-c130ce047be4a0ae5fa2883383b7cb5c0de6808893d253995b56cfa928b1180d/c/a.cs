using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace c;

internal sealed class a
{
	internal sealed class j
	{
		internal byte[] u;

		internal byte[] c;

		internal int j;

		internal int g;

		internal int v;

		internal int l;

		internal j()
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	internal struct l
	{
		internal int[] p;
	}

	public object[] f;

	public object o;

	public a(object object_0, object[] object_1)
	{
		while (true)
		{
			int num = -1020779146;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9FEBE5EDu) % 3u)
				{
				case 1u:
					goto IL_0008;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0008:
				o = object_0;
				f = object_1;
				num = (int)(num2 * 1055932144) ^ -196591394;
			}
		}
	}

	[SecuritySafeCritical]
	internal static StringBuilder k<T, U>(U gparam_0, T gparam_1, short short_0, int int_0) where T : string where U : StringBuilder
	{
		char[] array = e.e.k;
		int[] x = default(int[]);
		int num4 = default(int);
		object obj = default(object);
		int num3 = default(int);
		while (true)
		{
			int num = 111140645;
			while (true)
			{
				uint num2;
				int num5;
				switch ((num2 = (uint)num ^ 0x2A687971u) % 10u)
				{
				case 9u:
					num = (int)((num2 * 119495069) ^ 0x4B550B8B);
					continue;
				case 8u:
					num = ((int)num2 * -262259804) ^ -156148873;
					continue;
				case 7u:
					num5 = x[166] - 64730;
					goto IL_003c;
				case 6u:
					x = global::c.l.x;
					num = ((int)num2 * -698216805) ^ -1789134059;
					continue;
				default:
					num5 = array[99] - 59240;
					goto IL_003c;
				case 4u:
					switch (((int_0 ^ short_0) - 82) ^ num4)
					{
					case 0:
						break;
					default:
						num = 1484069378;
						continue;
					}
					goto default;
				case 3u:
					while (true)
					{
						switch (num3)
						{
						case 5:
							break;
						case 10:
							obj = a.smethod_0((StringBuilder)gparam_0, (string)gparam_1);
							num3 = array[322] - 62567;
							continue;
						case 9:
							obj = null;
							goto case 8;
						case 8:
							num3 = x[329] - 17643;
							continue;
						case 1:
							num3 = array[446] - 10214;
							continue;
						case 0:
							num4++;
							if ((short_0 * short_0 + short_0) % 2 != 0)
							{
								num3 = 1;
								goto case 1;
							}
							num3 = x[3] - 24217;
							continue;
						default:
							goto IL_0120;
						case 2:
							num3 = 5;
							break;
						case 3:
						case 6:
							goto IL_012e;
						case 7:
							goto IL_0146;
						case 4:
						case 11:
							return obj as StringBuilder;
						}
						break;
					}
					goto case 4u;
				case 0u:
					goto IL_012e;
				case 1u:
					goto IL_0146;
				case 2u:
					break;
					IL_0146:
					num3 = array[134] - 14346;
					num = 2122263302;
					continue;
					IL_012e:
					num4 = 0;
					num3 = array[569] - 3916;
					num = 2122263302;
					continue;
					IL_0120:
					num = 161173622;
					continue;
					IL_003c:
					num3 = num5;
					num = 722673344;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void c<T>(T gparam_0, byte byte_0, short short_0, char char_0) where T : Stream
	{
		int[] x = global::c.l.x;
		char[] array = e.e.k;
		int num5 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = -1229608220;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xEC15AA6Au) % 10u)
				{
				case 9u:
					num4 = x[238] - 28215;
					num = ((int)num2 * -1104975406) ^ -1441743023;
					continue;
				case 8u:
					num5 = 0;
					num = -993221253;
					continue;
				case 7u:
					num = ((int)num2 * -1533308856) ^ -1967367555;
					continue;
				case 5u:
					while (true)
					{
						switch (num4)
						{
						case 1:
						case 7:
							break;
						case 6:
						case 9:
							a.smethod_1((Stream)gparam_0, byte_0);
							goto case 3;
						case 3:
							num5++;
							if ((byte_0 * byte_0 + byte_0) % 2 != 0)
							{
								num4 = 4;
								goto case 4;
							}
							num4 = 0;
							return;
						case 4:
							num4 = array[481] - 57439;
							continue;
						case 5:
							num4 = x[183] - 6712;
							continue;
						default:
							goto IL_00bc;
						case 2:
						case 8:
							goto IL_00c3;
						case 0:
							return;
						}
						break;
					}
					goto case 8u;
				case 4u:
					goto IL_00c3;
				default:
					num3 = 9;
					goto IL_00de;
				case 2u:
					num4 = 7;
					num = (int)((num2 * 1641985931) ^ 0x3E9B862F);
					continue;
				case 1u:
					num = (int)((num2 * 1974327427) ^ 0x70E408EE);
					continue;
				case 0u:
					num3 = 5;
					goto IL_00de;
				case 6u:
					break;
					IL_00c3:
					switch (((short_0 ^ char_0) - 87) ^ num5)
					{
					default:
						num = -86178316;
						continue;
					case 0:
						break;
					}
					goto default;
					IL_00de:
					num4 = num3;
					num = -513028341;
					continue;
					IL_00bc:
					num = -460628122;
					continue;
				}
				break;
			}
		}
	}

	static StringBuilder smethod_0(StringBuilder stringBuilder_0, string string_0)
	{
		return stringBuilder_0.Append(string_0);
	}

	static void smethod_1(Stream stream_0, byte byte_0)
	{
		stream_0.WriteByte(byte_0);
	}
}
