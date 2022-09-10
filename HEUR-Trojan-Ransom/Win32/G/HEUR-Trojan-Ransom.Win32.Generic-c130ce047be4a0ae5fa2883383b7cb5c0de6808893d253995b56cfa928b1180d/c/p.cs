using System;
using System.Security;
using System.Windows.Forms;

namespace c;

internal sealed class p
{
	public static byte[] c(t t_0)
	{
		return global::c.v.a(t_0.u, t_0.s, t_0.t);
	}

	[SecuritySafeCritical]
	internal static void v<T>(T gparam_0, FormBorderStyle formBorderStyle_0, char char_0, int int_0) where T : Form
	{
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		char[] k = e.e.k;
		int[] x = default(int[]);
		int num5 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = -1597819454;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x85F0A960u) % 8u)
				{
				case 7u:
					while (true)
					{
						switch (num4)
						{
						case 9:
							num4 = x[274] - 32544;
							continue;
						case 2:
						case 3:
						case 5:
							num4 = x[288] - 25777;
							continue;
						case 0:
							goto IL_0060;
						case 8:
							goto IL_0077;
						case 4:
						case 6:
							p.smethod_0((Form)(object)gparam_0, formBorderStyle_0);
							goto case 1;
						case 1:
							num5++;
							e.e.k[394] = (char)((e.e.k[394] + int_0) & '\u0096');
							num4 = 7;
							return;
						case 7:
							return;
						}
						break;
					}
					num = -1152861162;
					continue;
				case 6u:
					goto IL_0060;
				case 3u:
					goto IL_0077;
				default:
					num3 = x[33] - 9827;
					goto IL_009a;
				case 2u:
					x = l.x;
					num = ((int)num2 * -1814630048) ^ -919418711;
					continue;
				case 1u:
					num4 = 0;
					num = ((int)num2 * -1194833184) ^ -1482725689;
					continue;
				case 0u:
					num3 = 9;
					goto IL_009a;
				case 4u:
					break;
					IL_0077:
					switch (((char_0 ^ int_0) - 102) ^ num5)
					{
					default:
						num = -1242771056;
						continue;
					case 0:
						break;
					}
					goto default;
					IL_009a:
					num4 = num3;
					num = -517167321;
					continue;
					IL_0060:
					num5 = 0;
					num4 = k[417] - 2709;
					num = -517167321;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void d<T, U>(T gparam_0, U gparam_1, char char_0, short short_0) where T : AppDomain where U : ResolveEventHandler
	{
		int[] x = l.x;
		char[] k = e.e.k;
		int num = 6;
		int num4 = default(int);
		while (true)
		{
			int num2 = -681463372;
			while (true)
			{
				uint num3;
				int num5;
				switch ((num3 = (uint)num2 ^ 0xEF136FA8u) % 9u)
				{
				case 8u:
					switch (((char_0 ^ short_0) - 108) ^ num4)
					{
					default:
						num2 = -182203941;
						continue;
					case 0:
						break;
					}
					goto default;
				default:
					num5 = 7;
					goto IL_0030;
				case 7u:
					num5 = x[325] - 8187;
					goto IL_0030;
				case 6u:
					while (true)
					{
						switch (num)
						{
						case 8:
							break;
						case 4:
							num = k[380] - 54941;
							continue;
						default:
							goto IL_0086;
						case 6:
							goto IL_008d;
						case 7:
							p.smethod_1((AppDomain)gparam_0, (ResolveEventHandler)gparam_1);
							goto case 1;
						case 1:
						case 3:
							num4++;
							if ((char_0 * char_0 + char_0) % 2 != 0)
							{
								num = 0;
								goto case 0;
							}
							num = 5;
							return;
						case 0:
							num = 8;
							break;
						case 2:
						case 5:
						case 9:
							return;
						}
						break;
					}
					goto case 8u;
				case 0u:
					goto IL_008d;
				case 5u:
					num = 8;
					num2 = ((int)num3 * -1132762625) ^ -1212388264;
					continue;
				case 4u:
					num2 = (int)(num3 * 789273420) ^ -1112260888;
					continue;
				case 1u:
					num2 = ((int)num3 * -721691626) ^ 0x59DB131C;
					continue;
				case 3u:
					break;
					IL_008d:
					num4 = 0;
					num2 = -397469732;
					continue;
					IL_0086:
					num2 = -1573858481;
					continue;
					IL_0030:
					num = num5;
					num2 = -227046459;
					continue;
				}
				break;
			}
		}
	}

	static void smethod_0(Form form_0, FormBorderStyle formBorderStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_FormBorderStyle(formBorderStyle_0);
	}

	static void smethod_1(AppDomain appDomain_0, ResolveEventHandler resolveEventHandler_0)
	{
		appDomain_0.AssemblyResolve += resolveEventHandler_0;
	}
}
