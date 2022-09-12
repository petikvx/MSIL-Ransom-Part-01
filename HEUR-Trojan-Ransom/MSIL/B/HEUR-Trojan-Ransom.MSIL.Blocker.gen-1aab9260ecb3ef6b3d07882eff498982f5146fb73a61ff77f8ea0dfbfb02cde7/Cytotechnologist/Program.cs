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
			int num = -154043993;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD0DB8B36u) % 7u)
				{
				case 6u:
					num = (int)(num2 * 1888765287) ^ -71696048;
					continue;
				case 4u:
					Application.SetCompatibleTextRenderingDefault(false);
					num = ((int)num2 * -1622349303) ^ -2099450110;
					continue;
				case 3u:
					num = ((int)num2 * -847813697) ^ 0x240DAB05;
					continue;
				case 2u:
					Application.EnableVisualStyles();
					num = ((int)num2 * -694621233) ^ -444866265;
					continue;
				case 0u:
					Application.Run((Form)(object)new Form1());
					num = ((int)num2 * -12001437) ^ 0x3422F2E0;
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
