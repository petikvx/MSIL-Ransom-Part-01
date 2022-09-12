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
			int num = -522616505;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAC8EC941u) % 6u)
				{
				case 5u:
					Application.Run((Form)(object)new Form1());
					num = (int)((num2 * 867537686) ^ 0x2A95505C);
					continue;
				case 4u:
					Application.EnableVisualStyles();
					num = ((int)num2 * -1343048864) ^ 0x96DE7FA;
					continue;
				case 3u:
					num = ((int)num2 * -950546243) ^ 0x7BC5476E;
					continue;
				case 0u:
					Application.SetCompatibleTextRenderingDefault(false);
					num = (int)((num2 * 556373650) ^ 0x3B1EBFCA);
					continue;
				default:
					return;
				case 2u:
					break;
				case 1u:
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
