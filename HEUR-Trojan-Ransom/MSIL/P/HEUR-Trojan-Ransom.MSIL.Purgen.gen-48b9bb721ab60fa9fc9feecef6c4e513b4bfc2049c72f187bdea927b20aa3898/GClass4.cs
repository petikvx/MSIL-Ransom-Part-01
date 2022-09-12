using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

public class GClass4
{
	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static bool smethod_0(string string_0)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		bool result = default(bool);
		while (true)
		{
			int num = -1282789897;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8D5EEF57u) % 9u)
				{
				case 8u:
					num = -719569827;
					continue;
				case 7u:
				{
					int num3;
					int num4;
					if (GClass4.smethod_1(string_0))
					{
						num3 = -1484632460;
						num4 = -1484632460;
					}
					else
					{
						num3 = -1146722988;
						num4 = -1146722988;
					}
					num = num3 ^ (int)(num2 * 623903341);
					continue;
				}
				case 6u:
					num = (int)((num2 * 2040669311) ^ 0x3D61F4D3);
					continue;
				case 3u:
					result = true;
					num = (int)(num2 * 993155898) ^ -1808357586;
					continue;
				case 2u:
					result = false;
					num = ((int)num2 * -173258718) ^ 0x177C3BB0;
					continue;
				case 1u:
					num = ((int)num2 * -1084322303) ^ -1503068795;
					continue;
				case 0u:
					GClass4.smethod_3(GClass4.smethod_2("A file is missing: '", string_0, "'."), "The Omegle Game", (MessageBoxButtons)0, (MessageBoxIcon)16);
					GClass4.smethod_4();
					num = (int)((num2 * 1527696075) ^ 0x66EFACF5);
					continue;
				case 4u:
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
