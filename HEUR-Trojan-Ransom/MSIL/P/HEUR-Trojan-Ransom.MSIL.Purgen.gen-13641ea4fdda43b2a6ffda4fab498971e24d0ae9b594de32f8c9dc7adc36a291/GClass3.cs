using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

public class GClass3
{
	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static bool smethod_0(string string_0)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		bool result = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -1094909094;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9A5D8505u) % 9u)
				{
				case 8u:
					result = false;
					num = (int)(num2 * 23370811) ^ -693985964;
					continue;
				case 7u:
					num = (int)((num2 * 1192716105) ^ 0x72D07B1A);
					continue;
				case 6u:
					num = (int)(num2 * 529951017) ^ -147585368;
					continue;
				case 5u:
					result = true;
					num = (int)(num2 * 1083526522) ^ -1473745381;
					continue;
				case 3u:
					flag = GClass3.smethod_1(string_0);
					num = (int)((num2 * 438930179) ^ 0x4E26FED6);
					continue;
				case 2u:
					GClass3.smethod_3(GClass3.smethod_2("A directory is missing: '", string_0, "'."), "The Omegle Game", (MessageBoxButtons)0, (MessageBoxIcon)16);
					GClass3.smethod_4();
					num = -1097597662;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -1588673111;
						num4 = -1588673111;
					}
					else
					{
						num3 = -1544154980;
						num4 = -1544154980;
					}
					num = num3 ^ ((int)num2 * -587194242);
					continue;
				}
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
