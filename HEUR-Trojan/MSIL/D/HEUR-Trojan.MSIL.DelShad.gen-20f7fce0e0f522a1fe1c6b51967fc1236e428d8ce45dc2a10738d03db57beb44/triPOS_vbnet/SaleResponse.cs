using System.Collections.Generic;
using System.Xml.Serialization;

namespace triPOS_vbnet;

public class SaleResponse
{
	private decimal m_CashbackAmount;

	private decimal m_DebitSurchargeAmount;

	private decimal m_ApprovedAmount;

	private decimal m_ConvenienceFeeAmount;

	private decimal m_SubTotalAmount;

	private decimal m_TipAmount;

	private string m_AccountNumber;

	private string m_BinValue;

	private string m_CardHolderName;

	private string m_CardLogo;

	private string m_CurrencyCode;

	private string m_EntryMode;

	private string m_PaymentType;

	private Signature m_Signature;

	private string m_TerminalId;

	private decimal m_TotalAmount;

	private string m_ApprovalNumber;

	private bool m_IsApproved;

	private Processor m_ProcessorResponse;

	private string m_StatusCode;

	private string m_TransactionDateTime;

	private string m_TransactionId;

	private List<ApiError> m_Errors;

	private List<ApiLink> m_Links;

	private List<string> m_Logs;

	private string m_Type;

	private List<ApiWarning> m_Warnings;

	[XmlElement("cashbackAmount")]
	public decimal CashbackAmount
	{
		get
		{
			return m_CashbackAmount;
		}
		set
		{
			m_CashbackAmount = value;
		}
	}

	[XmlElement("debitSurchargeAmount")]
	public decimal DebitSurchargeAmount
	{
		get
		{
			return m_DebitSurchargeAmount;
		}
		set
		{
			m_DebitSurchargeAmount = value;
		}
	}

	[XmlElement("approvedAmount")]
	public decimal ApprovedAmount
	{
		get
		{
			return m_ApprovedAmount;
		}
		set
		{
			m_ApprovedAmount = value;
		}
	}

	[XmlElement("convenienceFeeAmount")]
	public decimal ConvenienceFeeAmount
	{
		get
		{
			return m_ConvenienceFeeAmount;
		}
		set
		{
			m_ConvenienceFeeAmount = value;
		}
	}

	[XmlElement("subTotalAmount")]
	public decimal SubTotalAmount
	{
		get
		{
			return m_SubTotalAmount;
		}
		set
		{
			m_SubTotalAmount = value;
		}
	}

	[XmlElement("tipAmount")]
	public decimal TipAmount
	{
		get
		{
			return m_TipAmount;
		}
		set
		{
			m_TipAmount = value;
		}
	}

	[XmlElement("accountNumber")]
	public string AccountNumber
	{
		get
		{
			return m_AccountNumber;
		}
		set
		{
			m_AccountNumber = value;
		}
	}

	[XmlElement("binValue")]
	public string BinValue
	{
		get
		{
			return m_BinValue;
		}
		set
		{
			m_BinValue = value;
		}
	}

	[XmlElement("cardHolderName")]
	public string CardHolderName
	{
		get
		{
			return m_CardHolderName;
		}
		set
		{
			m_CardHolderName = value;
		}
	}

	[XmlElement("cardLogo")]
	public string CardLogo
	{
		get
		{
			return m_CardLogo;
		}
		set
		{
			m_CardLogo = value;
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

	[XmlElement("entryMode")]
	public string EntryMode
	{
		get
		{
			return m_EntryMode;
		}
		set
		{
			m_EntryMode = value;
		}
	}

	[XmlElement("paymentType")]
	public string PaymentType
	{
		get
		{
			return m_PaymentType;
		}
		set
		{
			m_PaymentType = value;
		}
	}

	[XmlElement("signature")]
	public Signature Signature
	{
		get
		{
			return m_Signature;
		}
		set
		{
			m_Signature = value;
		}
	}

	[XmlElement("terminalId")]
	public string TerminalId
	{
		get
		{
			return m_TerminalId;
		}
		set
		{
			m_TerminalId = value;
		}
	}

	[XmlElement("totalAmount")]
	public decimal TotalAmount
	{
		get
		{
			return m_TotalAmount;
		}
		set
		{
			m_TotalAmount = value;
		}
	}

	[XmlElement("approvalNumber")]
	public string ApprovalNumber
	{
		get
		{
			return m_ApprovalNumber;
		}
		set
		{
			m_ApprovalNumber = value;
		}
	}

	[XmlElement("isApproved")]
	public bool IsApproved
	{
		get
		{
			return m_IsApproved;
		}
		set
		{
			m_IsApproved = value;
		}
	}

	[XmlElement("_processor")]
	public Processor ProcessorResponse
	{
		get
		{
			return m_ProcessorResponse;
		}
		set
		{
			m_ProcessorResponse = value;
		}
	}

	[XmlElement("statusCode")]
	public string StatusCode
	{
		get
		{
			return m_StatusCode;
		}
		set
		{
			m_StatusCode = value;
		}
	}

	[XmlElement("transactionDateTime")]
	public string TransactionDateTime
	{
		get
		{
			return m_TransactionDateTime;
		}
		set
		{
			m_TransactionDateTime = value;
		}
	}

	[XmlElement("transactionId")]
	public string TransactionId
	{
		get
		{
			return m_TransactionId;
		}
		set
		{
			m_TransactionId = value;
		}
	}

	[XmlArrayItem(ElementName = "error")]
	[XmlArray(ElementName = "_errors")]
	public List<ApiError> Errors
	{
		get
		{
			return m_Errors;
		}
		set
		{
			m_Errors = value;
		}
	}

	[XmlElement("_hasErrors")]
	public bool HasErrors
	{
		get
		{
			return Errors != null && Errors.Count > 0;
		}
		set
		{
		}
	}

	[XmlArray(ElementName = "_links")]
	[XmlArrayItem(ElementName = "link")]
	public List<ApiLink> Links
	{
		get
		{
			return m_Links;
		}
		set
		{
			m_Links = value;
		}
	}

	[XmlArray(ElementName = "_logs")]
	[XmlArrayItem(ElementName = "log")]
	public List<string> Logs
	{
		get
		{
			return m_Logs;
		}
		set
		{
			m_Logs = value;
		}
	}

	[XmlElement("_type")]
	public string Type
	{
		get
		{
			return m_Type;
		}
		set
		{
			m_Type = value;
		}
	}

	[XmlArray(ElementName = "_warnings")]
	[XmlArrayItem(ElementName = "warning")]
	public List<ApiWarning> Warnings
	{
		get
		{
			return m_Warnings;
		}
		set
		{
			m_Warnings = value;
		}
	}
}
