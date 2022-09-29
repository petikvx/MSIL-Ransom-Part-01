using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace triPOS_vbnet;

public class HttpValueCollection : List<HttpValue>
{
	public string[] AllKeys
	{
		get
		{
			string[] result = default(string[]);
			return result;
		}
	}

	public string this[string key]
	{
		get
		{
			string result = default(string);
			return result;
		}
		set
		{
		}
	}

	public HttpValueCollection()
	{
	}

	public HttpValueCollection(string query)
		: this(query, urlEncoded: true)
	{
	}

	public HttpValueCollection(string query, bool urlEncoded)
	{
		if (!string.IsNullOrEmpty(query))
		{
			FillFromString(query, urlEncoded);
		}
	}

	public void Add(string key, string value)
	{
		Add(new HttpValue(key, value));
	}

	public bool ContainsKey(string key)
	{
		return false;
	}

	public string[] GetValues(string key)
	{
		string[] result = default(string[]);
		return result;
	}

	public void Remove(string key)
	{
		RemoveAll((HttpValue x) => string.Equals(x.Key, key, StringComparison.OrdinalIgnoreCase));
	}

	public override string ToString()
	{
		return ToString(urlEncoded: true);
	}

	public string ToString(bool urlEncoded)
	{
		return ToString(urlEncoded, null);
	}

	public string ToString(bool urlEncoded, IDictionary excludeKeys)
	{
		if (base.Count == 0)
		{
			return string.Empty;
		}
		StringBuilder stringBuilder = new StringBuilder();
		using (Enumerator enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				HttpValue current = enumerator.Current;
				string text = current.Key;
				if (excludeKeys != null && excludeKeys.Contains(text))
				{
					continue;
				}
				string text2 = current.Value;
				if (urlEncoded)
				{
					text = Uri.EscapeDataString(text);
				}
				if (stringBuilder.Length > 0)
				{
					stringBuilder.Append('&');
				}
				stringBuilder.Append((text != null) ? (text + Convert.ToString("=")) : string.Empty);
				if (!string.IsNullOrEmpty(text2))
				{
					if (urlEncoded)
					{
						text2 = Uri.EscapeDataString(text2);
					}
					stringBuilder.Append(text2);
				}
			}
		}
		return stringBuilder.ToString();
	}

	private void FillFromString(string query, bool urlEncoded)
	{
		int num = query?.Length ?? 0;
		checked
		{
			int num2 = num - 1;
			for (int i = 0; i <= num2; i++)
			{
				int num3 = i;
				int num4 = -1;
				for (; i < num; i++)
				{
					switch (query[i])
					{
					case '=':
						if (num4 < 0)
						{
							num4 = i;
						}
						continue;
					default:
						continue;
					case '&':
						break;
					}
					break;
				}
				string text = null;
				string text2 = null;
				if (num4 >= 0)
				{
					text = query.Substring(num3, num4 - num3);
					text2 = query.Substring(num4 + 1, i - num4 - 1);
				}
				else
				{
					text2 = query.Substring(num3, i - num3);
				}
				if (urlEncoded)
				{
					Add(Uri.UnescapeDataString(text), Uri.UnescapeDataString(text2));
				}
				else
				{
					Add(text, text2);
				}
				if (i == num - 1 && query[i] == '&')
				{
					Add(null, string.Empty);
				}
			}
		}
	}
}
