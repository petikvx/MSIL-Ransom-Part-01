using System;
using System.Collections.Generic;

namespace HtmlAgilityPack;

internal class NameValuePairList
{
	internal readonly string Text;

	private List<KeyValuePair<string, string>> _allPairs;

	private Dictionary<string, List<KeyValuePair<string, string>>> _pairsWithName;

	internal NameValuePairList()
		: this(null)
	{
	}

	internal NameValuePairList(string text)
	{
		Text = text;
		_allPairs = new List<KeyValuePair<string, string>>();
		_pairsWithName = new Dictionary<string, List<KeyValuePair<string, string>>>();
		Parse(text);
	}

	internal static string GetNameValuePairsValue(string text, string name)
	{
		return new NameValuePairList(text).GetNameValuePairValue(name);
	}

	internal List<KeyValuePair<string, string>> GetNameValuePairs(string name)
	{
		if (name == null)
		{
			return _allPairs;
		}
		if (!_pairsWithName.ContainsKey(name))
		{
			return new List<KeyValuePair<string, string>>();
		}
		return _pairsWithName[name];
	}

	internal string GetNameValuePairValue(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException();
		}
		List<KeyValuePair<string, string>> nameValuePairs = GetNameValuePairs(name);
		if (nameValuePairs.Count == 0)
		{
			return string.Empty;
		}
		return nameValuePairs[0].Value.Trim();
	}

	private void Parse(string text)
	{
		_allPairs.Clear();
		_pairsWithName.Clear();
		if (text == null)
		{
			return;
		}
		string[] array = text.Split(new char[1] { ';' });
		foreach (string text2 in array)
		{
			if (text2.Length == 0)
			{
				continue;
			}
			string[] array2 = text2.Split(new char[1] { '=' }, 2);
			if (array2.Length != 0)
			{
				KeyValuePair<string, string> item = new KeyValuePair<string, string>(array2[0].Trim().ToLowerInvariant(), (array2.Length < 2) ? "" : array2[1]);
				_allPairs.Add(item);
				if (!_pairsWithName.TryGetValue(item.Key, out var value))
				{
					value = new List<KeyValuePair<string, string>>();
					_pairsWithName.Add(item.Key, value);
				}
				value.Add(item);
			}
		}
	}
}
