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
			int num = 638528366;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x72D1E1E9u) % 6u)
				{
				case 4u:
					Application.Run((Form)(object)new Form1());
					num = ((int)num2 * -91013306) ^ -417510763;
					continue;
				case 2u:
					num = (int)(num2 * 66580554) ^ -280778191;
					continue;
				case 1u:
					Application.EnableVisualStyles();
					Application.SetCompatibleTextRenderingDefault(false);
					num = (int)((num2 * 21601893) ^ 0x5DCE1456);
					continue;
				case 0u:
					num = (int)(num2 * 1030570739) ^ -997334892;
					continue;
				default:
					return;
				case 5u:
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
