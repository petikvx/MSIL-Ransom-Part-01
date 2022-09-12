using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json.Linq;
using ns10;
using ns17;

namespace ns11;

internal class Class192 : Collection<JToken>
{
	internal static readonly IEqualityComparer<string> iequalityComparer_0 = StringComparer.Ordinal;

	internal Dictionary<string, JToken>? dictionary_0;

	public JToken this[string string_0]
	{
		get
		{
			if (string_0 == null)
			{
				throw new ArgumentNullException("key");
			}
			if (dictionary_0 == null)
			{
				throw new KeyNotFoundException();
			}
			return dictionary_0![string_0];
		}
	}

	public ICollection<string> Keys
	{
		get
		{
			Class4.smethod_94(this);
			return dictionary_0!.Keys;
		}
	}

	public ICollection<JToken> Values
	{
		get
		{
			Class4.smethod_94(this);
			return dictionary_0!.Values;
		}
	}

	public Class192()
		: base((IList<JToken>)new List<JToken>())
	{
	}

	void Collection<JToken>.ClearItems()
	{
		base.ClearItems();
		dictionary_0?.Clear();
	}

	void Collection<JToken>.InsertItem(int index, JToken item)
	{
		Class4.smethod_364(this, Class4.smethod_367(this, item), item);
		base.InsertItem(index, item);
	}

	public bool method_0(string string_0)
	{
		if (string_0 == null)
		{
			throw new ArgumentNullException("key");
		}
		if (dictionary_0 != null)
		{
			if (dictionary_0!.TryGetValue(string_0, out var value))
			{
				return Remove(value);
			}
			return false;
		}
		return false;
	}

	void Collection<JToken>.RemoveItem(int index)
	{
		string string_ = Class4.smethod_367(this, base.Items[index]);
		method_1(string_);
		base.RemoveItem(index);
	}

	internal void method_1(string string_0)
	{
		dictionary_0?.Remove(string_0);
	}

	void Collection<JToken>.SetItem(int index, JToken item)
	{
		string text = Class4.smethod_367(this, item);
		string text2 = Class4.smethod_367(this, base.Items[index]);
		if (iequalityComparer_0.Equals(text2, text))
		{
			if (dictionary_0 != null)
			{
				dictionary_0![text] = item;
			}
		}
		else
		{
			Class4.smethod_364(this, text, item);
			if (text2 != null)
			{
				method_1(text2);
			}
		}
		base.SetItem(index, item);
	}

	public int method_2(JToken jtoken_0)
	{
		return ((List<JToken>)base.Items).smethod_8(jtoken_0);
	}

	public bool method_3(Class192 class192_0)
	{
		if (this == class192_0)
		{
			return true;
		}
		Dictionary<string, JToken> dictionary = dictionary_0;
		Dictionary<string, JToken> dictionary2 = class192_0.dictionary_0;
		if (dictionary == null && dictionary2 == null)
		{
			return true;
		}
		if (dictionary == null)
		{
			return dictionary2.Count == 0;
		}
		if (dictionary2 == null)
		{
			return dictionary.Count == 0;
		}
		if (dictionary.Count != dictionary2.Count)
		{
			return false;
		}
		foreach (KeyValuePair<string, JToken> item in dictionary)
		{
			if (dictionary2.TryGetValue(item.Key, out var value))
			{
				JProperty jProperty = (JProperty)item.Value;
				JProperty jProperty2 = (JProperty)value;
				if (jProperty.Value != null)
				{
					if (!jProperty.Value.vmethod_1(jProperty2.Value))
					{
						return false;
					}
					continue;
				}
				return jProperty2.Value == null;
			}
			return false;
		}
		return true;
	}
}
