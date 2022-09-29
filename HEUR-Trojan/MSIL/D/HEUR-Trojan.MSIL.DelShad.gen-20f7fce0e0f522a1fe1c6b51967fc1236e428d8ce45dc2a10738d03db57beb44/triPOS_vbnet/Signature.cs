using System.Xml.Serialization;

namespace triPOS_vbnet;

public class Signature
{
	private byte[] m_SignatureData;

	private string m_SignatureFormat;

	private string m_SignatureStatusCode;

	[XmlElement("data")]
	public byte[] SignatureData
	{
		get
		{
			return m_SignatureData;
		}
		set
		{
			m_SignatureData = value;
		}
	}

	[XmlElement("format")]
	public string SignatureFormat
	{
		get
		{
			return m_SignatureFormat;
		}
		set
		{
			m_SignatureFormat = value;
		}
	}

	[XmlElement("statusCode")]
	public string SignatureStatusCode
	{
		get
		{
			return m_SignatureStatusCode;
		}
		set
		{
			m_SignatureStatusCode = value;
		}
	}
}
