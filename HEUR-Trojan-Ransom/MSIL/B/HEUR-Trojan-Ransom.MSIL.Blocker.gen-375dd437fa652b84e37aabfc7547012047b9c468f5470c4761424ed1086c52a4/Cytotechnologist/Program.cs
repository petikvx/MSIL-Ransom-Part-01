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
			int num = 2100583893;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1DC74934u) % 4u)
				{
				case 3u:
					Application.SetCompatibleTextRenderingDefault(false);
					num = ((int)num2 * -1381066731) ^ -1154299577;
					continue;
				case 1u:
					Application.EnableVisualStyles();
					num = ((int)num2 * -2041712718) ^ 0x74FD3181;
					continue;
				case 2u:
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
