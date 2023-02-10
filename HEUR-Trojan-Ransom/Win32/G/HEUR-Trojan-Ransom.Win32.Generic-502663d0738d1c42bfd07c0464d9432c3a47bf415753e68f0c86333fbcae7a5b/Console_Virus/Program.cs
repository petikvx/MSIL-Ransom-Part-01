using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Console_Virus;

[Guid("101d3aa1-7443-4139-95cb-b5828d8efa87")]
internal static class Program
{
	[STAThread]
	private static void Main()
	{
		int num = 0;
		while (num < 2)
		{
			bool createdNew;
			using (new Mutex(initiallyOwned: true, "101d3aa1-7443-4139-95cb-b5828d8efa87", out createdNew))
			{
				if (createdNew)
				{
					Application.EnableVisualStyles();
					Application.SetCompatibleTextRenderingDefault(false);
					Application.Run((Form)(object)new FrmMain());
					break;
				}
				num++;
				Thread.Sleep(1000);
			}
		}
	}
}
