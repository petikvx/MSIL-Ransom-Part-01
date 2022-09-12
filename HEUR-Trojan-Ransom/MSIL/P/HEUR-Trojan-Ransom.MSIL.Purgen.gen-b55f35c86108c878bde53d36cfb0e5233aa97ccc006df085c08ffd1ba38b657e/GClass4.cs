using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

public class GClass4
{
	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static bool smethod_0(string string_0)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		bool result = default(bool);
		while (true)
		{
			int num = 1857221041;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5620AA22u) % 8u)
				{
				case 7u:
					GClass4.smethod_3(GClass4.smethod_2("A file is missing: '", string_0, "'."), "The Omegle Game", (MessageBoxButtons)0, (MessageBoxIcon)16);
					GClass4.smethod_4();
					result = false;
					num = ((int)num2 * -128214637) ^ -137643191;
					continue;
				case 6u:
					num = (int)(num2 * 1482378012) ^ -611509209;
					continue;
				case 4u:
					result = true;
					num = ((int)num2 * -1503156993) ^ -1897294076;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (GClass4.smethod_1(string_0))
					{
						num3 = -1103783855;
						num4 = -1103783855;
					}
					else
					{
						num3 = -731005108;
						num4 = -731005108;
					}
					num = num3 ^ (int)(num2 * 1276015597);
					continue;
				}
				case 2u:
					num = ((int)num2 * -1534276737) ^ -1658457271;
					continue;
				case 1u:
					num = 172631037;
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
