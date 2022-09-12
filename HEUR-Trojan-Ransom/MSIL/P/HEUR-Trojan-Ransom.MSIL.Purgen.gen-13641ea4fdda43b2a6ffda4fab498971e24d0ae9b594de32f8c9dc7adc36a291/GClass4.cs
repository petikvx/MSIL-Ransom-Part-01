using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

public class GClass4
{
	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static bool smethod_0(string string_0)
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		bool flag = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = -1010629901;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBA319756u) % 11u)
				{
				case 10u:
					num = (int)((num2 * 1038118970) ^ 0x3371C129);
					continue;
				case 8u:
					num = (int)(num2 * 761805265) ^ -1570082392;
					continue;
				case 7u:
					flag = GClass4.smethod_1(string_0);
					num = (int)(num2 * 1427249719) ^ -1902874935;
					continue;
				case 6u:
					result = false;
					num = ((int)num2 * -1142226224) ^ -404304784;
					continue;
				case 5u:
					GClass4.smethod_4();
					num = ((int)num2 * -1293816365) ^ 0x76B9B7E8;
					continue;
				case 4u:
					GClass4.smethod_3(GClass4.smethod_2("A file is missing: '", string_0, "'."), "The Omegle Game", (MessageBoxButtons)0, (MessageBoxIcon)16);
					num = (int)((num2 * 1008665365) ^ 0x41F15D6A);
					continue;
				case 3u:
					result = true;
					num = ((int)num2 * -884425140) ^ -377608698;
					continue;
				case 1u:
					num = -82132534;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -825540398;
						num4 = -825540398;
					}
					else
					{
						num3 = -280240320;
						num4 = -280240320;
					}
					num = num3 ^ ((int)num2 * -668703859);
					continue;
				}
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
