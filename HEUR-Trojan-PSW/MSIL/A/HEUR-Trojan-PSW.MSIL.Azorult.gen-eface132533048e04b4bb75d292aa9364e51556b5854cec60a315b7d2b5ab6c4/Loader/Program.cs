using System;
using System.Windows.Forms;

namespace Loader;

public class Program
{
	[STAThread]
	public static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new Nyan());
	}
}
