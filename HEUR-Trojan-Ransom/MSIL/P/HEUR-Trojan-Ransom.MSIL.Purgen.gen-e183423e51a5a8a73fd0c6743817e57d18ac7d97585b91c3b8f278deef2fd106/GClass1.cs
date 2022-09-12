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
		while (true)
		{
			int num = -91299775;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8F9E4BE6u) % 8u)
				{
				case 7u:
				{
					int num3;
					int num4;
					if (bool_0)
					{
						num3 = -1243519144;
						num4 = -1243519144;
					}
					else
					{
						num3 = -364139986;
						num4 = -364139986;
					}
					num = num3 ^ (int)(num2 * 1988436139);
					continue;
				}
				case 6u:
					bool_0 = true;
					num = (int)(num2 * 219948576) ^ -687354124;
					continue;
				case 5u:
					num = -1555184490;
					continue;
				case 3u:
					num = (int)(num2 * 956321924) ^ -1873795976;
					continue;
				case 1u:
					gclass0_1 = new GClass0(GClass1.smethod_5(GClass1.smethod_4(), "\\data\\Music\\horror_music.mp3"));
					gclass0_2 = new GClass0(GClass1.smethod_5(GClass1.smethod_4(), "\\data\\Music\\introduction_start_music.mp3"));
					num = (int)(num2 * 2135245348) ^ -1429366396;
					continue;
				case 0u:
					gclass0_0 = new GClass0(GClass1.smethod_5(GClass1.smethod_4(), "\\data\\Music\\main_menu_theme.mp3"));
					num = (int)((num2 * 1393026169) ^ 0x5DD7B1AF);
					continue;
				default:
					return;
				case 4u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	public static GClass0 smethod_1()
	{
		GClass0 result = default(GClass0);
		while (true)
		{
			int num = 1152053994;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC7F262u) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_0003:
				result = gclass0_0;
				num = ((int)num2 * -139670438) ^ 0x49174E53;
			}
		}
	}

	public static GClass0 smethod_2()
	{
		return gclass0_1;
	}

	public static GClass0 smethod_3()
	{
		GClass0 result = default(GClass0);
		while (true)
		{
			int num = -1357298910;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDB0508F3u) % 4u)
				{
				case 3u:
					num = (int)(num2 * 1839755897) ^ -941985568;
					continue;
				case 1u:
					result = gclass0_2;
					num = ((int)num2 * -568785932) ^ 0x7A2B435C;
					continue;
				case 2u:
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
