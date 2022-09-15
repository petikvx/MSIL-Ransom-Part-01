using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using RU;

namespace NiceJson;

[Serializable]
public class JsonObject : JsonNode, IEnumerable
{
	private Dictionary<string, JsonNode> m_dictionary = new Dictionary<string, JsonNode>();

	public Dictionary<string, JsonNode>.KeyCollection Keys => m_dictionary.Keys;

	public Dictionary<string, JsonNode>.ValueCollection Values => m_dictionary.Values;

	public new JsonNode this[string key]
	{
		get
		{
			return m_dictionary[key];
		}
		set
		{
			m_dictionary[key] = value;
		}
	}

	public int Count => m_dictionary.Count;

	public void method_2(string string_0, JsonNode jsonNode_0)
	{
		m_dictionary.Add(string_0, jsonNode_0);
	}

	public bool method_3(string string_0)
	{
		return m_dictionary.Remove(string_0);
	}

	public bool method_4(string string_0)
	{
		return m_dictionary.ContainsKey(string_0);
	}

	public bool method_5(JsonNode jsonNode_0)
	{
		return m_dictionary.ContainsValue(jsonNode_0);
	}

	public void method_6()
	{
		m_dictionary.Clear();
	}

	public IEnumerator method_7()
	{
		foreach (KeyValuePair<string, JsonNode> item in m_dictionary)
		{
			yield return item;
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return method_7();
	}

	public override string vmethod_0()
	{
		if (m_dictionary == null)
		{
			return Class22.smethod_0("\ue931\ue92a\ue933\ue933", 59726);
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append('{');
		foreach (string key in m_dictionary.Keys)
		{
			stringBuilder.Append('"');
			stringBuilder.Append(JsonNode.smethod_0(key));
			stringBuilder.Append('"');
			stringBuilder.Append(':');
			if (m_dictionary[key] != null)
			{
				stringBuilder.Append(m_dictionary[key].vmethod_0());
			}
			else
			{
				stringBuilder.Append(Class22.smethod_0("\ue931\ue92a\ue933\ue933", 59726));
			}
			stringBuilder.Append(',');
		}
		if (stringBuilder[stringBuilder.Length - 1] == ',')
		{
			stringBuilder.Remove(stringBuilder.Length - 1, 1);
		}
		stringBuilder.Append('}');
		return stringBuilder.ToString();
	}
}
