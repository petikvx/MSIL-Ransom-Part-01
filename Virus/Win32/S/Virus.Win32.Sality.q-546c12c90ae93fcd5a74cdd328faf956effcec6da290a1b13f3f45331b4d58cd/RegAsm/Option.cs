namespace RegAsm;

internal class Option
{
	private string m_strName;

	private string m_strValue;

	public string Name => m_strName;

	public string Value => m_strValue;

	public Option(string strName, string strValue)
	{
		m_strName = strName;
		m_strValue = strValue;
	}
}
