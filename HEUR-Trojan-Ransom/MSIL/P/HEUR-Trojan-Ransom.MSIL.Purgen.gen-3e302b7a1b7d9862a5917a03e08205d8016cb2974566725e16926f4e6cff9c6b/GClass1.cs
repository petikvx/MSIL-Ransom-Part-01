using System.Windows.Forms;

public class GClass1
{
	private static GClass0 gclass0_0;

	private static GClass0 gclass0_1;

	private static GClass0 gclass0_2;

	private static bool bool_0 = false;

	public static bool bool_1 = false;

	public static void smethod_0()
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -2082603978;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8E7712D0u) % 8u)
				{
				case 7u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -732707781;
						num4 = -732707781;
					}
					else
					{
						num3 = -519656314;
						num4 = -519656314;
					}
					num = num3 ^ ((int)num2 * -713148458);
					continue;
				}
				case 6u:
					flag = bool_0;
					num = (int)(num2 * 768688358) ^ -136177589;
					continue;
				case 5u:
					gclass0_0 = new GClass0(GClass1.smethod_5(GClass1.smethod_4(), "\\data\\Music\\main_menu_theme.mp3"));
					gclass0_1 = new GClass0(GClass1.smethod_5(GClass1.smethod_4(), "\\data\\Music\\horror_music.mp3"));
					num = (int)(num2 * 1756717849) ^ -2131860514;
					continue;
				case 4u:
					num = -1946406315;
					continue;
				case 3u:
					gclass0_2 = new GClass0(GClass1.smethod_5(GClass1.smethod_4(), "\\data\\Music\\introduction_start_music.mp3"));
					bool_0 = true;
					num = (int)(num2 * 363861504) ^ -323092952;
					continue;
				case 1u:
					num = ((int)num2 * -1339798167) ^ 0x3D818681;
					continue;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	public static GClass0 smethod_1()
	{
		GClass0 result = gclass0_0;
		while (true)
		{
			int num = -860073460;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDE0F84BFu) % 3u)
				{
				case 2u:
					goto IL_0008;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0008:
				num = ((int)num2 * -294018310) ^ 0x701D24D6;
			}
		}
	}

	public static GClass0 smethod_2()
	{
		GClass0 result = default(GClass0);
		while (true)
		{
			int num = 172510268;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x13405A7Du) % 4u)
				{
				case 1u:
					result = gclass0_1;
					num = (int)(num2 * 1344680770) ^ -334656137;
					continue;
				case 0u:
					num = (int)(num2 * 212777831) ^ -793025853;
					continue;
				case 3u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	public static GClass0 smethod_3()
	{
		GClass0 result = default(GClass0);
		while (true)
		{
			int num = 1087129683;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x11EF1392u) % 4u)
				{
				case 2u:
					num = ((int)num2 * -1970841589) ^ 0x3AF43564;
					continue;
				case 1u:
					result = gclass0_2;
					num = (int)(num2 * 2120544659) ^ -1387271041;
					continue;
				case 3u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	static string smethod_4()
	{
		return Application.get_StartupPath();
	}

	static string smethod_5(string string_0, string string_1)
	{
		return string_0 + string_1;
	}
}
