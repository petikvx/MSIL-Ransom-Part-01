using System;
using System.Threading;
using System.Windows.Forms;

namespace JavaCPL;

internal sealed class Class0
{
	[STAThread]
	private static void Main(string[] args)
	{
		bool createdNew;
		using (new Mutex(initiallyOwned: true, "bitkXSELincQOOrxCPDlltDsBwDdClX", out createdNew))
		{
			if (createdNew)
			{
				try
				{
					Application.EnableVisualStyles();
					Application.SetCompatibleTextRenderingDefault(false);
					Application.Run((Form)(object)new GForm0());
					return;
				}
				catch
				{
					Application.Restart();
					return;
				}
			}
			try
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run((Form)(object)new GForm0());
			}
			catch (Exception)
			{
				Application.Restart();
			}
		}
	}
}
