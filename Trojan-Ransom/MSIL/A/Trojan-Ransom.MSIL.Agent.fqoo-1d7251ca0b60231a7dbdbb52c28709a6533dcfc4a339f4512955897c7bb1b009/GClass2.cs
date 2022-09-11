using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

[Serializable]
public class GClass2 : GClass0, IEnumerable
{
	private Dictionary<string, GClass0> m_dictionary = new Dictionary<string, GClass0>();

	public Dictionary<string, GClass0>.KeyCollection KeyCollection_0 => m_dictionary.Keys;

	public Dictionary<string, GClass0>.ValueCollection ValueCollection_0 => m_dictionary.Values;

	public new GClass0 this[string string_0]
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

	public int Int32_0 => m_dictionary.Count;

	public void method_2(string string_0, GClass0 gclass0_0)
	{
		m_dictionary.Add(string_0, gclass0_0);
	}

	public bool method_3(string string_0)
	{
		return m_dictionary.Remove(string_0);
	}

	public bool method_4(string string_0)
	{
		return m_dictionary.ContainsKey(string_0);
	}

	public bool method_5(GClass0 gclass0_0)
	{
		return m_dictionary.ContainsValue(gclass0_0);
	}

	public void method_6()
	{
		m_dictionary.Clear();
	}

	public IEnumerator method_7()
	{
		foreach (KeyValuePair<string, GClass0> item in m_dictionary)
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
			return "null";
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append('{');
		foreach (string key in m_dictionary.Keys)
		{
			stringBuilder.Append('"');
			stringBuilder.Append(GClass0.smethod_0(key));
			stringBuilder.Append('"');
			stringBuilder.Append(':');
			if (m_dictionary[key] == null)
			{
				stringBuilder.Append("null");
			}
			else
			{
				stringBuilder.Append(m_dictionary[key].vmethod_0());
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
