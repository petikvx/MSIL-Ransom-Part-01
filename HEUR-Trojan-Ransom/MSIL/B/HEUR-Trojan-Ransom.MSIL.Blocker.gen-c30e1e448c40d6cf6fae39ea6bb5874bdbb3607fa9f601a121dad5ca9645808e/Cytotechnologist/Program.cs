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
			int num = -2019503411;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9837920Au) % 4u)
				{
				case 3u:
					Application.EnableVisualStyles();
					num = (int)(num2 * 1784119834) ^ -633926620;
					continue;
				case 0u:
					num = (int)((num2 * 500318889) ^ 0x6E1084B);
					continue;
				case 2u:
					break;
				default:
					Application.SetCompatibleTextRenderingDefault(false);
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
