using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

public class GClass3
{
	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static bool smethod_0(string string_0)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		bool flag = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num = -758710197;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD5EAD2DEu) % 11u)
				{
				case 10u:
					num = ((int)num2 * -1220478042) ^ 0x64A8302A;
					continue;
				case 9u:
					flag = GClass3.smethod_1(string_0);
					num = (int)(num2 * 1159518470) ^ -1724348876;
					continue;
				case 8u:
					num = -132717154;
					continue;
				case 7u:
					result = false;
					num = ((int)num2 * -647767811) ^ -967484326;
					continue;
				case 5u:
					GClass3.smethod_3(GClass3.smethod_2("A directory is missing: '", string_0, "'."), "The Omegle Game", (MessageBoxButtons)0, (MessageBoxIcon)16);
					num = (int)((num2 * 43724069) ^ 0x36373EFE);
					continue;
				case 4u:
					GClass3.smethod_4();
					num = (int)((num2 * 142383933) ^ 0x5F7D1A5F);
					continue;
				case 3u:
					result = true;
					num = ((int)num2 * -933415680) ^ 0x182398EF;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -1854222808;
						num4 = -1854222808;
					}
					else
					{
						num3 = -494736026;
						num4 = -494736026;
					}
					num = num3 ^ (int)(num2 * 896409179);
					continue;
				}
				case 0u:
					num = ((int)num2 * -1637024073) ^ -693809765;
					continue;
				case 6u:
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
