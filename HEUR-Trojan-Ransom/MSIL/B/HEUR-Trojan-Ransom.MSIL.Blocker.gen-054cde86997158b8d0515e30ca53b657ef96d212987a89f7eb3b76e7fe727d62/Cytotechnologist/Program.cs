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
			int num = -1814365995;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x90F7D3D8u) % 4u)
				{
				case 2u:
					Application.Run((Form)(object)new Form1());
					num = ((int)num2 * -895195644) ^ -1354032885;
					continue;
				case 1u:
					Application.SetCompatibleTextRenderingDefault(false);
					num = ((int)num2 * -914154923) ^ 0x5B9FD1E7;
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
