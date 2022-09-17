using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using ns0;

namespace NiceJson;

[Serializable]
public sealed class JsonObject : JsonNode, IEnumerable
{
	private Dictionary<string, JsonNode> m_dictionary = new Dictionary<string, JsonNode>();

	public new JsonNode this[string string_0]
	{
		get
		{
			return m_dictionary[string_0];
		}
		set
		{
			m_dictionary[string_0] = value;
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return Class21.smethod_86(this);
	}

	public override string vmethod_0()
	{
		if (m_dictionary == null)
		{
			return "null";
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append('{');
		foreach (string key in m_dictionary.Keys)
		{
			stringBuilder.Append('"');
			stringBuilder.Append(Class21.smethod_106(key));
			stringBuilder.Append('"');
			stringBuilder.Append(':');
			if (m_dictionary[key] != null)
			{
				stringBuilder.Append(m_dictionary[key].vmethod_0());
			}
			else
			{
				stringBuilder.Append("null");
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
