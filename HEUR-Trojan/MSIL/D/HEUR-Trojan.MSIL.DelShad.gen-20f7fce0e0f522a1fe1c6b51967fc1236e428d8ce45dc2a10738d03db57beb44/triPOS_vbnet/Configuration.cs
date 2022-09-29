using System.Xml.Serialization;

namespace triPOS_vbnet;

public class Configuration
{
	private bool? m_AllowPartialApprovals;

	private bool? m_CheckForDuplicateTransactions;

	private string m_CurrencyCode;

	private string m_MarketCode;

	[XmlElement("allowPartialApprovals")]
	public bool? AllowPartialApprovals
	{
		get
		{
			return m_AllowPartialApprovals;
		}
		set
		{
			m_AllowPartialApprovals = value;
		}
	}

	[XmlElement("checkForDuplicateTransactions")]
	public bool? CheckForDuplicateTransactions
	{
		get
		{
			return m_CheckForDuplicateTransactions;
		}
		set
		{
			m_CheckForDuplicateTransactions = value;
		}
	}

	[XmlElement("currencyCode")]
	public string CurrencyCode
	{
		get
		{
			return m_CurrencyCode;
		}
		set
		{
			m_CurrencyCode = value;
		}
	}

	[XmlElement("marketCode")]
	public string MarketCode
	{
		get
		{
			return m_MarketCode;
		}
		set
		{
			m_MarketCode = value;
		}
	}
}
