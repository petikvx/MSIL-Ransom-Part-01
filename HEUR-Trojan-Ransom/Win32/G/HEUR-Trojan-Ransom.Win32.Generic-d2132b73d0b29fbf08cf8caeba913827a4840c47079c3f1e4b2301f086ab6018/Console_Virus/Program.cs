using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Console_Virus;

[Guid("2936f71b-386b-408f-aeb1-85db00e8874b")]
internal static class Program
{
	[STAThread]
	private static void Main()
	{
		int num = 0;
		while (num < 2)
		{
			bool createdNew;
			using (new Mutex(initiallyOwned: true, "2936f71b-386b-408f-aeb1-85db00e8874b", out createdNew))
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
