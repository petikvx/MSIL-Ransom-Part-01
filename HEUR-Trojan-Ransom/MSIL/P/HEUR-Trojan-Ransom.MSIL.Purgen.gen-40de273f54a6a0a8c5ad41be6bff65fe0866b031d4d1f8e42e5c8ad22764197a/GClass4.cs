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
		bool flag = default(bool);
		while (true)
		{
			int num = 1921159804;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6C02EEE9u) % 11u)
				{
				case 10u:
					GClass4.smethod_3(GClass4.smethod_2("A file is missing: '", string_0, "'."), "The Omegle Game", (MessageBoxButtons)0, (MessageBoxIcon)16);
					num = 1855246894;
					continue;
				case 9u:
					result = false;
					num = ((int)num2 * -2078158716) ^ -1486810865;
					continue;
				case 8u:
					flag = GClass4.smethod_1(string_0);
					num = (int)((num2 * 1747854221) ^ 0x2B78167C);
					continue;
				case 7u:
					num = ((int)num2 * -74202857) ^ 0x40A0CE95;
					continue;
				case 6u:
					num = (int)((num2 * 526722725) ^ 0x4D551C80);
					continue;
				case 4u:
					num = ((int)num2 * -1057494600) ^ -687313317;
					continue;
				case 3u:
					result = true;
					num = (int)((num2 * 327088055) ^ 0x6BDD9B);
					continue;
				case 1u:
					GClass4.smethod_4();
					num = (int)(num2 * 95663358) ^ -616497233;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -93029299;
						num4 = -93029299;
					}
					else
					{
						num3 = -1676817090;
						num4 = -1676817090;
					}
					num = num3 ^ ((int)num2 * -2136592759);
					continue;
				}
				case 5u:
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
