using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using DnDSpellSorter.Spells;

namespace DnDSpellSorter.ResourceParser;

internal class SpellLoader
{
	public static SpellList LoadSpells()
	{
		return LoadSpellsViaJSON();
	}

	public static SpellList LoadSpellsViaJSON()
	{
		SpellList spellList = new SpellList();
		FileInfo[] allJSONResources = GetAllJSONResources();
		FileInfo[] array = allJSONResources;
		foreach (FileInfo fileInfo in array)
		{
			Console.WriteLine("Processing " + fileInfo.FullName);
			SpellList spellList2 = ParseJSONSpells(fileInfo);
			foreach (SpellInformation spell in spellList2.spells)
			{
				spellList.AddSpell(spell);
			}
		}
		return spellList;
	}

	public static SpellList LoadSpellsViaXML()
	{
		SpellList spellList = new SpellList();
		FileInfo[] allXMLResources = GetAllXMLResources();
		FileInfo[] array = allXMLResources;
		foreach (FileInfo fileInfo in array)
		{
			Console.WriteLine("Processing " + fileInfo.FullName);
			SpellList spellList2 = ParseXMLSpells(fileInfo);
			foreach (SpellInformation spell in spellList2.spells)
			{
				spellList.AddSpell(spell);
			}
		}
		return spellList;
	}

	private static FileInfo[] GetAllJSONResources()
	{
		return GetAllResources(".json");
	}

	private static FileInfo[] GetAllXMLResources()
	{
		return GetAllResources(".xml");
	}

	private static FileInfo[] GetAllResources(string extension)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo("SpellSorterResources");
		FileInfo[] array = new FileInfo[directoryInfo.GetFiles().Length];
		int num = 0;
		FileInfo[] files = directoryInfo.GetFiles();
		foreach (FileInfo fileInfo in files)
		{
			if (fileInfo.Name.EndsWith(extension, StringComparison.OrdinalIgnoreCase))
			{
				Console.WriteLine(fileInfo.Name + " IS a " + extension + " file");
				array[num++] = fileInfo;
			}
			else
			{
				Console.WriteLine(fileInfo.Name + " is not a " + extension + " file");
			}
		}
		if (num != array.Length)
		{
			Console.WriteLine("Resources that are not " + extension + " files exist! Trimming...");
			FileInfo[] array2 = new FileInfo[num];
			Array.Copy(array, array2, num);
			return array2;
		}
		return array;
	}

	private static SpellList ParseJSONSpells(FileInfo jsonFile)
	{
		new SpellList();
		ReadFile(jsonFile);
		return null;
	}

	private static string ReadFile(FileInfo file)
	{
		using StreamReader streamReader = new StreamReader(file.FullName, Encoding.UTF8);
		return streamReader.ReadToEnd();
	}

	private static SpellList ParseXMLSpells(FileInfo xmlFile)
	{
		SpellList spellList = new SpellList();
		XmlSerializer xmlSerializer = new XmlSerializer(typeof(SpellListXML));
		SpellListXML.compendium compendium = (SpellListXML.compendium)xmlSerializer.Deserialize(new StreamReader(xmlFile.FullName, Encoding.UTF8));
		SpellListXML.compendiumSpell[] spell = compendium.spell;
		foreach (SpellListXML.compendiumSpell spellXML in spell)
		{
			spellList.AddSpell(SpellListConverter.ProcessSpell(spellXML));
		}
		return spellList;
	}
}
