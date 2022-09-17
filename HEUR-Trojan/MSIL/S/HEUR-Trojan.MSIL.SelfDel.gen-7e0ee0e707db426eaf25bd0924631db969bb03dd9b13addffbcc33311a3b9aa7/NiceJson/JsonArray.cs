using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace NiceJson;

[Serializable]
public sealed class JsonArray : JsonNode, IEnumerable, IEnumerable<JsonNode>
{
	private List<JsonNode> m_list = new List<JsonNode>();

	public new JsonNode this[int int_0]
	{
		get
		{
			return m_list[int_0];
		}
		set
		{
			m_list[int_0] = value;
		}
	}

	IEnumerator<JsonNode> IEnumerable<JsonNode>.GetEnumerator()
	{
		//yield-return decompiler failed: Method not found
		return new Class1(0)
		{
			jsonArray_0 = this
		};
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<JsonNode>)this).GetEnumerator();
	}

	public void Add(JsonNode jsonNode_0)
	{
		m_list.Add(jsonNode_0);
	}

	public override string vmethod_0()
	{
		if (m_list == null)
		{
			return "null";
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append('[');
		foreach (JsonNode item in m_list)
		{
			if (item != null)
			{
				stringBuilder.Append(item.vmethod_0());
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
		stringBuilder.Append(']');
		return stringBuilder.ToString();
	}
}
