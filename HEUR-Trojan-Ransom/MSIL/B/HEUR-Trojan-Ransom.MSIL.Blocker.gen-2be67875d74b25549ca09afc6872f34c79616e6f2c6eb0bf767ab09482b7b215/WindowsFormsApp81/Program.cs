using System.Windows.Forms;
using WindowsFormsApp81.Forms;

namespace WindowsFormsApp81;

internal class Program
{
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new Form1());
	}
}
