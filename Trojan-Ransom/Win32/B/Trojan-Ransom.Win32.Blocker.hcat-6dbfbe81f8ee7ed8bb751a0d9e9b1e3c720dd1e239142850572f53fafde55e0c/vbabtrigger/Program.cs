using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace vbabtrigger;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		string fileName = Path.GetFileName(Application.get_ExecutablePath());
		new Mutex(initiallyOwned: true, fileName, out var createdNew);
		if (createdNew)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run((Form)(object)new Form1());
		}
	}
}
