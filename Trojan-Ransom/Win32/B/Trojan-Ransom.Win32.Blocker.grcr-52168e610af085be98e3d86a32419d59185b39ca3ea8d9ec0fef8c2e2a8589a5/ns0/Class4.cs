using System;
using System.Windows.Forms;
using YoutubeFeedUpdater;

namespace ns0;

internal static class Class4
{
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new HiddenForm());
	}
}
