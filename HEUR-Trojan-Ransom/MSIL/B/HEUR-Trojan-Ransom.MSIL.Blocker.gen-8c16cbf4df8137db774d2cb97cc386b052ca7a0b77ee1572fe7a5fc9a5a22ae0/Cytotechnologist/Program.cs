using System;
using System.Windows.Forms;

namespace Cytotechnologist;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		while (true)
		{
			int num = 668353587;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x30632B2u) % 5u)
				{
				case 3u:
					num = ((int)num2 * -317747772) ^ -2057943726;
					continue;
				case 1u:
					Application.SetCompatibleTextRenderingDefault(false);
					num = ((int)num2 * -1099075280) ^ -314175039;
					continue;
				case 0u:
					Application.Run((Form)(object)new Form1());
					num = ((int)num2 * -1745156181) ^ 0x32E4AAA8;
					continue;
				default:
					return;
				case 2u:
					break;
				case 4u:
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
