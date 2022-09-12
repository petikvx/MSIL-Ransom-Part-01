using System;
using System.Windows.Forms;
using Llfwvpucq.Tasks;

namespace Llfwvpucq.Pages;

internal static class CreatorPage
{
	[STAThread]
	private static void LoginConfiguration()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new ObjectValueTask());
	}
}
