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
			int num = -347817027;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDEB81182u) % 5u)
				{
				case 4u:
					Application.Run((Form)(object)new Form1());
					num = ((int)num2 * -809755620) ^ 0x5EE6BDF3;
					continue;
				case 3u:
					Application.EnableVisualStyles();
					Application.SetCompatibleTextRenderingDefault(false);
					num = (int)((num2 * 1378288046) ^ 0x565FD454);
					continue;
				case 1u:
					num = ((int)num2 * -1005583406) ^ -468323312;
					continue;
				default:
					return;
				case 0u:
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
