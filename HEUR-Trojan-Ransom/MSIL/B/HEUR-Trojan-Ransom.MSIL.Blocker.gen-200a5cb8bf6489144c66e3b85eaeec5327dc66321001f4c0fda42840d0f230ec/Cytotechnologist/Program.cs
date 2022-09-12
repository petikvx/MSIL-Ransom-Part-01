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
			int num = 1282738109;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x21002F3Du) % 5u)
				{
				case 4u:
					num = (int)((num2 * 2087455633) ^ 0x54CC3B5C);
					continue;
				case 3u:
					Application.Run((Form)(object)new Form1());
					num = ((int)num2 * -1074718655) ^ 0x16F376E;
					continue;
				case 0u:
					Application.SetCompatibleTextRenderingDefault(false);
					num = (int)(num2 * 832807358) ^ -1984108198;
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
