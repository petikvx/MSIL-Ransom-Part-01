namespace triPOS_vbnet;

public sealed class HttpValue
{
	private string m_Key;

	private string m_Value;

	public string Key
	{
		get
		{
			return m_Key;
		}
		set
		{
			m_Key = value;
		}
	}

	public string Value
	{
		get
		{
			return m_Value;
		}
		set
		{
			m_Value = value;
		}
	}

	public HttpValue()
	{
	}

	public HttpValue(string key, string value)
	{
		Key = key;
		Value = value;
	}
}
