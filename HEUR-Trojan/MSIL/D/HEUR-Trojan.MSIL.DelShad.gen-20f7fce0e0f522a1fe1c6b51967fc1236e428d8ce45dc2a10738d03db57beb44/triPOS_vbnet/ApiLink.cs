using System.Xml.Serialization;

namespace triPOS_vbnet;

public class ApiLink
{
	private string m_Href;

	private string m_Method;

	private string m_Relation;

	[XmlElement("href")]
	public string Href
	{
		get
		{
			return m_Href;
		}
		set
		{
			m_Href = value;
		}
	}

	[XmlElement("method")]
	public string Method
	{
		get
		{
			return m_Method;
		}
		set
		{
			m_Method = value;
		}
	}

	[XmlElement("rel")]
	public string Relation
	{
		get
		{
			return m_Relation;
		}
		set
		{
			m_Relation = value;
		}
	}
}
