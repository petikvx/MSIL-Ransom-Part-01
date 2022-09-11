using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Spy_PC;

public class PropertiesFile
{
	private Dictionary<string, string> list;

	private string filename;

	public PropertiesFile(string file)
	{
		reload(file);
	}

	public string get(string field, string defValue)
	{
		if (get(field) != null)
		{
			return get(field);
		}
		return defValue;
	}

	public string get(string field)
	{
		if (!list.ContainsKey(field))
		{
			return null;
		}
		return list[field];
	}

	public void set(string field, object value)
	{
		if (!list.ContainsKey(field))
		{
			list.Add(field, value.ToString());
		}
		else
		{
			list[field] = value.ToString();
		}
	}

	public void Save()
	{
		Save(filename);
	}

	public void Save(string filename)
	{
		this.filename = filename;
		if (!File.Exists(filename))
		{
			File.Create(filename);
		}
		StreamWriter streamWriter = new StreamWriter(filename);
		string[] array = list.Keys.ToArray();
		foreach (string text in array)
		{
			if (!string.IsNullOrWhiteSpace(list[text]))
			{
				streamWriter.WriteLine(text + "=" + list[text]);
			}
		}
		streamWriter.Close();
	}

	public void reload()
	{
		reload(filename);
	}

	public void reload(string filename)
	{
		this.filename = filename;
		list = new Dictionary<string, string>();
		if (File.Exists(filename))
		{
			loadFromFile(filename);
		}
		else
		{
			File.Create(filename);
		}
	}

	private void loadFromFile(string file)
	{
		string[] array = File.ReadAllLines(file);
		foreach (string text in array)
		{
			if (!string.IsNullOrEmpty(text) && !text.StartsWith(";") && !text.StartsWith("#") && !text.StartsWith("'") && Enumerable.Contains(text, '='))
			{
				int num = text.IndexOf('=');
				string key = text.Substring(0, num).Trim();
				string text2 = text.Substring(num + 1).Trim();
				if ((text2.StartsWith("\"") && text2.EndsWith("\"")) || (text2.StartsWith("'") && text2.EndsWith("'")))
				{
					text2 = text2.Substring(1, text2.Length - 2);
				}
				try
				{
					list.Add(key, text2);
				}
				catch
				{
				}
			}
		}
	}
}
