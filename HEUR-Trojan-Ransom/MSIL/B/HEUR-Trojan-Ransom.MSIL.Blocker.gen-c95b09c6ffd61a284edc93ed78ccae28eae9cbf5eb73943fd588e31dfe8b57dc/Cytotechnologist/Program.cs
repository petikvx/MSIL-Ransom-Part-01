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
			int num = -565904762;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF5F5B0C7u) % 4u)
				{
				case 2u:
					Application.SetCompatibleTextRenderingDefault(false);
					num = ((int)num2 * -1081302938) ^ -248288092;
					continue;
				case 1u:
					Application.EnableVisualStyles();
					num = ((int)num2 * -844453166) ^ 0x7D02FE3B;
					continue;
				case 0u:
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
