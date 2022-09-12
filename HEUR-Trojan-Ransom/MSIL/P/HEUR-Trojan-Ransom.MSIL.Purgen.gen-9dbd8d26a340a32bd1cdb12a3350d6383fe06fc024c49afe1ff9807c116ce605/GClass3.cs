using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

public class GClass3
{
	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static bool smethod_0(string string_0)
	{
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		bool result = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -583171721;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA0330CDCu) % 9u)
				{
				case 8u:
					num = ((int)num2 * -593715651) ^ 0x4B201F58;
					continue;
				case 7u:
					GClass3.smethod_4();
					result = false;
					num = ((int)num2 * -1995833726) ^ 0x30738BD;
					continue;
				case 6u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -721073249;
						num4 = -721073249;
					}
					else
					{
						num3 = -1237836284;
						num4 = -1237836284;
					}
					num = num3 ^ ((int)num2 * -1306256075);
					continue;
				}
				case 4u:
					flag = GClass3.smethod_1(string_0);
					num = ((int)num2 * -1317687381) ^ -1815203065;
					continue;
				case 2u:
					num = ((int)num2 * -1889161859) ^ -331901612;
					continue;
				case 1u:
					GClass3.smethod_3(GClass3.smethod_2("A directory is missing: '", string_0, "'."), "The Omegle Game", (MessageBoxButtons)0, (MessageBoxIcon)16);
					num = -2095344332;
					continue;
				case 0u:
					result = true;
					num = (int)((num2 * 164706118) ^ 0x260C0745);
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

	static bool smethod_1(string string_0)
	{
		return Directory.Exists(string_0);
	}

	static string smethod_2(string string_0, string string_1, string string_2)
	{
		return string_0 + string_1 + string_2;
	}

	static DialogResult smethod_3(string string_0, string string_1, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show(string_0, string_1, messageBoxButtons_0, messageBoxIcon_0);
	}

	static void smethod_4()
	{
		ProjectData.EndApp();
	}
}
