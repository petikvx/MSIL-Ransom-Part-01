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
			int num = -1875148686;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x956B46BBu) % 5u)
				{
				case 4u:
					num = ((int)num2 * -142180661) ^ 0x2783F23D;
					continue;
				case 3u:
					num = (int)(num2 * 590849087) ^ -807152066;
					continue;
				case 1u:
					Application.SetCompatibleTextRenderingDefault(false);
					num = ((int)num2 * -1371157975) ^ -111851463;
					continue;
				case 0u:
					break;
				default:
					Application.Run((Form)(object)new Form1());
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
