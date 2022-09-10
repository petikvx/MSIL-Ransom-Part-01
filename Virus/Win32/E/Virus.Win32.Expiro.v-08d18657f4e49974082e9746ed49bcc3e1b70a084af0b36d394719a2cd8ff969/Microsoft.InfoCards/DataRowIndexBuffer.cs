using System.Collections.Generic;

namespace Microsoft.InfoCards;

internal class DataRowIndexBuffer
{
	private Dictionary<string, List<IndexObject>> m_objects;

	public List<IndexObject> this[string name]
	{
		get
		{
			if (!m_objects.ContainsKey(name))
			{
				m_objects.Add(name, new List<IndexObject>());
			}
			return m_objects[name];
		}
	}

	public DataRowIndexBuffer()
	{
		m_objects = new Dictionary<string, List<IndexObject>>();
	}

	public string[] GetIndexNames()
	{
		List<string> list = new List<string>(m_objects.Keys);
		return list.ToArray();
	}

	public void Clear()
	{
		m_objects.Clear();
	}

	public void ClearIndexValues(string name)
	{
		m_objects.Remove(name);
	}

	public void AddIndexValue(string name, IndexObject obj)
	{
		this[name].Add(obj);
	}

	public void AddIndexValues(string name, IndexObject[] objs)
	{
		this[name].AddRange(objs);
	}

	public void SetIndexValues(string name, IndexObject[] indexObjects)
	{
		this[name].Clear();
		this[name].AddRange(indexObjects);
	}

	public int GetValueCount(string name)
	{
		if (!m_objects.ContainsKey(name))
		{
			return 0;
		}
		return m_objects[name].Count;
	}
}
