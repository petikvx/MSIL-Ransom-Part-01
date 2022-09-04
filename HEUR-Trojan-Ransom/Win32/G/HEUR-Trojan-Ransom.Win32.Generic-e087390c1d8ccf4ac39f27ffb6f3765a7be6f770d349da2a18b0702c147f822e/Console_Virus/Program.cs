using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Console_Virus;

[Guid("74b0a3e6-fb10-4b51-b132-3f2fafae8a52")]
internal static class Program
{
	[STAThread]
	private static void Main()
	{
		int num = 0;
		while (num < 2)
		{
			bool createdNew;
			using (new Mutex(initiallyOwned: true, "74b0a3e6-fb10-4b51-b132-3f2fafae8a52", out createdNew))
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
