using System;
using System.Threading;
using System.Windows.Forms;
using karo;
using ns5;

namespace ns0;

internal static class Class1
{
	[STAThread]
	private static void Main()
	{
		Class6.smethod_527();
		Mutex mutex = new Mutex(initiallyOwned: false, "MyUniqueMutexName");
		try
		{
			if (mutex.WaitOne(0, exitContext: false))
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run((Form)(object)new Form1());
			}
		}
		finally
		{
			mutex.Close();
		}
	}
}
