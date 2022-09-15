using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using RU;

namespace NiceJson;

[Serializable]
public class JsonArray : JsonNode, IEnumerable<JsonNode>, IEnumerable
{
	private List<JsonNode> m_list = new List<JsonNode>();

	public int Count => m_list.Count;

	public new JsonNode this[int index]
	{
		get
		{
			return m_list[index];
		}
		set
		{
			m_list[index] = value;
		}
	}

	public IEnumerator<JsonNode> GetEnumerator()
	{
		foreach (JsonNode item in m_list)
		{
			yield return item;
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public void method_2(JsonNode jsonNode_0)
	{
		m_list.Add(jsonNode_0);
	}

	public void method_3(IEnumerable<JsonNode> ienumerable_0)
	{
		m_list.AddRange(ienumerable_0);
	}

	public void method_4(int int_0, JsonNode jsonNode_0)
	{
		m_list.Insert(int_0, jsonNode_0);
	}

	public void method_5(int int_0, IEnumerable<JsonNode> ienumerable_0)
	{
		m_list.InsertRange(int_0, ienumerable_0);
	}

	public void method_6(int int_0)
	{
		m_list.RemoveAt(int_0);
	}

	public bool method_7(JsonNode jsonNode_0)
	{
		return m_list.Remove(jsonNode_0);
	}

	public void method_8()
	{
		m_list.Clear();
	}

	public override string vmethod_0()
	{
		if (m_list == null)
		{
			return Class22.smethod_0("\ue931\ue92a\ue933\ue933", 59726);
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
				stringBuilder.Append(Class22.smethod_0("\ue931\ue92a\ue933\ue933", 59726));
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
