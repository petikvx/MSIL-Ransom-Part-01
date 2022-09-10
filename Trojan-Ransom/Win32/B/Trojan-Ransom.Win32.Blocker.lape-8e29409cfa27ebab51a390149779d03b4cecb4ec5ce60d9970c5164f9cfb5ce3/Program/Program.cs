using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Program;

[Guid("3dfd415b-a42d-4369-a360-121bd607cfe4")]
internal static class Program
{
	[STAThread]
	private static void Main()
	{
		int num = 0;
		while (true)
		{
			bool createdNew;
			using (new Mutex(initiallyOwned: true, "3dfd415b-a42d-4369-a360-121bd607cfe4", out createdNew))
			{
				if (createdNew)
				{
					Application.EnableVisualStyles();
					Application.SetCompatibleTextRenderingDefault(false);
					Application.Run((Form)(object)new frmMain());
					break;
				}
				if (num != 4)
				{
					num++;
					Thread.Sleep(500);
					continue;
				}
				break;
			}
		}
	}
}
