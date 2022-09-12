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
			int num = 1728086340;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x16A198DAu) % 3u)
				{
				case 1u:
					goto IL_0007;
				case 2u:
					break;
				default:
					Application.Run((Form)(object)new Form1());
					return;
				}
				break;
				IL_0007:
				Application.SetCompatibleTextRenderingDefault(false);
				num = ((int)num2 * -255003307) ^ 0x7F8F4CFC;
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
