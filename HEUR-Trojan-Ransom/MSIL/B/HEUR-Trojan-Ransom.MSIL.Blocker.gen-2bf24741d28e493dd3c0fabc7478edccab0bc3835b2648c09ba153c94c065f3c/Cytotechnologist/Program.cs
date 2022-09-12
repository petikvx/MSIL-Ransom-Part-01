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
			int num = -1022474872;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBD89F883u) % 5u)
				{
				case 4u:
					Application.SetCompatibleTextRenderingDefault(false);
					Application.Run((Form)(object)new Form1());
					num = ((int)num2 * -2032501020) ^ -914673590;
					continue;
				case 3u:
					num = (int)((num2 * 1654042398) ^ 0x388EBEF7);
					continue;
				case 1u:
					num = ((int)num2 * -1784547457) ^ -1707495375;
					continue;
				default:
					return;
				case 2u:
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
