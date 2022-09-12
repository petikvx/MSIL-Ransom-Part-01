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
			int num = 2095295440;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x601B6B03u) % 3u)
				{
				case 1u:
					goto IL_0007;
				case 0u:
					break;
				default:
					Application.Run((Form)(object)new Form1());
					return;
				}
				break;
				IL_0007:
				Application.SetCompatibleTextRenderingDefault(false);
				num = (int)((num2 * 1884947775) ^ 0x6D8DE885);
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
