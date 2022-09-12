using System.Windows.Forms;

public class GClass1
{
	private static GClass0 gclass0_0;

	private static GClass0 gclass0_1;

	private static GClass0 gclass0_2;

	private static bool bool_0 = false;

	public static bool bool_1;

	static GClass1()
	{
		while (true)
		{
			int num = -1189651905;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB41A772Eu) % 3u)
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
				bool_1 = false;
				num = (int)((num2 * 889375730) ^ 0x7E5A147D);
			}
		}
	}

	public static void smethod_0()
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -704498581;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE6693ED4u) % 7u)
				{
				case 6u:
					gclass0_0 = new GClass0(GClass1.smethod_5(GClass1.smethod_4(), "\\data\\Music\\main_menu_theme.mp3"));
					gclass0_1 = new GClass0(GClass1.smethod_5(GClass1.smethod_4(), "\\data\\Music\\horror_music.mp3"));
					num = -2119503897;
					continue;
				case 5u:
					num = (int)((num2 * 611030948) ^ 0x5EA184BA);
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -954479423;
						num4 = -954479423;
					}
					else
					{
						num3 = -1938046865;
						num4 = -1938046865;
					}
					num = num3 ^ ((int)num2 * -2082601617);
					continue;
				}
				case 3u:
					flag = bool_0;
					num = ((int)num2 * -199271309) ^ 0x56796456;
					continue;
				case 1u:
					gclass0_2 = new GClass0(GClass1.smethod_5(GClass1.smethod_4(), "\\data\\Music\\introduction_start_music.mp3"));
					bool_0 = true;
					num = ((int)num2 * -1788449181) ^ -2137368021;
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
		GClass0 result = default(GClass0);
		while (true)
		{
			int num = -1999245940;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEF06D646u) % 4u)
				{
				case 2u:
					result = gclass0_0;
					num = (int)((num2 * 1449410411) ^ 0x7242167D);
					continue;
				case 1u:
					num = ((int)num2 * -1276971689) ^ 0x68829FE9;
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

	public static GClass0 smethod_2()
	{
		GClass0 result = default(GClass0);
		while (true)
		{
			int num = 758406175;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF827E9Cu) % 4u)
				{
				case 3u:
					result = gclass0_1;
					num = (int)((num2 * 402281436) ^ 0x5B9B0EFD);
					continue;
				case 1u:
					num = ((int)num2 * -201516485) ^ 0x6D1F5A71;
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

	public static GClass0 smethod_3()
	{
		GClass0 result = gclass0_2;
		while (true)
		{
			int num = -71630676;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC05D3437u) % 3u)
				{
				case 1u:
					goto IL_0008;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0008:
				num = (int)(num2 * 1575750872) ^ -821624421;
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
