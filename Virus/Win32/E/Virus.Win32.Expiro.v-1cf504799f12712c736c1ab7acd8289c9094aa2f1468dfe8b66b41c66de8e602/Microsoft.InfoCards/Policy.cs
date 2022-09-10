using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.ServiceModel;
using System.Xml;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class Policy
{
	private string m_policyXml = string.Empty;

	private string[] m_requiredClaimUris;

	private string[] m_optionalClaimUris;

	private uint m_keySize;

	private bool m_keySizeSpecified;

	private bool m_keyTypeSpecified;

	private SecurityKeyTypeInternal m_keyType = SecurityKeyTypeInternal.AsymmetricKey;

	private string m_requestType;

	private MemoryStream m_unprocessedPolicyElements;

	private OptionalRstParameters m_optionalRstParams = new OptionalRstParameters();

	private EndpointAddress m_policyAppliesToEpr;

	private bool m_nonWhiteListElementFound;

	private List<string> m_nonWhiteListElements = new List<string>();

	private ProtocolProfile m_protocolProfile;

	public string RequestType => m_requestType;

	public string PolicyXml => m_policyXml;

	public OptionalRstParameters OptionalRstParams => m_optionalRstParams;

	public string[] RequiredClaims => m_requiredClaimUris;

	public string[] OptionalClaims => m_optionalClaimUris;

	public SecurityKeyTypeInternal KeyType => m_keyType;

	public bool KeyTypeSpecified => m_keyTypeSpecified;

	public EndpointAddress PolicyAppliesTo => m_policyAppliesToEpr;

	public MemoryStream UnprocessedPolicyElements => m_unprocessedPolicyElements;

	public bool KeySizeSpecified => m_keySizeSpecified;

	public uint KeySize => m_keySize;

	public bool NonWhiteListElementsFound => m_nonWhiteListElementFound;

	public List<string> NonWhiteListElements => m_nonWhiteListElements;

	public ProtocolProfile ProtocolVersionProfile => m_protocolProfile;

	private Policy()
	{
	}

	public Policy(string originalPolicyXml, string rstPolicyXml)
	{
		m_policyXml = originalPolicyXml;
		ParsePolicyXml(rstPolicyXml);
	}

	public static Policy CreateMergedPolicy(string originalPolicyXml, Policy primary, Policy secondary)
	{
		Policy policy = new Policy();
		policy.m_policyXml = originalPolicyXml;
		policy.m_requiredClaimUris = ((primary.m_requiredClaimUris != null) ? primary.m_requiredClaimUris : secondary.m_requiredClaimUris);
		policy.m_optionalClaimUris = ((primary.m_optionalClaimUris != null) ? primary.m_optionalClaimUris : secondary.m_optionalClaimUris);
		policy.m_requestType = ((!string.IsNullOrEmpty(primary.m_requestType)) ? primary.m_requestType : secondary.m_requestType);
		policy.m_unprocessedPolicyElements = primary.m_unprocessedPolicyElements;
		policy.m_policyAppliesToEpr = (((EndpointAddress)null != primary.m_policyAppliesToEpr) ? primary.m_policyAppliesToEpr : secondary.m_policyAppliesToEpr);
		policy.m_keySize = (primary.m_keySizeSpecified ? primary.m_keySize : secondary.m_keySize);
		policy.m_keyType = (primary.m_keyTypeSpecified ? primary.m_keyType : secondary.m_keyType);
		policy.m_nonWhiteListElements = new List<string>();
		policy.m_nonWhiteListElementFound = primary.m_nonWhiteListElementFound || secondary.m_nonWhiteListElementFound;
		if (primary.m_nonWhiteListElementFound)
		{
			policy.m_nonWhiteListElements.AddRange(primary.m_nonWhiteListElements);
		}
		if (secondary.m_nonWhiteListElementFound)
		{
			policy.m_nonWhiteListElements.AddRange(secondary.m_nonWhiteListElements);
		}
		InfoCardTrace.Assert(null != primary.m_protocolProfile, "Received Null Protocol Profile in the Primary Policy", new object[0]);
		policy.m_protocolProfile = primary.ProtocolVersionProfile;
		policy.m_optionalRstParams = OptionalRstParameters.CreateMergedParameters(primary.OptionalRstParams, secondary.OptionalRstParams);
		return policy;
	}

	public void ParsePolicyXml(string policyXml)
	{
		XmlReader xmlReader = InfoCardSchemas.CreateReader(policyXml);
		try
		{
			m_protocolProfile = new ProtocolProfile(policyXml);
			bool isEmptyElement = xmlReader.IsEmptyElement;
			xmlReader.ReadStartElement();
			if (isEmptyElement)
			{
				return;
			}
			while (xmlReader.IsStartElement())
			{
				if (InfoCardConstants.DoesPolicyElementsToBeProcessedListContain(xmlReader.NamespaceURI, xmlReader.LocalName))
				{
					bool flag = false;
					if (xmlReader.IsStartElement(ProtocolVersionProfile.WSTrust.SignatureAlgorithm, ProtocolVersionProfile.WSTrust.Namespace))
					{
						ReadSignatureAlgorithm(xmlReader);
						flag = true;
					}
					else if (xmlReader.IsStartElement(ProtocolVersionProfile.WSTrust.EncryptionAlgorithm, ProtocolVersionProfile.WSTrust.Namespace))
					{
						ReadEncryptionAlgorithm(xmlReader);
						flag = true;
					}
					else if (xmlReader.IsStartElement(ProtocolVersionProfile.WSTrust.CanonicalizationAlgorithm, ProtocolVersionProfile.WSTrust.Namespace))
					{
						ReadCanonicalizationAlgorithm(xmlReader);
						flag = true;
					}
					else if (xmlReader.IsStartElement(ProtocolVersionProfile.WSTrust.SignWith, ProtocolVersionProfile.WSTrust.Namespace))
					{
						ReadSignWith(xmlReader);
						flag = true;
					}
					else if (xmlReader.IsStartElement(ProtocolVersionProfile.WSTrust.ClaimsElement, ProtocolVersionProfile.WSTrust.Namespace))
					{
						ReadClaims(xmlReader);
						flag = true;
					}
					else if (xmlReader.IsStartElement(ProtocolVersionProfile.WSTrust.TokenType, ProtocolVersionProfile.WSTrust.Namespace))
					{
						ReadTokenType(xmlReader);
						flag = true;
					}
					else if (xmlReader.IsStartElement(ProtocolVersionProfile.WSTrust.KeyType, ProtocolVersionProfile.WSTrust.Namespace))
					{
						ReadKeyType(xmlReader);
						flag = true;
					}
					else if (xmlReader.IsStartElement(ProtocolVersionProfile.WSTrust.KeySize, ProtocolVersionProfile.WSTrust.Namespace))
					{
						ReadKeySize(xmlReader);
						flag = true;
					}
					else if (xmlReader.IsStartElement(ProtocolVersionProfile.WSTrust.EncryptWith, ProtocolVersionProfile.WSTrust.Namespace))
					{
						ReadEncryptWith(xmlReader);
						flag = true;
					}
					else if (xmlReader.IsStartElement(ProtocolVersionProfile.WSTrust.RequestType, ProtocolVersionProfile.WSTrust.Namespace))
					{
						ReadRequestType(xmlReader);
						flag = true;
					}
					else if (XmlNames.WSSpecificationVersion.WSTrustOasis2007 == ProtocolVersionProfile.WSTrust.Version && xmlReader.IsStartElement(ProtocolVersionProfile.WSTrust.SecondaryParameters, ProtocolVersionProfile.WSTrust.Namespace))
					{
						ReadSecondaryParameters(xmlReader);
					}
					else if (XmlNames.WSSpecificationVersion.WSTrustOasis2007 == ProtocolVersionProfile.WSTrust.Version && xmlReader.IsStartElement(ProtocolVersionProfile.WSTrust.KeyWrapAlgorithm, ProtocolVersionProfile.WSTrust.Namespace))
					{
						ReadKeyWrapAlgorithm(xmlReader);
						flag = true;
					}
					else if (xmlReader.IsStartElement(ProtocolVersionProfile.WSPolicy.AppliesTo, ProtocolVersionProfile.WSPolicy.Namespace))
					{
						ReadAppliesTo(xmlReader);
						flag = true;
					}
					else
					{
						xmlReader.Skip();
					}
					if (flag)
					{
						xmlReader.ReadEndElement();
					}
				}
				else
				{
					if (!InfoCardConstants.DoesLocalTokenFactoryWhiteListContain(xmlReader.NamespaceURI, xmlReader.LocalName))
					{
						m_nonWhiteListElementFound = true;
						m_nonWhiteListElements.Add(xmlReader.LocalName);
					}
					CopyUnprocessedPolicyElements(xmlReader);
				}
			}
			xmlReader.ReadEndElement();
		}
		catch (FormatException inner)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new PolicyValidationException(SR.GetString("InvalidPolicySpecified"), inner));
		}
		catch (XmlException inner2)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new PolicyValidationException(SR.GetString("InvalidPolicySpecified"), inner2));
		}
		catch (InvalidOperationException inner3)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new PolicyValidationException(SR.GetString("InvalidPolicySpecified"), inner3));
		}
	}

	private void ReadClaims(XmlReader reader)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		InfoCardTrace.ThrowInvalidArgumentConditional(ProtocolVersionProfile.WSTrust.ClaimsElement != reader.LocalName || ProtocolVersionProfile.WSTrust.Namespace != reader.NamespaceURI, reader.LocalName);
		if (XmlNodeType.Element != reader.NodeType)
		{
			return;
		}
		if (reader.IsEmptyElement)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new PolicyValidationException(SR.GetString("NoClaimsFoundInPolicy")));
		}
		if (!reader.IsStartElement(ProtocolVersionProfile.WSTrust.ClaimsElement, ProtocolVersionProfile.WSTrust.Namespace))
		{
			return;
		}
		if (reader.IsEmptyElement)
		{
			reader.Read();
		}
		else
		{
			reader.Read();
			while (reader.IsStartElement())
			{
				if (reader.IsStartElement("ClaimType", "http://schemas.xmlsoap.org/ws/2005/05/identity"))
				{
					if (XmlNodeType.EndElement == reader.NodeType)
					{
						break;
					}
					string attribute = reader.GetAttribute("Uri", "http://schemas.xmlsoap.org/ws/2005/05/identity");
					if (string.IsNullOrEmpty(attribute))
					{
						attribute = reader.GetAttribute("Uri");
					}
					if (string.IsNullOrEmpty(attribute))
					{
						throw InfoCardTrace.ThrowHelperError((Exception)(object)new PolicyValidationException(SR.GetString("ServiceInvalidClaimUri")));
					}
					string attribute2 = reader.GetAttribute("Optional");
					bool flag = false;
					if (!string.IsNullOrEmpty(attribute2))
					{
						flag = XmlConvert.ToBoolean(attribute2);
					}
					bool flag2 = false;
					bool flag3 = false;
					foreach (string item in list)
					{
						if (item == attribute)
						{
							flag3 = true;
							break;
						}
					}
					foreach (string item2 in list2)
					{
						if (item2 == attribute)
						{
							flag2 = true;
							flag3 = true;
							break;
						}
					}
					if (flag)
					{
						if (!flag3)
						{
							list2.Add(attribute);
						}
					}
					else if (!flag3)
					{
						list.Add(attribute);
					}
					else if (flag2)
					{
						list2.Remove(attribute);
						list.Add(attribute);
					}
					if (reader.IsEmptyElement)
					{
						reader.Read();
						continue;
					}
					reader.Read();
					reader.ReadEndElement();
				}
				else
				{
					reader.Skip();
				}
			}
		}
		InfoCardTrace.ThrowInvalidArgumentConditional(XmlNodeType.EndElement != reader.NodeType, reader.NodeType.ToString());
		m_requiredClaimUris = list.ToArray();
		m_optionalClaimUris = list2.ToArray();
	}

	private void ReadTokenType(XmlReader reader)
	{
		InfoCardTrace.ThrowInvalidArgumentConditional(ProtocolVersionProfile.WSTrust.TokenType != reader.LocalName || ProtocolVersionProfile.WSTrust.Namespace != reader.NamespaceURI, reader.LocalName);
		m_optionalRstParams.TokenType = reader.ReadString();
	}

	public void ReadAppliesTo(XmlReader reader)
	{
		InfoCardTrace.ThrowInvalidArgumentConditional(ProtocolVersionProfile.WSPolicy.AppliesTo != reader.LocalName || ProtocolVersionProfile.WSPolicy.Namespace != reader.NamespaceURI, reader.LocalName);
		if (reader.IsEmptyElement)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new PolicyValidationException(SR.GetString("InvalidAppliesToInPolicy", new object[1] { SR.GetString("AppliesToMustOnlyHaveEndpointAddress") })));
		}
		reader.Read();
		EndpointAddress policyAppliesToEpr = null;
		if (XmlNodeType.EndElement != reader.NodeType)
		{
			try
			{
				policyAppliesToEpr = EndpointAddress.ReadFrom(XmlDictionaryReader.CreateDictionaryReader(reader.ReadSubtree()));
				reader.ReadEndElement();
			}
			catch (Exception ex)
			{
				if (InfoCardTrace.IsFatal(ex))
				{
					throw;
				}
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new PolicyValidationException(SR.GetString("InvalidAppliesToInPolicy", new object[1] { SR.GetString("AppliesToMustOnlyHaveEndpointAddress") }), ex));
			}
			if (reader.IsStartElement())
			{
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new PolicyValidationException(SR.GetString("InvalidAppliesToInPolicy", new object[1] { SR.GetString("AppliesToMustOnlyHaveEndpointAddress") })));
			}
		}
		m_policyAppliesToEpr = policyAppliesToEpr;
	}

	private void ReadKeyType(XmlReader reader)
	{
		InfoCardTrace.ThrowInvalidArgumentConditional(ProtocolVersionProfile.WSTrust.KeyType != reader.LocalName || ProtocolVersionProfile.WSTrust.Namespace != reader.NamespaceURI, reader.LocalName);
		Uri uri = new Uri(reader.ReadString());
		if (ProtocolVersionProfile.WSTrust.KeyTypeSymmetric.Equals(uri))
		{
			m_keyType = SecurityKeyTypeInternal.SymmetricKey;
		}
		else if (ProtocolVersionProfile.WSTrust.KeyTypeAsymmetric.Equals(uri))
		{
			m_keyType = SecurityKeyTypeInternal.AsymmetricKey;
		}
		else
		{
			if (!ProtocolVersionProfile.WSTrust.KeyTypeBearer.Equals(uri))
			{
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new PolicyValidationException(SR.GetString("KeyTypeNotRecognized", new object[1] { uri.ToString() })));
			}
			m_keyType = SecurityKeyTypeInternal.NoKey;
		}
		m_keyTypeSpecified = true;
	}

	private void ReadKeySize(XmlReader reader)
	{
		InfoCardTrace.ThrowInvalidArgumentConditional(ProtocolVersionProfile.WSTrust.KeySize != reader.LocalName || ProtocolVersionProfile.WSTrust.Namespace != reader.NamespaceURI, reader.LocalName);
		try
		{
			m_keySize = Convert.ToUInt32(reader.ReadString(), CultureInfo.InvariantCulture);
		}
		catch (FormatException inner)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new PolicyValidationException(SR.GetString("ServiceBadKeySizeInPolicy"), inner));
		}
		catch (OverflowException inner2)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new PolicyValidationException(SR.GetString("ServiceBadKeySizeInPolicy"), inner2));
		}
		m_keySizeSpecified = true;
	}

	private void ReadSignatureAlgorithm(XmlReader reader)
	{
		InfoCardTrace.ThrowInvalidArgumentConditional(ProtocolVersionProfile.WSTrust.SignatureAlgorithm != reader.LocalName || ProtocolVersionProfile.WSTrust.Namespace != reader.NamespaceURI, reader.LocalName);
		m_optionalRstParams.SignatureAlgorithm = reader.ReadString();
	}

	private void ReadEncryptionAlgorithm(XmlReader reader)
	{
		InfoCardTrace.ThrowInvalidArgumentConditional(ProtocolVersionProfile.WSTrust.EncryptionAlgorithm != reader.LocalName || ProtocolVersionProfile.WSTrust.Namespace != reader.NamespaceURI, reader.LocalName);
		m_optionalRstParams.EncryptionAlgorithm = reader.ReadString();
	}

	private void ReadCanonicalizationAlgorithm(XmlReader reader)
	{
		InfoCardTrace.ThrowInvalidArgumentConditional(ProtocolVersionProfile.WSTrust.CanonicalizationAlgorithm != reader.LocalName || ProtocolVersionProfile.WSTrust.Namespace != reader.NamespaceURI, reader.LocalName);
		m_optionalRstParams.CanonicalizationAlgorithm = reader.ReadString();
	}

	private void ReadEncryptWith(XmlReader reader)
	{
		InfoCardTrace.ThrowInvalidArgumentConditional(ProtocolVersionProfile.WSTrust.EncryptWith != reader.LocalName || ProtocolVersionProfile.WSTrust.Namespace != reader.NamespaceURI, reader.LocalName);
		m_optionalRstParams.EncryptWith = reader.ReadString();
	}

	private void ReadSignWith(XmlReader reader)
	{
		InfoCardTrace.ThrowInvalidArgumentConditional(ProtocolVersionProfile.WSTrust.SignWith != reader.LocalName || ProtocolVersionProfile.WSTrust.Namespace != reader.NamespaceURI, reader.LocalName);
		m_optionalRstParams.SignWith = reader.ReadString();
	}

	private void ReadRequestType(XmlReader reader)
	{
		InfoCardTrace.ThrowInvalidArgumentConditional(ProtocolVersionProfile.WSTrust.RequestType != reader.LocalName || ProtocolVersionProfile.WSTrust.Namespace != reader.NamespaceURI, reader.LocalName);
		m_requestType = reader.ReadString();
	}

	private void ReadSecondaryParameters(XmlReader reader)
	{
		InfoCardTrace.ThrowInvalidArgumentConditional(ProtocolVersionProfile.WSTrust.SecondaryParameters != reader.LocalName || ProtocolVersionProfile.WSTrust.Namespace != reader.NamespaceURI, reader.LocalName);
		while (reader.IsStartElement())
		{
			reader.Skip();
		}
	}

	private void ReadKeyWrapAlgorithm(XmlReader reader)
	{
		InfoCardTrace.ThrowInvalidArgumentConditional(ProtocolVersionProfile.WSTrust.KeyWrapAlgorithm != reader.LocalName || ProtocolVersionProfile.WSTrust.Namespace != reader.NamespaceURI, reader.LocalName);
		m_optionalRstParams.KeyWrapAlgorithm = reader.ReadString();
	}

	private void CopyUnprocessedPolicyElements(XmlReader reader)
	{
		if (m_unprocessedPolicyElements == null)
		{
			m_unprocessedPolicyElements = new MemoryStream();
		}
		XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
		xmlWriterSettings.OmitXmlDeclaration = true;
		XmlWriter xmlWriter = XmlWriter.Create(m_unprocessedPolicyElements, xmlWriterSettings);
		xmlWriter.WriteNode(reader, defattr: true);
		xmlWriter.Flush();
	}
}
