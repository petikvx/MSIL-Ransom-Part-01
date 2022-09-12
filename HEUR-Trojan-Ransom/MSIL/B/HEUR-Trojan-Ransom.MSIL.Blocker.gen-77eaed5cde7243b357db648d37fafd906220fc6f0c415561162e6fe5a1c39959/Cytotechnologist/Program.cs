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
			int num = 982680186;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5CFA4570u) % 6u)
				{
				case 5u:
					Application.Run((Form)(object)new Form1());
					num = (int)((num2 * 1623757489) ^ 0x5512B101);
					continue;
				case 4u:
					Application.EnableVisualStyles();
					num = (int)(num2 * 1928835747) ^ -91893725;
					continue;
				case 2u:
					num = (int)((num2 * 563028145) ^ 0x4F16B44F);
					continue;
				case 1u:
					Application.SetCompatibleTextRenderingDefault(false);
					num = (int)(num2 * 543025419) ^ -329571932;
					continue;
				default:
					return;
				case 0u:
					break;
				case 3u:
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
