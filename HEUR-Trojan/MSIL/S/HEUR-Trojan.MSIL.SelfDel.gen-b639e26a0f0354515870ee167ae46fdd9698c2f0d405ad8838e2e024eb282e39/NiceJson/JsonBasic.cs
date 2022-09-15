using System;
using RU;

namespace NiceJson;

[Serializable]
public class JsonBasic : JsonNode
{
	private object m_value;

	public object ValueObject => m_value;

	public JsonBasic(object object_0)
	{
		m_value = object_0;
	}

	public override string ToString()
	{
		return m_value.ToString();
	}

	public override string vmethod_0()
	{
		if (m_value == null)
		{
			return Class22.smethod_0("\ue931\ue92a\ue933\ue933", 59726);
		}
		if (m_value is string)
		{
			return Class22.smethod_0("\uf4dd", 62655) + JsonNode.smethod_0(m_value.ToString()) + Class22.smethod_0("\uf4dd", 62655);
		}
		if (m_value is bool)
		{
			if ((bool)m_value)
			{
				return Class22.smethod_0("\uf58b\uf58d\uf58a\uf59a", 62971);
			}
			return Class22.smethod_0("\uee93\uee94\uee99\uee86\uee90", 61041);
		}
		return m_value.ToString();
	}
}
