using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services.Protocols;
using System.Xml;
using System.Xml.Serialization;

namespace VaultMirror.Security;

[Serializable]
[DebuggerStepThrough]
[XmlType(Namespace = "http://AutodeskDM/Services/Security/01/02/2007/")]
[DesignerCategory("code")]
[GeneratedCode("System.Xml", "2.0.50727.42")]
[XmlRoot(Namespace = "http://AutodeskDM/Services/Security/01/02/2007/", IsNullable = false)]
public class SecurityHeader : SoapHeader
{
	private string ticketField;

	private long userIdField;

	private XmlAttribute[] anyAttrField;

	public string Ticket
	{
		get
		{
			return ticketField;
		}
		set
		{
			ticketField = value;
		}
	}

	public long UserId
	{
		get
		{
			return userIdField;
		}
		set
		{
			userIdField = value;
		}
	}

	[XmlAnyAttribute]
	public XmlAttribute[] AnyAttr
	{
		get
		{
			return anyAttrField;
		}
		set
		{
			anyAttrField = value;
		}
	}
}
