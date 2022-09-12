using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

public class GClass4
{
	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static bool smethod_0(string string_0)
	{
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		if (GClass4.smethod_1(string_0))
		{
			goto IL_001c;
		}
		goto IL_0097;
		IL_0097:
		GClass4.smethod_3(GClass4.smethod_2("A file is missing: '", string_0, "'."), "The Omegle Game", (MessageBoxButtons)0, (MessageBoxIcon)16);
		int num = 82230221;
		goto IL_0066;
		IL_0066:
		bool result = default(bool);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x42B3C755u) % 8u)
			{
			case 6u:
				num = (int)(num2 * 1065922803) ^ -552675419;
				continue;
			case 5u:
				break;
			case 4u:
				num = (int)(num2 * 2073348879) ^ -471055912;
				continue;
			case 3u:
				result = true;
				num = ((int)num2 * -1301520602) ^ 0x58217191;
				continue;
			case 1u:
				result = false;
				num = (int)(num2 * 799620733) ^ -970186686;
				continue;
			case 0u:
				GClass4.smethod_4();
				num = (int)((num2 * 806642890) ^ 0x3240F3B9);
				continue;
			case 7u:
				goto IL_0097;
			default:
				return result;
			}
			break;
		}
		goto IL_001c;
		IL_001c:
		num = 34522182;
		goto IL_0066;
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
