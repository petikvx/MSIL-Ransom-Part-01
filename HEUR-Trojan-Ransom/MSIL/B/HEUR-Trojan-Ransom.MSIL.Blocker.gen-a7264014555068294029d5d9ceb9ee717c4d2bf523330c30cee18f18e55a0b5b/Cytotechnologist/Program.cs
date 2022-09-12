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
			int num = -1187722562;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFD98BE01u) % 6u)
				{
				case 5u:
					Application.SetCompatibleTextRenderingDefault(false);
					num = ((int)num2 * -1229740609) ^ -509162476;
					continue;
				case 4u:
					Application.Run((Form)(object)new Form1());
					num = ((int)num2 * -2064042968) ^ 0x250131A;
					continue;
				case 2u:
					num = (int)(num2 * 488479297) ^ -1793296643;
					continue;
				case 1u:
					num = ((int)num2 * -1831743386) ^ 0x79AF75C;
					continue;
				default:
					return;
				case 0u:
					break;
				case 3u:
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
