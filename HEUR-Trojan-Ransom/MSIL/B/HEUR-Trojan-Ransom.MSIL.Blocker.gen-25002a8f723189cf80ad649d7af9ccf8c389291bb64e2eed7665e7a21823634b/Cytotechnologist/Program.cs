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
			int num = -354959782;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC27BD416u) % 7u)
				{
				case 5u:
					Application.Run((Form)(object)new Form1());
					num = (int)(num2 * 502669068) ^ -247724137;
					continue;
				case 4u:
					num = ((int)num2 * -1525730169) ^ -2117276692;
					continue;
				case 3u:
					num = ((int)num2 * -1794688737) ^ -2072478056;
					continue;
				case 2u:
					num = ((int)num2 * -1208859514) ^ 0x209150B7;
					continue;
				case 1u:
					Application.SetCompatibleTextRenderingDefault(false);
					num = ((int)num2 * -861924032) ^ 0x4E8A4483;
					continue;
				default:
					return;
				case 0u:
					break;
				case 6u:
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
