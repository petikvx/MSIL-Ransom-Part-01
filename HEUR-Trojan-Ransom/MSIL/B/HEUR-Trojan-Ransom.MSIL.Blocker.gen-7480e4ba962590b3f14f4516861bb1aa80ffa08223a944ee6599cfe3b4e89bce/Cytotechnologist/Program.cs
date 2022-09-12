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
			int num = -460454135;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBE7F50A9u) % 6u)
				{
				case 4u:
					num = (int)((num2 * 1626920436) ^ 0x1D355932);
					continue;
				case 3u:
					Application.Run((Form)(object)new Form1());
					num = (int)((num2 * 302578364) ^ 0x575AA5A3);
					continue;
				case 2u:
					Application.SetCompatibleTextRenderingDefault(false);
					num = ((int)num2 * -802864294) ^ 0x4B53203E;
					continue;
				case 1u:
					num = (int)(num2 * 467094502) ^ -1792701592;
					continue;
				default:
					return;
				case 0u:
					break;
				case 5u:
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
