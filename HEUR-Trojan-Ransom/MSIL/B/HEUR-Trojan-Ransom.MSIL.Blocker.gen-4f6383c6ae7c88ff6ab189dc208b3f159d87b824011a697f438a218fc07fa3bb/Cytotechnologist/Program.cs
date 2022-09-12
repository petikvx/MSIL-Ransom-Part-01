using System;
using System.Windows.Forms;

namespace Cytotechnologist;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		while (true)
		{
			int num = -1414584274;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC4E4AE4Eu) % 7u)
				{
				case 6u:
					num = ((int)num2 * -1023313734) ^ -1555234347;
					continue;
				case 5u:
					Application.SetCompatibleTextRenderingDefault(false);
					num = ((int)num2 * -426151030) ^ -1294162365;
					continue;
				case 4u:
					Application.EnableVisualStyles();
					num = (int)(num2 * 280145931) ^ -177039399;
					continue;
				case 2u:
					num = (int)((num2 * 1289732321) ^ 0x5B01A888);
					continue;
				case 1u:
					Application.Run((Form)(object)new Form1());
					num = (int)((num2 * 463890570) ^ 0x1E084B4E);
					continue;
				default:
					return;
				case 3u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	static void smethod_0()
	{
		Application.EnableVisualStyles();
	}

	static void smethod_1(bool bool_0)
	{
		Application.SetCompatibleTextRenderingDefault(bool_0);
	}

	static void smethod_2(Form form_0)
	{
		Application.Run(form_0);
	}
}
