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
			int num = 1305453714;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5BE12F5Fu) % 5u)
				{
				case 4u:
					Application.Run((Form)(object)new Form1());
					num = ((int)num2 * -854310541) ^ 0x6C15FCEA;
					continue;
				case 3u:
					num = ((int)num2 * -2068410875) ^ 0x7CD3110B;
					continue;
				case 2u:
					Application.SetCompatibleTextRenderingDefault(false);
					num = (int)(num2 * 458773711) ^ -416840060;
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
