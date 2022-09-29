using System.Xml.Serialization;

namespace triPOS_vbnet;

public class Address
{
	private string m_BillingAddress2;

	private string m_BillingCity;

	private string m_BillingEmail;

	private string m_BillingName;

	private string m_BillingPhone;

	private string m_BillingPostalCode;

	private string m_BillingState;

	private string m_ShippingAddress1;

	private string m_ShippingAddress2;

	private string m_ShippingCity;

	private string m_ShippingEmail;

	private string m_ShippingName;

	private string m_ShippingPhone;

	private string m_ShippingPostalCode;

	private string m_ShippingState;

	[XmlElement("billingAddress1")]
	public string BillingAddress1 { get; set; }

	[XmlElement("billingAddress2")]
	public string BillingAddress2
	{
		get
		{
			return m_BillingAddress2;
		}
		set
		{
			m_BillingAddress2 = value;
		}
	}

	[XmlElement("billingCity")]
	public string BillingCity
	{
		get
		{
			return m_BillingCity;
		}
		set
		{
			m_BillingCity = value;
		}
	}

	[XmlElement("billingEmail")]
	public string BillingEmail
	{
		get
		{
			return m_BillingEmail;
		}
		set
		{
			m_BillingEmail = value;
		}
	}

	[XmlElement("billingName")]
	public string BillingName
	{
		get
		{
			return m_BillingName;
		}
		set
		{
			m_BillingName = value;
		}
	}

	[XmlElement("billingPhone")]
	public string BillingPhone
	{
		get
		{
			return m_BillingPhone;
		}
		set
		{
			m_BillingPhone = value;
		}
	}

	[XmlElement("billingPostalCode")]
	public string BillingPostalCode
	{
		get
		{
			return m_BillingPostalCode;
		}
		set
		{
			m_BillingPostalCode = value;
		}
	}

	[XmlElement("billingState")]
	public string BillingState
	{
		get
		{
			return m_BillingState;
		}
		set
		{
			m_BillingState = value;
		}
	}

	[XmlElement("shippingAddress1")]
	public string ShippingAddress1
	{
		get
		{
			return m_ShippingAddress1;
		}
		set
		{
			m_ShippingAddress1 = value;
		}
	}

	[XmlElement("shippingAddress2")]
	public string ShippingAddress2
	{
		get
		{
			return m_ShippingAddress2;
		}
		set
		{
			m_ShippingAddress2 = value;
		}
	}

	[XmlElement("shippingCity")]
	public string ShippingCity
	{
		get
		{
			return m_ShippingCity;
		}
		set
		{
			m_ShippingCity = value;
		}
	}

	[XmlElement("shippingEmail")]
	public string ShippingEmail
	{
		get
		{
			return m_ShippingEmail;
		}
		set
		{
			m_ShippingEmail = value;
		}
	}

	[XmlElement("shippingName")]
	public string ShippingName
	{
		get
		{
			return m_ShippingName;
		}
		set
		{
			m_ShippingName = value;
		}
	}

	[XmlElement("shippingPhone")]
	public string ShippingPhone
	{
		get
		{
			return m_ShippingPhone;
		}
		set
		{
			m_ShippingPhone = value;
		}
	}

	[XmlElement("shippingPostalCode")]
	public string ShippingPostalCode
	{
		get
		{
			return m_ShippingPostalCode;
		}
		set
		{
			m_ShippingPostalCode = value;
		}
	}

	[XmlElement("shippingState")]
	public string ShippingState
	{
		get
		{
			return m_ShippingState;
		}
		set
		{
			m_ShippingState = value;
		}
	}
}
