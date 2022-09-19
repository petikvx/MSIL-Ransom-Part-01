using System;
using System.Collections.Generic;

namespace DnDSpellSorter.ResourceParser;

internal class SpellListConverter
{
	public static SpellInformation ProcessSpell(SpellListJSON.Spell SpellJSON)
	{
		SpellInformation spellInformation = new SpellInformation();
		spellInformation.CastingTime = SpellJSON.time;
		spellInformation.Classes = new List<string>();
		spellInformation.Subclasses = new List<string>();
		string[] array = SpellJSON.classes.Split(new char[1] { ',' });
		foreach (string input in array)
		{
			ParseParentheses(input, out var beforeParen, out var insideParen);
			if (beforeParen != null && !spellInformation.Classes.Contains(beforeParen))
			{
				spellInformation.Classes.Add(beforeParen);
			}
			if (insideParen != null)
			{
				spellInformation.Subclasses.Add(insideParen);
			}
		}
		ParseParentheses(SpellJSON.components, out var beforeParen2, out var insideParen2);
		spellInformation.Components = beforeParen2;
		spellInformation.Materials = insideParen2;
		spellInformation.Concentration = SpellJSON.duration.StartsWith("Concentration");
		spellInformation.Duration = SpellJSON.duration;
		int result = -1;
		int.TryParse(SpellJSON.level, out result);
		spellInformation.Level = result;
		spellInformation.Name = SpellJSON.name;
		spellInformation.Range = SpellJSON.range;
		if (SpellJSON.ritual != null)
		{
			spellInformation.Ritual = SpellJSON.ritual.Equals("YES", StringComparison.OrdinalIgnoreCase);
		}
		spellInformation.School = ConvertSchoolLetterToWord(SpellJSON.school);
		return spellInformation;
	}

	public static SpellInformation ProcessSpell(SpellListXML.compendiumSpell SpellXML)
	{
		SpellInformation spellInformation = new SpellInformation();
		spellInformation.CastingTime = SpellXML.time;
		spellInformation.Classes = new List<string>();
		string[] array = SpellXML.classes.Split(new char[1] { ',' });
		foreach (string text in array)
		{
			spellInformation.Classes.Add(text.Trim());
		}
		spellInformation.Components = SpellXML.components;
		spellInformation.Concentration = SpellXML.duration.StartsWith("Concentration");
		string[] text2 = SpellXML.text;
		foreach (string text3 in text2)
		{
			if (spellInformation.Description == null || spellInformation.Description.Length == 0)
			{
				spellInformation.Description = text3;
				continue;
			}
			spellInformation.Description += Environment.NewLine;
			spellInformation.Description += text3;
		}
		spellInformation.Duration = SpellXML.duration;
		spellInformation.Level = SpellXML.level;
		spellInformation.Name = SpellXML.name;
		spellInformation.Range = SpellXML.range;
		spellInformation.Ritual = SpellXML.ritual.Equals("YES");
		spellInformation.School = ConvertSchoolLetterToWord(SpellXML.school);
		return spellInformation;
	}

	private static string ConvertSchoolLetterToWord(string Letter)
	{
		return Letter switch
		{
			"EV" => "Evocation", 
			"EN" => "Enchantment", 
			"A" => "Abjuration", 
			"D" => "Divination", 
			"N" => "Necromancy", 
			"C" => "Conjuration", 
			"T" => "Transformation", 
			"I" => "Illusion", 
			_ => Letter, 
		};
	}

	private static void ParseParentheses(string input, out string beforeParen, out string insideParen)
	{
		if (input == null)
		{
			beforeParen = null;
			insideParen = null;
		}
		else if (input.Contains("("))
		{
			beforeParen = input.Substring(0, input.IndexOf("(")).Trim();
			insideParen = input.Substring(input.IndexOf("(") + 1);
			if (insideParen.Contains(")"))
			{
				insideParen = insideParen.Substring(0, insideParen.IndexOf(")"));
			}
			insideParen = insideParen.Trim();
		}
		else
		{
			beforeParen = input.Trim();
			insideParen = null;
		}
	}
}
