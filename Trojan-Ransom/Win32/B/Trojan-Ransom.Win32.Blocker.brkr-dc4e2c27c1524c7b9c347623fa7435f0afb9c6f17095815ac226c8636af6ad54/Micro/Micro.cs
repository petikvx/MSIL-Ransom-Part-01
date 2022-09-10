using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Micro;

[Guid("49ff2ad5-d363-4c24-b46e-e93c7f6dd80e")]
internal static class Micro
{
	[STAThread]
	private static void Main()
	{
		for (int i = 0; i < 4; i++)
		{
			bool createdNew;
			using (new Mutex(initiallyOwned: true, "49ff2ad5-d363-4c24-b46e-e93c7f6dd80e", out createdNew))
			{
				if (createdNew)
				{
					Application.EnableVisualStyles();
					Application.SetCompatibleTextRenderingDefault(false);
					Application.Run((Form)(object)new FrmMicro());
					break;
				}
			}
			Thread.Sleep(500);
		}
	}
}
