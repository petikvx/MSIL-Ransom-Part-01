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
			int num = 623842877;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x738A7CD5u) % 6u)
				{
				case 5u:
					num = ((int)num2 * -600462105) ^ 0x2D33873E;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (bool_0)
					{
						num3 = 775414598;
						num4 = 775414598;
					}
					else
					{
						num3 = 228194734;
						num4 = 228194734;
					}
					num = num3 ^ (int)(num2 * 1878456286);
					continue;
				}
				case 3u:
					num = 857845550;
					continue;
				case 1u:
					gclass0_0 = new GClass0(GClass1.smethod_5(GClass1.smethod_4(), "\\data\\Music\\main_menu_theme.mp3"));
					gclass0_1 = new GClass0(GClass1.smethod_5(GClass1.smethod_4(), "\\data\\Music\\horror_music.mp3"));
					gclass0_2 = new GClass0(GClass1.smethod_5(GClass1.smethod_4(), "\\data\\Music\\introduction_start_music.mp3"));
					bool_0 = true;
					num = (int)((num2 * 411741026) ^ 0x3BB61D3D);
					continue;
				default:
					return;
				case 0u:
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
			int num = 1766573508;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x26AA567Bu) % 4u)
				{
				case 3u:
					result = gclass0_0;
					num = (int)((num2 * 329389079) ^ 0x35495990);
					continue;
				case 2u:
					num = (int)(num2 * 1722182351) ^ -1715144812;
					continue;
				case 0u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	public static GClass0 smethod_2()
	{
		GClass0 result = default(GClass0);
		while (true)
		{
			int num = 161040471;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6290C7ADu) % 4u)
				{
				case 2u:
					result = gclass0_1;
					num = ((int)num2 * -947455143) ^ 0x23084C9A;
					continue;
				case 1u:
					num = (int)((num2 * 527551526) ^ 0xCDBDB4F);
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
			int num = 474424212;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4B855FC9u) % 4u)
				{
				case 1u:
					result = gclass0_2;
					num = (int)(num2 * 2139054999) ^ -197907518;
					continue;
				case 0u:
					num = (int)((num2 * 1544952947) ^ 0x6DDEECF);
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
