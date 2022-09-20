using System;
using System.Windows.Forms;
using ConsoleApp5.Importers;

namespace Stihcpdaboumyasclt.Shared;

public sealed class Queue
{
	[STAThread]
	private static void CheckInitializer()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new Facade());
	}
}
