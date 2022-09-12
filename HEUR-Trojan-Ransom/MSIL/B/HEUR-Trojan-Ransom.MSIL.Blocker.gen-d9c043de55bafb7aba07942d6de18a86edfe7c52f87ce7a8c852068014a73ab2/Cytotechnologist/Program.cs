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
			int num = 857234235;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1729F50Cu) % 5u)
				{
				case 4u:
					Application.SetCompatibleTextRenderingDefault(false);
					num = ((int)num2 * -1576178057) ^ -1430719361;
					continue;
				case 2u:
					num = ((int)num2 * -2080660902) ^ -1646677524;
					continue;
				case 0u:
					Application.Run((Form)(object)new Form1());
					num = (int)(num2 * 400735674) ^ -1792266675;
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
