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
			int num = 478016372;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x413B1B42u) % 7u)
				{
				case 6u:
					Application.Run((Form)(object)new Form1());
					num = ((int)num2 * -1742526391) ^ -61167551;
					continue;
				case 4u:
					Application.EnableVisualStyles();
					num = (int)((num2 * 599882237) ^ 0xCE18714);
					continue;
				case 3u:
					num = ((int)num2 * -2145789153) ^ 0x5CD3F2E5;
					continue;
				case 2u:
					Application.SetCompatibleTextRenderingDefault(false);
					num = (int)(num2 * 264510343) ^ -1754863012;
					continue;
				case 0u:
					num = ((int)num2 * -627365031) ^ 0x246DD7AD;
					continue;
				default:
					return;
				case 5u:
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
