using System;

[Serializable]
public class GClass1 : GClass0
{
	private object m_value;

	public object Object_0 => m_value;

	public GClass1(object object_0)
	{
		m_value = object_0;
	}

	string object.ToString()
	{
		return m_value.ToString();
	}

	public override string vmethod_0()
	{
		if (m_value == null)
		{
			return "null";
		}
		if (!(m_value is string))
		{
			if (!(m_value is bool))
			{
				return m_value.ToString();
			}
			if (!(bool)m_value)
			{
				return "false";
			}
			return "true";
		}
		return "\"" + GClass0.smethod_0(m_value.ToString()) + "\"";
	}
}
