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
			int num = -966852314;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB4CB8C45u) % 7u)
				{
				case 5u:
					num = ((int)num2 * -185214027) ^ 0x65C08C25;
					continue;
				case 4u:
					Application.Run((Form)(object)new Form1());
					num = ((int)num2 * -338483363) ^ 0x733D5AF2;
					continue;
				case 3u:
					Application.SetCompatibleTextRenderingDefault(false);
					num = ((int)num2 * -857038964) ^ 0x3F243365;
					continue;
				case 2u:
					Application.EnableVisualStyles();
					num = ((int)num2 * -1770622356) ^ 0x5C3063CE;
					continue;
				case 1u:
					num = ((int)num2 * -583311585) ^ 0x148D832;
					continue;
				default:
					return;
				case 0u:
					break;
				case 6u:
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
