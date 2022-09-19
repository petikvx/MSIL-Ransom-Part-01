using System;
using System.Windows.Forms;
using DnDSpellSorter.ResourceParser;
using DnDSpellSorter.Spells;

namespace DnDSpellSorter;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		MainGUI mainGUI = new MainGUI();
		SpellList spellList = SpellLoader.LoadSpells();
		spellList.SortSpells();
		mainGUI.InitializeSpells(spellList);
		Application.Run((Form)(object)mainGUI);
	}
}
