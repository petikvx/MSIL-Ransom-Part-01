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
			int num = -1410526130;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCEFD44ADu) % 5u)
				{
				case 4u:
					Application.EnableVisualStyles();
					num = (int)(num2 * 2053201511) ^ -1011758199;
					continue;
				case 2u:
					Application.SetCompatibleTextRenderingDefault(false);
					num = (int)((num2 * 907464889) ^ 0x77CEFDC5);
					continue;
				case 0u:
					Application.Run((Form)(object)new Form1());
					num = (int)(num2 * 514433805) ^ -1730230784;
					continue;
				default:
					return;
				case 3u:
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
