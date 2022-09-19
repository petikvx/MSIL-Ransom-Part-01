using System;
using System.Collections.Generic;

namespace DnDSpellSorter.Spells;

internal class SpellList
{
	public List<SpellInformation> spells { get; private set; }

	public SpellList()
	{
		spells = new List<SpellInformation>();
	}

	public bool AddSpell(SpellInformation spell)
	{
		if (spell != null && !spells.Contains(spell))
		{
			spells.Add(spell);
			return true;
		}
		return false;
	}

	public SpellInformation GetSpellInformation(string name)
	{
		foreach (SpellInformation spell in spells)
		{
			if (spell.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
			{
				return spell;
			}
		}
		return null;
	}

	public void SortSpells()
	{
	}
}
