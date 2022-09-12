using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

public class GClass3
{
	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static bool smethod_0(string string_0)
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		if (GClass3.smethod_1(string_0))
		{
			goto IL_001b;
		}
		goto IL_0081;
		IL_0081:
		GClass3.smethod_3(GClass3.smethod_2("A directory is missing: '", string_0, "'."), "The Omegle Game", (MessageBoxButtons)0, (MessageBoxIcon)16);
		int num = 1514326532;
		goto IL_0054;
		IL_0054:
		bool result = default(bool);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xD233EB1u) % 7u)
			{
			case 6u:
				result = true;
				num = (int)(num2 * 427567846) ^ -1744981651;
				continue;
			case 5u:
				break;
			case 4u:
				result = false;
				num = (int)((num2 * 331037600) ^ 0x2A4C95B4);
				continue;
			case 3u:
				GClass3.smethod_4();
				num = (int)((num2 * 1900191923) ^ 0x4E73EC8);
				continue;
			case 2u:
				num = ((int)num2 * -194408086) ^ 0x41C6550C;
				continue;
			case 0u:
				goto IL_0081;
			default:
				return result;
			}
			break;
		}
		goto IL_001b;
		IL_001b:
		num = 937648553;
		goto IL_0054;
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
