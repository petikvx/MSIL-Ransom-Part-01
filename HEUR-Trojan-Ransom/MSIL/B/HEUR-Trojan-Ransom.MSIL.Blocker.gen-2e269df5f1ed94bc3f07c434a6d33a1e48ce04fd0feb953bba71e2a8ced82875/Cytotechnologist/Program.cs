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
			int num = -1647924408;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x91CE3A22u) % 6u)
				{
				case 5u:
					Application.SetCompatibleTextRenderingDefault(false);
					Application.Run((Form)(object)new Form1());
					num = (int)((num2 * 1130134696) ^ 0xB0FC641);
					continue;
				case 4u:
					Application.EnableVisualStyles();
					num = ((int)num2 * -1883343700) ^ -1174307279;
					continue;
				case 3u:
					num = (int)((num2 * 1756432383) ^ 0x64511D1D);
					continue;
				case 1u:
					num = ((int)num2 * -257703200) ^ 0x2FA90D53;
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
