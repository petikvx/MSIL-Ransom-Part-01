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
			int num = 1423346195;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x54B72BF2u) % 4u)
				{
				case 3u:
					Application.SetCompatibleTextRenderingDefault(false);
					Application.Run((Form)(object)new Form1());
					num = (int)((num2 * 1208380632) ^ 0x12858C10);
					continue;
				case 1u:
					Application.EnableVisualStyles();
					num = (int)(num2 * 755835331) ^ -887653718;
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
