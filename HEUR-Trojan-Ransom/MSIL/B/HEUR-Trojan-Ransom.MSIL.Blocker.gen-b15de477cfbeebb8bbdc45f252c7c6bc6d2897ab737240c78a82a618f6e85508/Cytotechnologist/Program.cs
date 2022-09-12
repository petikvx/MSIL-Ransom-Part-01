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
			int num = 137510203;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x14203E4Eu) % 6u)
				{
				case 5u:
					num = (int)((num2 * 448748906) ^ 0x2B6D745F);
					continue;
				case 3u:
					Application.SetCompatibleTextRenderingDefault(false);
					num = (int)(num2 * 748467255) ^ -163993151;
					continue;
				case 1u:
					Application.EnableVisualStyles();
					num = (int)((num2 * 1355655268) ^ 0x7F7938F5);
					continue;
				case 0u:
					num = (int)(num2 * 595011683) ^ -1017371892;
					continue;
				case 4u:
					break;
				default:
					Application.Run((Form)(object)new Form1());
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
