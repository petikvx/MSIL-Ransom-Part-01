using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

public class GClass4
{
	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static bool smethod_0(string string_0)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (GClass4.smethod_1(string_0))
		{
			goto IL_0061;
		}
		goto IL_00a2;
		IL_00a2:
		int num = 989986721;
		goto IL_0075;
		IL_0075:
		bool result = default(bool);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x57063A8Eu) % 7u)
			{
			case 6u:
				result = true;
				num = ((int)num2 * -922964616) ^ -116317448;
				continue;
			case 5u:
				GClass4.smethod_3(GClass4.smethod_2("A file is missing: '", string_0, "'."), "The Omegle Game", (MessageBoxButtons)0, (MessageBoxIcon)16);
				GClass4.smethod_4();
				num = ((int)num2 * -1899668712) ^ -1996345495;
				continue;
			case 4u:
				result = false;
				num = (int)(num2 * 502522769) ^ -32915690;
				continue;
			case 3u:
				break;
			case 0u:
				num = ((int)num2 * -1169612995) ^ 0x3E49A823;
				continue;
			case 1u:
				goto IL_00a2;
			default:
				return result;
			}
			break;
		}
		goto IL_0061;
		IL_0061:
		num = 819149752;
		goto IL_0075;
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
