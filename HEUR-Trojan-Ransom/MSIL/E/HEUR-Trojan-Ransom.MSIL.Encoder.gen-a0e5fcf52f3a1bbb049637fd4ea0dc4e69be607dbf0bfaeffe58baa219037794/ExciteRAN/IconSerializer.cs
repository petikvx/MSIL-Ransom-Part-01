using System;
using System.Windows.Forms;

namespace ExciteRAN;

internal static class IconSerializer
{
	[STAThread]
	private static void CleanAssistant()
	{
		OutlineQueue.ListBuilder();
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault((byte)StoreType.RegisterNode(988) != 0);
		Application.Run((Form)(object)new DatabaseTable());
	}
}
