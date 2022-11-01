using System.Windows.Forms;
using WindowsFormsApp83.Forms;

namespace WindowsFormsApp83;

internal class Program
{
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new Form1());
	}
}
