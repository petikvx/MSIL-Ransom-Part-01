namespace DnDSpellSorter.ResourceParser;

internal class SpellListJSON
{
	public class Data
	{
		public Compendium compendium { get; set; }
	}

	public class Compendium
	{
		public string version { get; set; }

		public Spell[] spell { get; set; }
	}

	public class Spell
	{
		public string name { get; set; }

		public string level { get; set; }

		public string school { get; set; }

		public string time { get; set; }

		public string range { get; set; }

		public string components { get; set; }

		public string duration { get; set; }

		public string classes { get; set; }

		public object text { get; set; }

		public object roll { get; set; }

		public string ritual { get; set; }
	}
}
