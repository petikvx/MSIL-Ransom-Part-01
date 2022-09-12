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
			int num = 1056425435;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x190FCD6Eu) % 5u)
				{
				case 4u:
					num = ((int)num2 * -1451843845) ^ -1155679029;
					continue;
				case 3u:
					Application.SetCompatibleTextRenderingDefault(false);
					num = ((int)num2 * -546413719) ^ -1458067684;
					continue;
				case 1u:
					Application.EnableVisualStyles();
					num = (int)(num2 * 1088850028) ^ -659976814;
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
