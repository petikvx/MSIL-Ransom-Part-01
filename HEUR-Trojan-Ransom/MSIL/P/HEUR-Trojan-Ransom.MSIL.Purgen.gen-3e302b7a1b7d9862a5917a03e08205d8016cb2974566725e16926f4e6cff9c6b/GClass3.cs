using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

public class GClass3
{
	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static bool smethod_0(string string_0)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		bool flag = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = -1631244512;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAE325BF1u) % 10u)
				{
				case 8u:
					num = -863650956;
					continue;
				case 7u:
					num = (int)((num2 * 310094523) ^ 0x35C8BF0);
					continue;
				case 5u:
					flag = GClass3.smethod_1(string_0);
					num = (int)(num2 * 1332819388) ^ -1036533677;
					continue;
				case 4u:
					num = (int)((num2 * 1054397960) ^ 0x6E9267F7);
					continue;
				case 3u:
					GClass3.smethod_3(GClass3.smethod_2("A directory is missing: '", string_0, "'."), "The Omegle Game", (MessageBoxButtons)0, (MessageBoxIcon)16);
					GClass3.smethod_4();
					num = ((int)num2 * -1726369731) ^ -1665604013;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -269422615;
						num4 = -269422615;
					}
					else
					{
						num3 = -1714567342;
						num4 = -1714567342;
					}
					num = num3 ^ ((int)num2 * -1029164091);
					continue;
				}
				case 1u:
					result = true;
					num = (int)(num2 * 1062889996) ^ -693785685;
					continue;
				case 0u:
					result = false;
					num = ((int)num2 * -1937429014) ^ -495242283;
					continue;
				case 9u:
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
