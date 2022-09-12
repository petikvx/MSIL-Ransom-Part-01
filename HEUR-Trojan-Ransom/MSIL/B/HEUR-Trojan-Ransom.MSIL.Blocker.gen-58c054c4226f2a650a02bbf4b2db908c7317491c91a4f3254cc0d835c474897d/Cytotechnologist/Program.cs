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
			int num = -226917254;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x82E049B3u) % 7u)
				{
				case 6u:
					Application.SetCompatibleTextRenderingDefault(false);
					num = ((int)num2 * -379398967) ^ -1517844590;
					continue;
				case 4u:
					Application.EnableVisualStyles();
					num = (int)(num2 * 1599728750) ^ -1462260619;
					continue;
				case 3u:
					num = (int)((num2 * 466634440) ^ 0x2C64CA8B);
					continue;
				case 2u:
					Application.Run((Form)(object)new Form1());
					num = (int)((num2 * 984885118) ^ 0x70C5B247);
					continue;
				case 0u:
					num = (int)((num2 * 1826199601) ^ 0x7F6D8ADF);
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
