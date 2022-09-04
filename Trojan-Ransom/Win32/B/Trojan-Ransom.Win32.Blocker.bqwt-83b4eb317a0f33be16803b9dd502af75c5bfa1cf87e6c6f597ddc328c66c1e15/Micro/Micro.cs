using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Micro;

[Guid("c7268f07-a85c-4677-9aee-8ad2bdbd7b8d")]
internal static class Micro
{
	[STAThread]
	private static void Main()
	{
		for (int i = 0; i < 4; i++)
		{
			bool createdNew;
			using (new Mutex(initiallyOwned: true, "c7268f07-a85c-4677-9aee-8ad2bdbd7b8d", out createdNew))
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
