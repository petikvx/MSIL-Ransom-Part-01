using System;
using System.Windows.Forms;

namespace Lexicon_FX_processor_VST_module_with_TAP_delay;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new TAPDELAYGUI());
	}
}
