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
			int num = 71468910;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3E95FA1Fu) % 6u)
				{
				case 5u:
					Application.Run((Form)(object)new Form1());
					num = ((int)num2 * -360635463) ^ 0x49CE2B08;
					continue;
				case 3u:
					Application.SetCompatibleTextRenderingDefault(false);
					num = (int)(num2 * 763859103) ^ -802682809;
					continue;
				case 2u:
					num = (int)((num2 * 1514773087) ^ 0x52615E34);
					continue;
				case 1u:
					Application.EnableVisualStyles();
					num = (int)(num2 * 1839633703) ^ -1631502436;
					continue;
				default:
					return;
				case 4u:
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
