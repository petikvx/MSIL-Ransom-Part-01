using System;
using ns4;

namespace NiceJson;

[Serializable]
public sealed class JsonBasic : JsonNode
{
	internal object m_value;

	public JsonBasic(object object_0)
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
		if (m_value is string)
		{
			return "\"" + Class16.smethod_99(m_value.ToString()) + "\"";
		}
		if (m_value is bool)
		{
			if ((bool)m_value)
			{
				return "true";
			}
			return "false";
		}
		return m_value.ToString();
	}
}
