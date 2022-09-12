using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

public class GClass4
{
	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static bool smethod_0(string string_0)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		bool result = default(bool);
		while (true)
		{
			int num = 1715861513;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x38AB2360u) % 9u)
				{
				case 8u:
					num = (int)((num2 * 563439000) ^ 0x5D145AA6);
					continue;
				case 7u:
					result = true;
					num = ((int)num2 * -1306045921) ^ 0x22E66C87;
					continue;
				case 6u:
					GClass4.smethod_3(GClass4.smethod_2("A file is missing: '", string_0, "'."), "The Omegle Game", (MessageBoxButtons)0, (MessageBoxIcon)16);
					num = 1970277725;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (!GClass4.smethod_1(string_0))
					{
						num3 = -1527489169;
						num4 = -1527489169;
					}
					else
					{
						num3 = -1520512474;
						num4 = -1520512474;
					}
					num = num3 ^ ((int)num2 * -1060397706);
					continue;
				}
				case 4u:
					num = ((int)num2 * -1587874036) ^ -435903523;
					continue;
				case 1u:
					GClass4.smethod_4();
					num = (int)(num2 * 1152549817) ^ -616848378;
					continue;
				case 0u:
					result = false;
					num = (int)(num2 * 1453596675) ^ -1783216891;
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

	static bool smethod_1(string string_0)
	{
		return File.Exists(string_0);
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
