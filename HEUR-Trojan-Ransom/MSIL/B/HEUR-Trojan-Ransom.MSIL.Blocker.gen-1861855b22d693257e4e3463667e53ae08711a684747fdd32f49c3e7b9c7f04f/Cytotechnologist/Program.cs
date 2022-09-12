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
			int num = -1108387172;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x96B1F1DAu) % 5u)
				{
				case 3u:
					Application.EnableVisualStyles();
					Application.SetCompatibleTextRenderingDefault(false);
					num = ((int)num2 * -1632144493) ^ -1879756243;
					continue;
				case 2u:
					num = ((int)num2 * -1558685915) ^ 0x356337FC;
					continue;
				case 1u:
					Application.Run((Form)(object)new Form1());
					num = ((int)num2 * -174008819) ^ 0x13770E53;
					continue;
				default:
					return;
				case 0u:
					break;
				case 4u:
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
