using System.Windows.Forms;
using WindowsFormsApp38.Forms;

namespace WindowsFormsApp38;

internal class Program
{
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new Form1());
	}
}
