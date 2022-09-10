namespace Microsoft.Tools.RegAsm;

internal class Option
{
	private string m_strName;

	private string m_strValue;

	internal string Name => m_strName;

	internal string Value => m_strValue;

	internal Option(string strName, string strValue)
	{
		m_strName = strName;
		m_strValue = strValue;
	}
}
