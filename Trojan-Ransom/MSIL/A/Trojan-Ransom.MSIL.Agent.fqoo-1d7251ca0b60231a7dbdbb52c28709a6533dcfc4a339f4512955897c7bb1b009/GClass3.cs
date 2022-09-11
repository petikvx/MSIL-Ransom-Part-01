using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

[Serializable]
public class GClass3 : GClass0, IEnumerable<GClass0>, IEnumerable
{
	private List<GClass0> m_list = new List<GClass0>();

	public int Int32_0 => m_list.Count;

	public new GClass0 this[int int_0]
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

	public IEnumerator<GClass0> GetEnumerator()
	{
		foreach (GClass0 item in m_list)
		{
			yield return item;
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public void method_2(GClass0 gclass0_0)
	{
		m_list.Add(gclass0_0);
	}

	public void method_3(IEnumerable<GClass0> ienumerable_0)
	{
		m_list.AddRange(ienumerable_0);
	}

	public void method_4(int int_0, GClass0 gclass0_0)
	{
		m_list.Insert(int_0, gclass0_0);
	}

	public void method_5(int int_0, IEnumerable<GClass0> ienumerable_0)
	{
		m_list.InsertRange(int_0, ienumerable_0);
	}

	public void method_6(int int_0)
	{
		m_list.RemoveAt(int_0);
	}

	public bool method_7(GClass0 gclass0_0)
	{
		return m_list.Remove(gclass0_0);
	}

	public void method_8()
	{
		m_list.Clear();
	}

	public override string vmethod_0()
	{
		if (m_list == null)
		{
			return "null";
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append('[');
		foreach (GClass0 item in m_list)
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
