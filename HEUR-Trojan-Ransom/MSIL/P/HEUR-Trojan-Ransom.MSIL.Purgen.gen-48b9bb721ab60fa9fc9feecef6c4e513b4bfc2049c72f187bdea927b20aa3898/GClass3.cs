using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

public class GClass3
{
	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static bool smethod_0(string string_0)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if (GClass3.smethod_1(string_0))
		{
			goto IL_001e;
		}
		goto IL_00a2;
		IL_00a2:
		int num = 1733338512;
		goto IL_0075;
		IL_0075:
		bool result = default(bool);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x582838E8u) % 7u)
			{
			case 6u:
				result = true;
				num = ((int)num2 * -152824239) ^ -1987516829;
				continue;
			case 5u:
				break;
			case 3u:
				num = (int)(num2 * 496765713) ^ -191895340;
				continue;
			case 1u:
				GClass3.smethod_3(GClass3.smethod_2("A directory is missing: '", string_0, "'."), "The Omegle Game", (MessageBoxButtons)0, (MessageBoxIcon)16);
				GClass3.smethod_4();
				num = (int)((num2 * 969263620) ^ 0x732EE57B);
				continue;
			case 0u:
				result = false;
				num = (int)(num2 * 879941613) ^ -1230731598;
				continue;
			case 2u:
				goto IL_00a2;
			default:
				return result;
			}
			break;
		}
		goto IL_001e;
		IL_001e:
		num = 1972542338;
		goto IL_0075;
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
