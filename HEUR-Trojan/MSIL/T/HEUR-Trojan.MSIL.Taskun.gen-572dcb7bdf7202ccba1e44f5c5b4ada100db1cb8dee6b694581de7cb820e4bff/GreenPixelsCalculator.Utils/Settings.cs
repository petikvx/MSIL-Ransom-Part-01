using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace GreenPixelsCalculator.Utils;

public abstract class Settings
{
	public static readonly string StartupPath = Path.GetFullPath(Assembly.GetExecutingAssembly().CodeBase!.Replace("file:///", "").Replace('/', '\\') + "\\..");

	public readonly Encoding encoding;

	public Dictionary<string, string> Data { get; protected set; } = new Dictionary<string, string>();


	public Dictionary<int, string> Other { get; protected set; } = new Dictionary<int, string>();


	public string FilePath { get; }

	public bool Existent => File.Exists(FilePath);

	public string this[string k]
	{
		get
		{
			return Data.ContainsKey(k) ? Data[k] : null;
		}
		set
		{
			Data[k] = value;
		}
	}

	public Settings(string fileName, Encoding enc = null)
	{
		FilePath = Path.Combine(StartupPath, fileName);
		encoding = enc ?? Encoding.Unicode;
		if (Existent)
		{
			Load();
		}
		LoadDefaults(overwrite: false);
		Save();
	}

	public void Clear()
	{
		Data.Clear();
		Other.Clear();
	}

	public abstract void LoadDefaults(bool overwrite);

	public void Load()
	{
		Clear();
		if (!File.Exists(FilePath))
		{
			throw new FileNotFoundException("Unable to find \"" + FilePath + "\".");
		}
		string[] array = File.ReadAllLines(FilePath, encoding);
		for (int i = 0; i < array.Length; i++)
		{
			string text = array[i];
			Match match;
			if (string.IsNullOrWhiteSpace(text) || !(match = Regex.Match(text, "^(?![^\\r\\n=]*#)([^\\r\\n]+?)=([^\\r\\n]*)$")).Success)
			{
				if (i < array.Length - 1)
				{
					Other[i] = text;
				}
			}
			else
			{
				string value = match.Groups[1].Value;
				string value2 = match.Groups[2].Value;
				Data[value] = value2;
			}
		}
	}

	public void Save()
	{
		string text = "";
		int num = Data.Count + Other.Count;
		KeyValuePair<string, string>[] array = IterateDictionary(Data).ToArray();
		int i = 0;
		int num2 = 0;
		for (; i < num; i++)
		{
			text = text + (Other.ContainsKey(i) ? Other[i] : (array[num2].Key + "=" + array[num2++].Value)) + "\r\n";
		}
		File.WriteAllText(FilePath, text, encoding);
	}

	public static IEnumerable<KeyValuePair<K, V>> IterateDictionary<K, V>(Dictionary<K, V> d)
	{
		foreach (KeyValuePair<K, V> item in d)
		{
			yield return item;
		}
	}
}
