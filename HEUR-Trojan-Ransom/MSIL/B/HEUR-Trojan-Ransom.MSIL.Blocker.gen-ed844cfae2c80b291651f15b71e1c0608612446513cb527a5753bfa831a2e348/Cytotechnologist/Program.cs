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
			int num = -675614668;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9D9CF1F6u) % 4u)
				{
				case 2u:
					Application.EnableVisualStyles();
					num = (int)(num2 * 1277120268) ^ -1327502885;
					continue;
				case 1u:
					Application.SetCompatibleTextRenderingDefault(false);
					Application.Run((Form)(object)new Form1());
					num = (int)((num2 * 142165393) ^ 0x674BCBF4);
					continue;
				default:
					return;
				case 0u:
					break;
				case 3u:
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
