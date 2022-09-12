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
			int num = 1000955325;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4E90F028u) % 5u)
				{
				case 4u:
					Application.SetCompatibleTextRenderingDefault(false);
					num = ((int)num2 * -299456927) ^ 0x6A6E8020;
					continue;
				case 3u:
					Application.Run((Form)(object)new Form1());
					num = (int)((num2 * 1121294548) ^ 0x3B9F9A72);
					continue;
				case 1u:
					num = (int)(num2 * 1245377864) ^ -975314292;
					continue;
				default:
					return;
				case 2u:
					break;
				case 0u:
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
