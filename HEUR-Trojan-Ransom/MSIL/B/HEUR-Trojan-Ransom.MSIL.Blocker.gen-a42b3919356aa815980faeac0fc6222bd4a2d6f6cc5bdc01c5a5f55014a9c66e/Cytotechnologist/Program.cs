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
			int num = 1430202115;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5371AC49u) % 7u)
				{
				case 6u:
					Application.Run((Form)(object)new Form1());
					num = ((int)num2 * -1553106489) ^ -1850121297;
					continue;
				case 5u:
					num = ((int)num2 * -2063343373) ^ 0x623F300F;
					continue;
				case 3u:
					Application.SetCompatibleTextRenderingDefault(false);
					num = (int)(num2 * 1535431234) ^ -455556487;
					continue;
				case 2u:
					num = (int)(num2 * 1848017107) ^ -2113974587;
					continue;
				case 1u:
					Application.EnableVisualStyles();
					num = ((int)num2 * -1312145508) ^ 0x63CD6D0C;
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
