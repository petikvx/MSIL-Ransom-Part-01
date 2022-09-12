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
			int num = -280614739;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAFF933DFu) % 7u)
				{
				case 5u:
					num = (int)(num2 * 136574431) ^ -2026864928;
					continue;
				case 4u:
					num = -604553962;
					continue;
				case 3u:
					flag = bool_0;
					num = ((int)num2 * -132365799) ^ -1233101631;
					continue;
				case 2u:
					gclass0_0 = new GClass0(GClass1.smethod_5(GClass1.smethod_4(), "\\data\\Music\\main_menu_theme.mp3"));
					gclass0_1 = new GClass0(GClass1.smethod_5(GClass1.smethod_4(), "\\data\\Music\\horror_music.mp3"));
					gclass0_2 = new GClass0(GClass1.smethod_5(GClass1.smethod_4(), "\\data\\Music\\introduction_start_music.mp3"));
					bool_0 = true;
					num = ((int)num2 * -1814138808) ^ -1610353938;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1484848655;
						num4 = 1484848655;
					}
					else
					{
						num3 = 1247952397;
						num4 = 1247952397;
					}
					num = num3 ^ ((int)num2 * -798749082);
					continue;
				}
				default:
					return;
				case 0u:
					break;
				case 6u:
					return;
				}
				break;
			}
		}
	}

	public static GClass0 smethod_1()
	{
		return gclass0_0;
	}

	public static GClass0 smethod_2()
	{
		return gclass0_1;
	}

	public static GClass0 smethod_3()
	{
		GClass0 result = gclass0_2;
		while (true)
		{
			int num = 2034843349;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2B08BB07u) % 3u)
				{
				case 1u:
					goto IL_0008;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_0008:
				num = (int)(num2 * 1538696531) ^ -1869356043;
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
