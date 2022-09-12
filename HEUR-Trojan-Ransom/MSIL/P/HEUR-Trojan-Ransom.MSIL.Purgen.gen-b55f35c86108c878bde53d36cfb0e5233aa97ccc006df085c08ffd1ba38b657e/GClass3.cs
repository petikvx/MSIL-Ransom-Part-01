using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

public class GClass3
{
	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static bool smethod_0(string string_0)
	{
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		bool flag = GClass3.smethod_1(string_0);
		bool result = default(bool);
		while (true)
		{
			int num = -703511241;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA3FE6250u) % 11u)
				{
				case 10u:
					num = -931975917;
					continue;
				case 9u:
					result = true;
					num = (int)(num2 * 1211550697) ^ -721262637;
					continue;
				case 8u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 400267871;
						num4 = 400267871;
					}
					else
					{
						num3 = 321176682;
						num4 = 321176682;
					}
					num = num3 ^ ((int)num2 * -1999786366);
					continue;
				}
				case 7u:
					GClass3.smethod_3(GClass3.smethod_2("A directory is missing: '", string_0, "'."), "The Omegle Game", (MessageBoxButtons)0, (MessageBoxIcon)16);
					num = (int)((num2 * 1188418740) ^ 0x9484B40);
					continue;
				case 6u:
					num = (int)(num2 * 1138967884) ^ -1256552188;
					continue;
				case 5u:
					result = false;
					num = ((int)num2 * -829941005) ^ -1195567497;
					continue;
				case 4u:
					num = (int)((num2 * 932903416) ^ 0x5F2F72F9);
					continue;
				case 3u:
					GClass3.smethod_4();
					num = ((int)num2 * -632241466) ^ 0x2D084EC9;
					continue;
				case 1u:
					num = (int)(num2 * 825558058) ^ -150328905;
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
