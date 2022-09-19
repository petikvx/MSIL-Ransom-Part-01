using System.Collections.Generic;

namespace DnDSpellSorter;

internal class SpellInformation
{
	public string Name { get; set; }

	public int Level { get; set; }

	public string School { get; set; }

	public string CastingTime { get; set; }

	public string Range { get; set; }

	public string Components { get; set; }

	public string Materials { get; set; }

	public string Duration { get; set; }

	public string Description { get; set; }

	public List<string> Classes { get; set; }

	public List<string> Subclasses { get; set; }

	public bool Concentration { get; set; }

	public bool Ritual { get; set; }
}
