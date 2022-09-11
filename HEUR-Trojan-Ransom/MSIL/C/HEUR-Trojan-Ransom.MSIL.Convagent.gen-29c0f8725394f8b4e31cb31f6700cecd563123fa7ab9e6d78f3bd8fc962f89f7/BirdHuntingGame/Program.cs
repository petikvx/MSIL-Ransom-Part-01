using System;
using System.Windows.Forms;
using BirdHuntingGame.Forms;

namespace BirdHuntingGame;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)GameOptionsForm.Instance);
	}
}
