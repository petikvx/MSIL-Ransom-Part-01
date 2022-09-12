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
			int num = 974569312;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6C7B2061u) % 6u)
				{
				case 4u:
					num = ((int)num2 * -2130519139) ^ 0x31699944;
					continue;
				case 3u:
					Application.Run((Form)(object)new Form1());
					num = (int)(num2 * 1057632065) ^ -1059645282;
					continue;
				case 1u:
					Application.EnableVisualStyles();
					Application.SetCompatibleTextRenderingDefault(false);
					num = ((int)num2 * -1571787338) ^ 0x588108D;
					continue;
				case 0u:
					num = (int)((num2 * 1978855794) ^ 0x3E7170AD);
					continue;
				default:
					return;
				case 5u:
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
