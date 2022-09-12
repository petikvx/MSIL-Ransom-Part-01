using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

public class GClass3
{
	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static bool smethod_0(string string_0)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		bool flag = GClass3.smethod_1(string_0);
		bool result = default(bool);
		while (true)
		{
			int num = -135418331;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x916EB4E4u) % 8u)
				{
				case 6u:
					GClass3.smethod_3(GClass3.smethod_2("A directory is missing: '", string_0, "'."), "The Omegle Game", (MessageBoxButtons)0, (MessageBoxIcon)16);
					num = -2121418767;
					continue;
				case 5u:
					GClass3.smethod_4();
					num = (int)((num2 * 783498551) ^ 0x55EC5F47);
					continue;
				case 4u:
					result = true;
					num = (int)((num2 * 372579354) ^ 0x39E0D57B);
					continue;
				case 3u:
					num = ((int)num2 * -1517256643) ^ -1224578428;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = 1862763281;
						num4 = 1862763281;
					}
					else
					{
						num3 = 1494008915;
						num4 = 1494008915;
					}
					num = num3 ^ ((int)num2 * -1559541039);
					continue;
				}
				case 0u:
					result = false;
					num = ((int)num2 * -516821593) ^ 0x45A030A7;
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
