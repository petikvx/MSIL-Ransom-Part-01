using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens;
using System.ServiceModel;
using System.ServiceModel.Security;

namespace Microsoft.InfoCards;

internal class ProtocolProfile
{
	private XmlNames.IWSTrust m_iWSTrust = XmlNames.WSTrustXmlSoap2005.Instance;

	private XmlNames.IWSPolicy m_iWSPolicy = XmlNames.WSPolicyXmlSoap2004.Instance;

	private static WSSecurityTokenSerializer s_tokenSerializerDefault = new WSSecurityTokenSerializer(MessageSecurityVersion.get_Default().get_SecurityVersion(), true);

	private static WSSecurityTokenSerializer s_tokenSerializerWSTrust13 = new WSSecurityTokenSerializer(SecurityVersion.get_WSSecurity11(), TrustVersion.get_WSTrust13(), SecureConversationVersion.get_WSSecureConversation13(), false, (SamlSerializer)null, (SecurityStateEncoder)null, (IEnumerable<Type>)null);

	public XmlNames.IWSTrust WSTrust
	{
		get
		{
			return m_iWSTrust;
		}
		set
		{
			m_iWSTrust = value;
		}
	}

	public XmlNames.IWSPolicy WSPolicy => m_iWSPolicy;

	public MessageSecurityVersion MsgSecurityVersion
	{
		get
		{
			if (XmlNames.WSSpecificationVersion.WSTrustXmlSoap2005 == WSTrust.Version)
			{
				return MessageSecurityVersion.get_WSSecurity11WSTrustFebruary2005WSSecureConversationFebruary2005WSSecurityPolicy11();
			}
			if (XmlNames.WSSpecificationVersion.WSTrustOasis2007 == WSTrust.Version)
			{
				return MessageSecurityVersion.get_WSSecurity11WSTrust13WSSecureConversation13WSSecurityPolicy12();
			}
			return MessageSecurityVersion.get_Default();
		}
	}

	public WSSecurityTokenSerializer TokenSerializer
	{
		get
		{
			if (XmlNames.WSSpecificationVersion.WSTrustOasis2007 == WSTrust.Version)
			{
				return s_tokenSerializerWSTrust13;
			}
			return s_tokenSerializerDefault;
		}
	}

	public ProtocolProfile()
	{
	}

	public ProtocolProfile(string policyXml)
	{
		if (policyXml.Contains(XmlNames.WSTrustXmlSoap2005.Instance.Namespace))
		{
			m_iWSTrust = XmlNames.WSTrustXmlSoap2005.Instance;
		}
		else if (policyXml.Contains(XmlNames.WSTrustOasis2007.Instance.Namespace))
		{
			m_iWSTrust = XmlNames.WSTrustOasis2007.Instance;
		}
		if (policyXml.Contains(XmlNames.WSPolicyXmlSoap2004.Instance.Namespace))
		{
			m_iWSPolicy = XmlNames.WSPolicyXmlSoap2004.Instance;
		}
		else if (policyXml.Contains(XmlNames.WSPolicyW32007.Instance.Namespace))
		{
			m_iWSPolicy = XmlNames.WSPolicyW32007.Instance;
		}
	}
}
