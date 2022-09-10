using System;
using System.Windows.Forms;

namespace ExampleApp;

public class EntryPoint
{
	[STAThread]
	public static void Main(string[] args)
	{
		Console.WriteLine("Now Executing Custom Application...");
		Form1 form = new Form1();
		((Control)form).set_Visible(false);
		Application.Run((Form)(object)form);
	}
}
