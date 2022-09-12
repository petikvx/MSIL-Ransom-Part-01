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
			int num = -273404888;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC2D2CA86u) % 6u)
				{
				case 5u:
					Application.Run((Form)(object)new Form1());
					num = (int)((num2 * 108757228) ^ 0x58FA383F);
					continue;
				case 4u:
					num = (int)((num2 * 1563440272) ^ 0x71CDFFF7);
					continue;
				case 3u:
					Application.SetCompatibleTextRenderingDefault(false);
					num = (int)(num2 * 1934085517) ^ -1167732803;
					continue;
				case 2u:
					num = ((int)num2 * -1509645146) ^ 0x76C47CCD;
					continue;
				default:
					return;
				case 0u:
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
