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
			int num = -552309561;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBA388E43u) % 8u)
				{
				case 7u:
					Application.SetCompatibleTextRenderingDefault(false);
					num = ((int)num2 * -1026975161) ^ -1796508264;
					continue;
				case 5u:
					Application.Run((Form)(object)new Form1());
					num = (int)(num2 * 1633892048) ^ -1517299856;
					continue;
				case 4u:
					Application.EnableVisualStyles();
					num = ((int)num2 * -967348390) ^ -1403120350;
					continue;
				case 3u:
					num = (int)((num2 * 105368516) ^ 0x1F624E67);
					continue;
				case 2u:
					num = (int)(num2 * 318476064) ^ -217136642;
					continue;
				case 1u:
					num = (int)(num2 * 1703011917) ^ -633680767;
					continue;
				default:
					return;
				case 6u:
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
