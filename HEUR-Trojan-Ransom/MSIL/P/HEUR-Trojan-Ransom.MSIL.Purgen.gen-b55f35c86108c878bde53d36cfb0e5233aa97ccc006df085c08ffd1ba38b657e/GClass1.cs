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
			int num = 1495830485;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5E43A8BFu) % 3u)
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
				num = ((int)num2 * -60180418) ^ 0x1F371AF6;
			}
		}
	}

	public static void smethod_0()
	{
		while (true)
		{
			int num = -304040134;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC8DD0363u) % 6u)
				{
				case 4u:
					gclass0_0 = new GClass0(GClass1.smethod_5(GClass1.smethod_4(), "\\data\\Music\\main_menu_theme.mp3"));
					num = -98819643;
					continue;
				case 2u:
					gclass0_1 = new GClass0(GClass1.smethod_5(GClass1.smethod_4(), "\\data\\Music\\horror_music.mp3"));
					gclass0_2 = new GClass0(GClass1.smethod_5(GClass1.smethod_4(), "\\data\\Music\\introduction_start_music.mp3"));
					bool_0 = true;
					num = (int)((num2 * 972040918) ^ 0x1AE6465C);
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (bool_0)
					{
						num3 = 1731512076;
						num4 = 1731512076;
					}
					else
					{
						num3 = 375962920;
						num4 = 375962920;
					}
					num = num3 ^ (int)(num2 * 943782461);
					continue;
				}
				case 0u:
					num = (int)(num2 * 8499599) ^ -1006747170;
					continue;
				default:
					return;
				case 5u:
					break;
				case 3u:
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
			int num = 1974782639;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7FEFEE31u) % 4u)
				{
				case 3u:
					num = (int)(num2 * 549567134) ^ -12862566;
					continue;
				case 2u:
					result = gclass0_0;
					num = ((int)num2 * -1365831565) ^ 0x7CFB317C;
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
			int num = 418819766;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7FBAEDDu) % 4u)
				{
				case 3u:
					result = gclass0_1;
					num = ((int)num2 * -1369580283) ^ -2021654256;
					continue;
				case 2u:
					num = ((int)num2 * -1268115459) ^ 0x37ECB68E;
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
			int num = -879681589;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC53FE5E2u) % 4u)
				{
				case 3u:
					num = (int)((num2 * 552601686) ^ 0x74DF9106);
					continue;
				case 1u:
					result = gclass0_2;
					num = ((int)num2 * -305144424) ^ -1709025531;
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

	static string smethod_4()
	{
		return Application.get_StartupPath();
	}

	static string smethod_5(string string_0, string string_1)
	{
		return string_0 + string_1;
	}
}
