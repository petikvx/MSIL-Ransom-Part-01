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
			int num = -647793383;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEB709359u) % 7u)
				{
				case 6u:
					Application.Run((Form)(object)new Form1());
					num = ((int)num2 * -696418246) ^ 0x9F566B9;
					continue;
				case 5u:
					num = ((int)num2 * -1392776248) ^ -1835273045;
					continue;
				case 3u:
					num = (int)((num2 * 1730802268) ^ 0x6349C9C0);
					continue;
				case 2u:
					Application.SetCompatibleTextRenderingDefault(false);
					num = ((int)num2 * -1260936917) ^ -1559927808;
					continue;
				case 1u:
					Application.EnableVisualStyles();
					num = (int)((num2 * 930723164) ^ 0x77AB7455);
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
