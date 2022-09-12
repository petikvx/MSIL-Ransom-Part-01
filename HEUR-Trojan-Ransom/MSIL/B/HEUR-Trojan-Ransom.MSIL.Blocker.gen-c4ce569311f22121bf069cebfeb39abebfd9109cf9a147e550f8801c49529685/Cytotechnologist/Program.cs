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
			int num = 782954526;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2D8E7BDDu) % 6u)
				{
				case 5u:
					num = (int)((num2 * 420738969) ^ 0x51C806F6);
					continue;
				case 4u:
					Application.SetCompatibleTextRenderingDefault(false);
					num = (int)((num2 * 364702823) ^ 0x2095B15D);
					continue;
				case 1u:
					Application.EnableVisualStyles();
					num = ((int)num2 * -1288802471) ^ 0x8D6D87C;
					continue;
				case 0u:
					Application.Run((Form)(object)new Form1());
					num = (int)(num2 * 2076392402) ^ -1412526212;
					continue;
				default:
					return;
				case 3u:
					break;
				case 2u:
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
