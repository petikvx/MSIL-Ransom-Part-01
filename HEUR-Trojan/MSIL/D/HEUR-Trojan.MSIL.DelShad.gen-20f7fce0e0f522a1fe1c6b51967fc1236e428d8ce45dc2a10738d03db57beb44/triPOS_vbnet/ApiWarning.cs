using System.Xml.Serialization;

namespace triPOS_vbnet;

public class ApiWarning
{
	private string m_DeveloperMessage;

	private string m_UserMessage;

	[XmlElement("developerMessage")]
	public string DeveloperMessage
	{
		get
		{
			return m_DeveloperMessage;
		}
		set
		{
			m_DeveloperMessage = value;
		}
	}

	[XmlElement("userMessage")]
	public string UserMessage
	{
		get
		{
			return m_UserMessage;
		}
		set
		{
			m_UserMessage = value;
		}
	}
}
