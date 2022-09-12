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
			int num = 32689077;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x272BB9Eu) % 4u)
				{
				case 3u:
					Application.EnableVisualStyles();
					num = ((int)num2 * -1928993453) ^ -1391869847;
					continue;
				case 2u:
					Application.SetCompatibleTextRenderingDefault(false);
					Application.Run((Form)(object)new Form1());
					num = (int)((num2 * 623361373) ^ 0x559DE0E9);
					continue;
				default:
					return;
				case 0u:
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
