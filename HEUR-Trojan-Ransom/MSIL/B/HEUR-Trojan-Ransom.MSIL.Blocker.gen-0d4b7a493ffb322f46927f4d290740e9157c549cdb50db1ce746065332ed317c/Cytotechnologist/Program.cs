using System;
using System.Windows.Forms;

namespace Cytotechnologist;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		while (true)
		{
			int num = 2039150195;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD1D7E8Du) % 4u)
				{
				case 2u:
					num = (int)(num2 * 1711885718) ^ -726578744;
					continue;
				case 1u:
					Application.Run((Form)(object)new Form1());
					num = (int)(num2 * 1671823330) ^ -1108942668;
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
