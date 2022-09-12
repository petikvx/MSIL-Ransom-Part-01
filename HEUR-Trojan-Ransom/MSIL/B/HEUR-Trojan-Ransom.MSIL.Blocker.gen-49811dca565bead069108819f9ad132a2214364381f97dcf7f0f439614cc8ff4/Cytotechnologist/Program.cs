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
			int num = -951546439;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCDD646B8u) % 5u)
				{
				case 4u:
					num = ((int)num2 * -1258238470) ^ 0x627DD60B;
					continue;
				case 2u:
					Application.EnableVisualStyles();
					num = (int)((num2 * 575094485) ^ 0xC680128);
					continue;
				case 1u:
					Application.SetCompatibleTextRenderingDefault(false);
					num = ((int)num2 * -1863078431) ^ 0x6903D99B;
					continue;
				case 0u:
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
