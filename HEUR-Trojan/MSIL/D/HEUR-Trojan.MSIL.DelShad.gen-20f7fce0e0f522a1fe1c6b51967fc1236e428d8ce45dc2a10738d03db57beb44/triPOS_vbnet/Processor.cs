using System.Collections.Generic;
using System.Xml.Serialization;

namespace triPOS_vbnet;

public class Processor
{
	private List<string> m_ProcessorLogs;

	private string m_ProcessorRawResponse;

	private string m_ProcessorReferenceNumber;

	private bool m_ProcessorRequestFailed;

	private bool m_ProcessorRequestWasApproved;

	private ProcessorResponseCode m_ProcessorResponseCode;

	private string m_ProcessorResponseMessage;

	[XmlArrayItem(ElementName = "log")]
	[XmlArray(ElementName = "processorLogs")]
	public List<string> ProcessorLogs
	{
		get
		{
			return m_ProcessorLogs;
		}
		set
		{
			m_ProcessorLogs = value;
		}
	}

	[XmlElement("processorRawResponse")]
	public string ProcessorRawResponse
	{
		get
		{
			return m_ProcessorRawResponse;
		}
		set
		{
			m_ProcessorRawResponse = value;
		}
	}

	[XmlElement("processorReferenceNumber")]
	public string ProcessorReferenceNumber
	{
		get
		{
			return m_ProcessorReferenceNumber;
		}
		set
		{
			m_ProcessorReferenceNumber = value;
		}
	}

	[XmlElement("processorRequestFailed")]
	public bool ProcessorRequestFailed
	{
		get
		{
			return m_ProcessorRequestFailed;
		}
		set
		{
			m_ProcessorRequestFailed = value;
		}
	}

	[XmlElement("processorRequestWasApproved")]
	public bool ProcessorRequestWasApproved
	{
		get
		{
			return m_ProcessorRequestWasApproved;
		}
		set
		{
			m_ProcessorRequestWasApproved = value;
		}
	}

	[XmlElement("processorResponseCode")]
	public ProcessorResponseCode ProcessorResponseCode
	{
		get
		{
			return m_ProcessorResponseCode;
		}
		set
		{
			m_ProcessorResponseCode = value;
		}
	}

	[XmlElement("processorResponseMessage")]
	public string ProcessorResponseMessage
	{
		get
		{
			return m_ProcessorResponseMessage;
		}
		set
		{
			m_ProcessorResponseMessage = value;
		}
	}
}
