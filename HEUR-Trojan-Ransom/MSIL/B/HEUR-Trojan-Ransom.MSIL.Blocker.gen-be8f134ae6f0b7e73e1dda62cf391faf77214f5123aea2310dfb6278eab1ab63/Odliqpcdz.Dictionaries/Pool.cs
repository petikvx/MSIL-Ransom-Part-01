using System;
using System.Windows.Forms;
using SJSJF_002D3.Consumers;

namespace Odliqpcdz.Dictionaries;

internal static class Pool
{
	[STAThread]
	private static void MapServer()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new ExpressionCallbackConsumer());
	}
}
