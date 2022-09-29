using System.Xml.Serialization;

namespace triPOS_vbnet;

[XmlRoot("saleRequest", Namespace = "http://tripos.vantiv.com/2014/09/TriPos.Api")]
public class SaleRequest
{
	private Address m_Address;

	private decimal m_CashbackAmount;

	private decimal m_ConvenienceFeeAmount;

	private string m_EmvFallbackReason;

	private decimal m_TipAmount;

	private decimal m_TransactionAmount;

	private string m_ClerkNumber;

	private Configuration m_Configuration;

	private int m_LaneId;

	private string m_ReferenceNumber;

	private string m_ShiftId;

	private string m_TicketNumber;

	[XmlElement("address")]
	public Address Address
	{
		get
		{
			return m_Address;
		}
		set
		{
			m_Address = value;
		}
	}

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

	[XmlElement("emvFallbackReason")]
	public string EmvFallbackReason
	{
		get
		{
			return m_EmvFallbackReason;
		}
		set
		{
			m_EmvFallbackReason = value;
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

	[XmlElement("transactionAmount")]
	public decimal TransactionAmount
	{
		get
		{
			return m_TransactionAmount;
		}
		set
		{
			m_TransactionAmount = value;
		}
	}

	[XmlElement("clerkNumber")]
	public string ClerkNumber
	{
		get
		{
			return m_ClerkNumber;
		}
		set
		{
			m_ClerkNumber = value;
		}
	}

	[XmlElement("configuration")]
	public Configuration Configuration
	{
		get
		{
			return m_Configuration;
		}
		set
		{
			m_Configuration = value;
		}
	}

	[XmlElement("laneId")]
	public int LaneId
	{
		get
		{
			return m_LaneId;
		}
		set
		{
			m_LaneId = value;
		}
	}

	[XmlElement("referenceNumber")]
	public string ReferenceNumber
	{
		get
		{
			return m_ReferenceNumber;
		}
		set
		{
			m_ReferenceNumber = value;
		}
	}

	[XmlElement("shiftId")]
	public string ShiftId
	{
		get
		{
			return m_ShiftId;
		}
		set
		{
			m_ShiftId = value;
		}
	}

	[XmlElement("ticketNumber")]
	public string TicketNumber
	{
		get
		{
			return m_TicketNumber;
		}
		set
		{
			m_TicketNumber = value;
		}
	}

	public static SaleRequest GetSaleRequest()
	{
		SaleRequest saleRequest = new SaleRequest();
		saleRequest.Configuration = new Configuration();
		saleRequest.Address = new Address();
		saleRequest.Address.BillingAddress1 = "123 Sample Street";
		saleRequest.Address.BillingAddress2 = "Suite 101";
		saleRequest.Address.BillingCity = "Chandler";
		saleRequest.Address.BillingState = "AZ";
		saleRequest.Address.BillingPostalCode = "85224";
		saleRequest.ClerkNumber = "Clerk101";
		saleRequest.Configuration.CurrencyCode = "Usd";
		saleRequest.EmvFallbackReason = "None";
		saleRequest.LaneId = 9999;
		saleRequest.Configuration.MarketCode = "Retail";
		saleRequest.Configuration.AllowPartialApprovals = false;
		saleRequest.Configuration.CheckForDuplicateTransactions = true;
		saleRequest.ReferenceNumber = "Ref000001";
		saleRequest.ShiftId = "ShiftA";
		saleRequest.TicketNumber = "T0000001";
		saleRequest.TransactionAmount = 3.25m;
		return saleRequest;
	}
}
