using System;
using System.Windows.Forms;

namespace ns0;

internal static class Class1
{
	[STAThread]
	private static void Main()
	{
		while (true)
		{
			int num = 8672886;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7DA6A55Cu) % 4u)
				{
				case 2u:
					Application.EnableVisualStyles();
					num = (int)((num2 * 791779684) ^ 0x6CF7E979);
					continue;
				case 1u:
					Application.SetCompatibleTextRenderingDefault(false);
					num = (int)((num2 * 979903327) ^ 0x4FD3E6A3);
					continue;
				case 3u:
					break;
				default:
					Application.Run((Form)(object)new Form1());
					return;
				}
				break;
			}
		}
	}
}
