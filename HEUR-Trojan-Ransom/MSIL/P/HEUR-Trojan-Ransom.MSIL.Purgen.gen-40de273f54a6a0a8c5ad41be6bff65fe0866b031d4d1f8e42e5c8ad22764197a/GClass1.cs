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
			int num = -1024367412;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEB6A0A39u) % 3u)
				{
				case 2u:
					goto IL_0008;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0008:
				bool_1 = false;
				num = ((int)num2 * -2094516608) ^ -2023766954;
			}
		}
	}

	public static void smethod_0()
	{
		while (true)
		{
			int num = 4692037;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4A833EC7u) % 9u)
				{
				case 8u:
				{
					int num3;
					int num4;
					if (!bool_0)
					{
						num3 = -1481153493;
						num4 = -1481153493;
					}
					else
					{
						num3 = -396715455;
						num4 = -396715455;
					}
					num = num3 ^ (int)(num2 * 820486392);
					continue;
				}
				case 7u:
					gclass0_1 = new GClass0(GClass1.smethod_5(GClass1.smethod_4(), "\\data\\Music\\horror_music.mp3"));
					num = ((int)num2 * -1248351641) ^ 0x43A94073;
					continue;
				case 6u:
					bool_0 = true;
					num = ((int)num2 * -932169014) ^ -342051343;
					continue;
				case 5u:
					gclass0_0 = new GClass0(GClass1.smethod_5(GClass1.smethod_4(), "\\data\\Music\\main_menu_theme.mp3"));
					num = ((int)num2 * -633813635) ^ 0x6143B796;
					continue;
				case 3u:
					num = ((int)num2 * -972311827) ^ -1386134677;
					continue;
				case 2u:
					num = 1490231683;
					continue;
				case 1u:
					gclass0_2 = new GClass0(GClass1.smethod_5(GClass1.smethod_4(), "\\data\\Music\\introduction_start_music.mp3"));
					num = ((int)num2 * -97440681) ^ -1907401476;
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

	public static GClass0 smethod_1()
	{
		GClass0 result = default(GClass0);
		while (true)
		{
			int num = -582736434;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x909027EFu) % 4u)
				{
				case 2u:
					num = (int)((num2 * 2048831028) ^ 0x700C645C);
					continue;
				case 1u:
					result = gclass0_0;
					num = ((int)num2 * -1393859607) ^ 0x51034E18;
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
			int num = -1479498963;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDEABECC7u) % 4u)
				{
				case 2u:
					result = gclass0_1;
					num = (int)((num2 * 1360932869) ^ 0x16ED7828);
					continue;
				case 1u:
					num = ((int)num2 * -685698243) ^ -21197483;
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
		GClass0 result = default(GClass0);
		while (true)
		{
			int num = -723333259;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA5970ABBu) % 4u)
				{
				case 2u:
					result = gclass0_2;
					num = (int)((num2 * 95875338) ^ 0x48CCE87E);
					continue;
				case 1u:
					num = ((int)num2 * -494060731) ^ 0x6D6EC1AE;
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
