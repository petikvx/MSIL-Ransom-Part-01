using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using FqghP3gHxnBwblp;

namespace JSujvNHkkfwLWTqss8zKQRmRj;

[Guid("c4e1a52e-1aa7-4eda-9b5d-a2fc7b499c9f")]
internal static class XOts0wblzWTzO6qIFkQCaj
{
	[STAThread]
	private static void Main()
	{
		int num = 0;
		while (num < 2)
		{
			bool createdNew;
			using (new Mutex(initiallyOwned: true, "c4e1a52e-1aa7-4eda-9b5d-a2fc7b499c9f", out createdNew))
			{
				if (createdNew)
				{
					Application.EnableVisualStyles();
					Application.SetCompatibleTextRenderingDefault(false);
					Application.Run((Form)(object)new TmgplMKIM4Yk3yp69JNNohedQvB3());
					break;
				}
				num++;
				Thread.Sleep(1000);
			}
		}
	}
}
