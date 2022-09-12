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
			int num = 41866448;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3A2CC605u) % 4u)
				{
				case 3u:
					Application.Run((Form)(object)new Form1());
					num = (int)((num2 * 70952734) ^ 0x274D4E9D);
					continue;
				case 1u:
					Application.SetCompatibleTextRenderingDefault(false);
					num = ((int)num2 * -1864296447) ^ 0xAFEB647;
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
