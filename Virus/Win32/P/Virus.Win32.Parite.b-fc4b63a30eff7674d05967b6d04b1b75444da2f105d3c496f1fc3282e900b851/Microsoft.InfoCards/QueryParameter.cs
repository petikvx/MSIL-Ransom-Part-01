using System.Collections.Generic;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class QueryParameter
{
	private string m_indexName;

	private List<IndexObject> m_objects;

	public string IndexName
	{
		get
		{
			return m_indexName;
		}
		internal set
		{
			m_indexName = value;
		}
	}

	internal IndexObject this[int index] => m_objects[index];

	public int Count => m_objects.Count;

	public QueryParameter(string name)
	{
		if (string.IsNullOrEmpty(name))
		{
			throw InfoCardTrace.ThrowHelperArgumentNull("name");
		}
		m_indexName = name;
		m_objects = new List<IndexObject>();
	}

	public QueryParameter(string name, params object[] values)
		: this(name)
	{
		for (int i = 0; i < values.Length; i++)
		{
			AddMatch(values[i]);
		}
	}

	public void Clear()
	{
		m_objects.Clear();
	}

	public void AddCompiled(byte[] compiledForm)
	{
		m_objects.Add(new IndexObject(compiledForm));
	}

	public void AddMatch(params object[] values)
	{
		if (values == null || values.Length == 0)
		{
			throw InfoCardTrace.ThrowHelperArgumentNull("values");
		}
		m_objects.Add(new IndexObject(values));
	}
}
