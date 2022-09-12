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
			int num = -1567964021;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD0C4455Bu) % 6u)
				{
				case 5u:
					Application.SetCompatibleTextRenderingDefault(false);
					num = (int)((num2 * 1965956402) ^ 0x732DB256);
					continue;
				case 4u:
					num = (int)(num2 * 1170160814) ^ -2127978922;
					continue;
				case 2u:
					Application.Run((Form)(object)new Form1());
					num = (int)((num2 * 817433566) ^ 0x2898EBE2);
					continue;
				case 1u:
					num = (int)((num2 * 2001760080) ^ 0x5040D745);
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
