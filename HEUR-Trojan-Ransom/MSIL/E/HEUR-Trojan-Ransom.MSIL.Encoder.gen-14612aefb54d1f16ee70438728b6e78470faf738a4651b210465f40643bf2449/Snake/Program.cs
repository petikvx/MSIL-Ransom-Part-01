using System;
using System.Threading;
using System.Windows.Forms;

namespace Snake;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		new Mutex(initiallyOwned: true, "Snake", out var createdNew);
		if (createdNew)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run((Form)(object)new Form2());
		}
	}
}
