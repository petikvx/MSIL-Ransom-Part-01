using System.Xml.Serialization;

namespace triPOS_vbnet;

public class ApiError
{
	private string m_UserMessage;

	private string m_DeveloperMessage;

	private string m_ErrorType;

	private string m_ExceptionMessage;

	private string m_ExceptionTypeFullName;

	private string m_ExceptionTypeShortName;

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

	[XmlElement("errorType")]
	public string ErrorType
	{
		get
		{
			return m_ErrorType;
		}
		set
		{
			m_ErrorType = value;
		}
	}

	[XmlElement("exceptionMessage")]
	public string ExceptionMessage
	{
		get
		{
			return m_ExceptionMessage;
		}
		set
		{
			m_ExceptionMessage = value;
		}
	}

	[XmlElement("exceptionTypeFullName")]
	public string ExceptionTypeFullName
	{
		get
		{
			return m_ExceptionTypeFullName;
		}
		set
		{
			m_ExceptionTypeFullName = value;
		}
	}

	[XmlElement("exceptionTypeShortName")]
	public string ExceptionTypeShortName
	{
		get
		{
			return m_ExceptionTypeShortName;
		}
		set
		{
			m_ExceptionTypeShortName = value;
		}
	}
}
