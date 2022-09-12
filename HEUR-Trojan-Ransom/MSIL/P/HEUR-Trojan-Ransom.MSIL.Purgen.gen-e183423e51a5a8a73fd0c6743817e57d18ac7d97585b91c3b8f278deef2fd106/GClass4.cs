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
			int num = 1210372485;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x57A14DCFu) % 10u)
				{
				case 9u:
					GClass4.smethod_3(GClass4.smethod_2("A file is missing: '", string_0, "'."), "The Omegle Game", (MessageBoxButtons)0, (MessageBoxIcon)16);
					GClass4.smethod_4();
					num = ((int)num2 * -82403011) ^ 0x339C1372;
					continue;
				case 8u:
					num = (int)((num2 * 186775421) ^ 0x3D3C02E5);
					continue;
				case 7u:
					result = true;
					num = (int)(num2 * 872364042) ^ -2041296916;
					continue;
				case 6u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1940918160;
						num4 = -1940918160;
					}
					else
					{
						num3 = -1039543878;
						num4 = -1039543878;
					}
					num = num3 ^ (int)(num2 * 220768935);
					continue;
				}
				case 4u:
					flag = GClass4.smethod_1(string_0);
					num = (int)((num2 * 89071218) ^ 0x6BC5C939);
					continue;
				case 3u:
					num = 484120052;
					continue;
				case 2u:
					result = false;
					num = ((int)num2 * -760263729) ^ -1952565525;
					continue;
				case 1u:
					num = (int)((num2 * 278259274) ^ 0x1D6C8A5D);
					continue;
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
