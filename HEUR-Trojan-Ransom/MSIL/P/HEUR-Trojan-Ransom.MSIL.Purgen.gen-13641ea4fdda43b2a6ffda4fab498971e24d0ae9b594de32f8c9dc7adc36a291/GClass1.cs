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
		bool flag = bool_0;
		while (true)
		{
			int num = -1535578996;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFDD708CFu) % 7u)
				{
				case 6u:
					gclass0_0 = new GClass0(GClass1.smethod_5(GClass1.smethod_4(), "\\data\\Music\\main_menu_theme.mp3"));
					gclass0_1 = new GClass0(GClass1.smethod_5(GClass1.smethod_4(), "\\data\\Music\\horror_music.mp3"));
					num = (int)(num2 * 450059871) ^ -1789728305;
					continue;
				case 5u:
					num = -1447753802;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -2080463145;
						num4 = -2080463145;
					}
					else
					{
						num3 = -1974403830;
						num4 = -1974403830;
					}
					num = num3 ^ ((int)num2 * -1052218227);
					continue;
				}
				case 3u:
					gclass0_2 = new GClass0(GClass1.smethod_5(GClass1.smethod_4(), "\\data\\Music\\introduction_start_music.mp3"));
					bool_0 = true;
					num = (int)(num2 * 583505767) ^ -1069001320;
					continue;
				case 0u:
					num = ((int)num2 * -1168376872) ^ 0x635ABCD9;
					continue;
				default:
					return;
				case 2u:
					break;
				case 1u:
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
			int num = -1564495556;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9708315Eu) % 4u)
				{
				case 2u:
					result = gclass0_0;
					num = (int)(num2 * 1115376702) ^ -1802603897;
					continue;
				case 1u:
					num = (int)((num2 * 1555422734) ^ 0x585AB7DF);
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
		GClass0 result = gclass0_1;
		while (true)
		{
			int num = 1345231252;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3FF3158u) % 3u)
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
				num = (int)(num2 * 28761252) ^ -142120626;
			}
		}
	}

	public static GClass0 smethod_3()
	{
		GClass0 result = gclass0_2;
		while (true)
		{
			int num = 677260158;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x558AAABEu) % 3u)
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
				num = (int)((num2 * 774955979) ^ 0x5F706DB);
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
