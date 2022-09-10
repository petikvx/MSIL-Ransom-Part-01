using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IdentityModel.Policy;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;
using System.Security.Cryptography;
using System.ServiceModel.Security.Tokens;
using System.Xml;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal static class RequestSecurityTokenResponseHelper
{
	private class RequestSecurityTokenResponse
	{
		private int m_keySize;

		private bool m_keySizeSpecified;

		private DateTime m_created = DateTime.UtcNow;

		private DateTime m_expires = DateTime.UtcNow.AddHours(1.0);

		private string m_requestType;

		private SecurityKeyIdentifierClause m_requestedAttachedReference;

		private SecurityKeyIdentifierClause m_requestedUnattachedReference;

		private SecurityToken m_entropyToken;

		private string m_computedKeyAlgorithm;

		private DisplayToken m_displayToken;

		private SecurityKeyTypeInternal? m_keyType;

		private string m_tokenType;

		private XmlElement m_issuedTokenElement;

		private SecurityToken m_proofToken;

		public int KeySize
		{
			set
			{
				m_keySize = value;
				m_keySizeSpecified = true;
			}
		}

		public SecurityKeyTypeInternal? KeyType
		{
			get
			{
				return m_keyType;
			}
			set
			{
				m_keyType = value;
			}
		}

		public DateTime Created
		{
			get
			{
				return m_created;
			}
			set
			{
				m_created = value;
			}
		}

		public DateTime Expires
		{
			get
			{
				return m_expires;
			}
			set
			{
				m_expires = value;
			}
		}

		public SecurityKeyIdentifierClause RequestedAttachedReference
		{
			get
			{
				return m_requestedAttachedReference;
			}
			set
			{
				m_requestedAttachedReference = value;
			}
		}

		public SecurityKeyIdentifierClause RequestedUnattachedReference
		{
			get
			{
				return m_requestedUnattachedReference;
			}
			set
			{
				m_requestedUnattachedReference = value;
			}
		}

		public string TokenType
		{
			set
			{
				m_tokenType = value;
			}
		}

		public SecurityToken EntropyToken
		{
			get
			{
				return m_entropyToken;
			}
			set
			{
				m_entropyToken = value;
			}
		}

		public string ComputedKeyAlgorithm
		{
			get
			{
				return m_computedKeyAlgorithm;
			}
			set
			{
				m_computedKeyAlgorithm = value;
			}
		}

		public DisplayToken DisplayToken
		{
			get
			{
				return m_displayToken;
			}
			set
			{
				m_displayToken = value;
			}
		}

		public XmlElement IssuedTokenElement
		{
			get
			{
				return m_issuedTokenElement;
			}
			set
			{
				m_issuedTokenElement = value;
			}
		}

		public SecurityToken ProofToken
		{
			get
			{
				return m_proofToken;
			}
			set
			{
				m_proofToken = value;
			}
		}

		public string RequestType
		{
			get
			{
				return m_requestType;
			}
			set
			{
				m_requestType = value;
			}
		}

		public int GetIntelligentKeySize(bool symmetric, int rstKeySize)
		{
			if (symmetric)
			{
				if (!m_keySizeSpecified)
				{
					return rstKeySize;
				}
				return m_keySize;
			}
			throw InfoCardTrace.ThrowHelperError((Exception)new InvalidOperationException());
		}

		public static byte[] ComputeCombinedKey(byte[] requestorEntropy, byte[] issuerEntropy, int keySize)
		{
			if (requestorEntropy == null)
			{
				throw InfoCardTrace.ThrowHelperArgumentNull("requestorEntropy");
			}
			if (issuerEntropy == null)
			{
				throw InfoCardTrace.ThrowHelperArgumentNull("issuerEntropy");
			}
			InfoCardTrace.Assert(keySize > 0, "Keysize must be > 0", new object[0]);
			Psha1DerivedKeyGenerator psha1DerivedKeyGenerator = new Psha1DerivedKeyGenerator(requestorEntropy);
			return psha1DerivedKeyGenerator.GenerateDerivedKey(new byte[0], issuerEntropy, keySize, 0);
		}

		public void ValidateRstrContents(SecurityKeyTypeInternal keyTypeExpected)
		{
			if (IssuedTokenElement == null)
			{
				throw InfoCardTrace.ThrowHelperError((Exception)new InvalidOperationException(SR.GetString("NoIssuedTokenXml")));
			}
			if (KeyType.HasValue && keyTypeExpected != KeyType)
			{
				throw InfoCardTrace.ThrowHelperError((Exception)new InvalidOperationException(SR.GetString("ProofKeyTypeMismatch")));
			}
			if (keyTypeExpected == SecurityKeyTypeInternal.SymmetricKey)
			{
				return;
			}
			if (SecurityKeyTypeInternal.AsymmetricKey == keyTypeExpected)
			{
				if (ProofToken == null)
				{
					return;
				}
				throw InfoCardTrace.ThrowHelperError((Exception)new InvalidOperationException(SR.GetString("ProofTokenXmlUnexpectedInRstr")));
			}
			InfoCardTrace.Assert(SecurityKeyTypeInternal.NoKey == keyTypeExpected, "Bad enum member for SecurityKeyTypeInternal", new object[0]);
			if (ProofToken == null)
			{
				return;
			}
			throw InfoCardTrace.ThrowHelperError((Exception)new InvalidOperationException(SR.GetString("ProofTokenXmlUnexpectedInRstr")));
		}
	}

	private static SecurityToken s_noProofToken = (SecurityToken)new UserNameSecurityToken("noproof", "noproof", "noproof");

	private static RequestSecurityTokenResponse ReadRequestSecurityTokenResponse(XmlDictionaryReader reader, SecurityTokenSerializer tokenSerializer, SecurityTokenResolver resolver, ProtocolProfile profile)
	{
		InfoCardTrace.Assert(null != reader, "null reader", new object[0]);
		InfoCardTrace.Assert(null != tokenSerializer, "null tokenSerializer", new object[0]);
		RequestSecurityTokenResponse requestSecurityTokenResponse = new RequestSecurityTokenResponse();
		if (XmlNames.WSSpecificationVersion.WSTrustOasis2007 == profile.WSTrust.Version)
		{
			reader.ReadFullStartElement(profile.WSTrust.RequestSecurityTokenResponseCollection, profile.WSTrust.Namespace);
		}
		reader.ReadFullStartElement(profile.WSTrust.RequestSecurityTokenResponse, profile.WSTrust.Namespace);
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		bool flag4 = false;
		bool flag5 = false;
		bool flag6 = false;
		bool flag7 = false;
		bool flag8 = false;
		bool flag9 = false;
		bool flag10 = false;
		bool flag11 = false;
		requestSecurityTokenResponse.Created = DateTime.UtcNow;
		DateTime maxValue = DateTime.MaxValue;
		requestSecurityTokenResponse.Expires = new DateTime(maxValue.Ticks - TimeSpan.FromDays(2.0).Ticks, DateTimeKind.Utc);
		if (!((XmlReader)(object)reader).IsStartElement())
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new XmlException(SR.GetString("ServiceSTSCommunicationFailed")));
		}
		while (true)
		{
			if (((XmlReader)(object)reader).IsStartElement())
			{
				if (((XmlReader)(object)reader).IsStartElement(profile.WSTrust.TokenType, profile.WSTrust.Namespace))
				{
					if (flag)
					{
						throw InfoCardTrace.ThrowHelperError((Exception)new XmlException(SR.GetString("MultipleTokenTypeElementsFound")));
					}
					requestSecurityTokenResponse.TokenType = ((XmlReader)(object)reader).ReadElementString();
					flag = true;
				}
				else if (((XmlReader)(object)reader).IsStartElement(profile.WSTrust.KeySize, profile.WSTrust.Namespace))
				{
					if (flag3)
					{
						throw InfoCardTrace.ThrowHelperError((Exception)new XmlException(SR.GetString("MultipleKeySizeElementsFound")));
					}
					int num = ((XmlReader)(object)reader).ReadElementContentAsInt();
					if (num <= 0)
					{
						throw InfoCardTrace.ThrowHelperError((Exception)new InvalidOperationException(SR.GetString("KeySizeMustBeGreaterThanZero")));
					}
					requestSecurityTokenResponse.KeySize = num;
					flag3 = true;
				}
				else if (((XmlReader)(object)reader).IsStartElement(profile.WSTrust.KeyType, profile.WSTrust.Namespace))
				{
					if (flag2)
					{
						throw InfoCardTrace.ThrowHelperError((Exception)new XmlException(SR.GetString("MultipleKeySizeElementsFound")));
					}
					string text = ((XmlReader)(object)reader).ReadElementContentAsString();
					Uri obj = new Uri(text);
					if (profile.WSTrust.KeyTypeSymmetric.Equals(obj))
					{
						requestSecurityTokenResponse.KeyType = SecurityKeyTypeInternal.SymmetricKey;
					}
					else if (profile.WSTrust.KeyTypeAsymmetric.Equals(obj))
					{
						requestSecurityTokenResponse.KeyType = SecurityKeyTypeInternal.AsymmetricKey;
					}
					else
					{
						if (!profile.WSTrust.KeyTypeBearer.Equals(obj))
						{
							throw InfoCardTrace.ThrowHelperError((Exception)new XmlException(SR.GetString("KeyTypeNotRecognized", new object[1] { text })));
						}
						requestSecurityTokenResponse.KeyType = SecurityKeyTypeInternal.NoKey;
					}
					flag2 = true;
				}
				else if (((XmlReader)(object)reader).IsStartElement(profile.WSTrust.Lifetime, profile.WSTrust.Namespace))
				{
					if (flag6)
					{
						throw InfoCardTrace.ThrowHelperError((Exception)new XmlException(SR.GetString("MultipleLifetimeElementsFound")));
					}
					((XmlReader)(object)reader).ReadStartElement();
					if (((XmlReader)(object)reader).IsStartElement("Created", "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd"))
					{
						requestSecurityTokenResponse.Created = ((XmlReader)(object)reader).ReadElementContentAsDateTime().ToUniversalTime();
					}
					if (((XmlReader)(object)reader).IsStartElement("Expires", "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd"))
					{
						requestSecurityTokenResponse.Expires = ((XmlReader)(object)reader).ReadElementContentAsDateTime().ToUniversalTime();
					}
					((XmlReader)(object)reader).ReadEndElement();
					flag6 = true;
				}
				else if (((XmlReader)(object)reader).IsStartElement(profile.WSTrust.RequestedSecurityToken, profile.WSTrust.Namespace))
				{
					if (flag7)
					{
						throw InfoCardTrace.ThrowHelperError((Exception)new XmlException(SR.GetString("MultipleRequestedSecurityTokenElementsFound")));
					}
					((XmlReader)(object)reader).ReadStartElement();
					((XmlReader)(object)reader).MoveToElement();
					XmlDocument xmlDocument = new XmlDocument();
					requestSecurityTokenResponse.IssuedTokenElement = xmlDocument.ReadNode((XmlReader)(object)reader) as XmlElement;
					((XmlReader)(object)reader).ReadEndElement();
					flag7 = true;
				}
				else if (((XmlReader)(object)reader).IsStartElement(profile.WSTrust.RequestedProofToken, profile.WSTrust.Namespace))
				{
					if (flag8)
					{
						throw InfoCardTrace.ThrowHelperError((Exception)new XmlException(SR.GetString("MultipleRequestedProofTokenElementsFound")));
					}
					((XmlReader)(object)reader).ReadStartElement();
					if (((XmlReader)(object)reader).IsStartElement(profile.WSTrust.ComputedKey, profile.WSTrust.Namespace))
					{
						requestSecurityTokenResponse.ComputedKeyAlgorithm = ((XmlReader)(object)reader).ReadElementString();
						if (profile.WSTrust.ComputedKeyAlgorithm != requestSecurityTokenResponse.ComputedKeyAlgorithm)
						{
							throw InfoCardTrace.ThrowHelperError((Exception)new NotImplementedException(SR.GetString("OnlyPSha1SupportedCurrently", new object[1] { requestSecurityTokenResponse.ComputedKeyAlgorithm })));
						}
					}
					else
					{
						requestSecurityTokenResponse.ProofToken = tokenSerializer.ReadToken((XmlReader)(object)reader, resolver);
					}
					((XmlReader)(object)reader).ReadEndElement();
					flag8 = true;
				}
				else if (((XmlReader)(object)reader).IsStartElement(profile.WSTrust.Entropy, profile.WSTrust.Namespace))
				{
					if (flag10)
					{
						throw InfoCardTrace.ThrowHelperError((Exception)new XmlException(SR.GetString("MultipleEntropyElementsFound")));
					}
					((XmlReader)(object)reader).ReadStartElement();
					requestSecurityTokenResponse.EntropyToken = tokenSerializer.ReadToken((XmlReader)(object)reader, resolver);
					((XmlReader)(object)reader).ReadEndElement();
					flag10 = true;
				}
				else if (((XmlReader)(object)reader).IsStartElement("RequestedDisplayToken", "http://schemas.xmlsoap.org/ws/2005/05/identity"))
				{
					if (flag9)
					{
						throw InfoCardTrace.ThrowHelperError((Exception)new XmlException(SR.GetString("MultipleRequestedDisplayTokenElementsFound")));
					}
					requestSecurityTokenResponse.DisplayToken = CreateDisplayToken(reader);
					flag9 = true;
				}
				else if (((XmlReader)(object)reader).IsStartElement(profile.WSTrust.RequestedAttachedReference, profile.WSTrust.Namespace))
				{
					if (flag4)
					{
						throw InfoCardTrace.ThrowHelperError((Exception)new XmlException(SR.GetString("MultipleRequestedAttachedReferenceElementsFound")));
					}
					((XmlReader)(object)reader).ReadStartElement();
					requestSecurityTokenResponse.RequestedAttachedReference = tokenSerializer.ReadKeyIdentifierClause((XmlReader)(object)reader);
					((XmlReader)(object)reader).ReadEndElement();
					flag4 = true;
				}
				else if (((XmlReader)(object)reader).IsStartElement(profile.WSTrust.RequestedUnattachedReference, profile.WSTrust.Namespace))
				{
					if (flag5)
					{
						throw InfoCardTrace.ThrowHelperError((Exception)new XmlException(SR.GetString("MultipleRequestedUnattachedReferenceElementsFound")));
					}
					((XmlReader)(object)reader).ReadStartElement();
					requestSecurityTokenResponse.RequestedUnattachedReference = tokenSerializer.ReadKeyIdentifierClause((XmlReader)(object)reader);
					((XmlReader)(object)reader).ReadEndElement();
					flag5 = true;
				}
				else if (((XmlReader)(object)reader).IsStartElement(profile.WSTrust.RequestType, profile.WSTrust.Namespace))
				{
					if (flag11)
					{
						throw InfoCardTrace.ThrowHelperError((Exception)new XmlException(SR.GetString("MultipleRequestTypeElementsFound")));
					}
					requestSecurityTokenResponse.RequestType = ((XmlReader)(object)reader).ReadElementContentAsString();
					if (profile.WSTrust.IssueRequestType != requestSecurityTokenResponse.RequestType)
					{
						throw InfoCardTrace.ThrowHelperError((Exception)new InvalidOperationException(SR.GetString("OnlyIssueRequestTypeSupported", new object[2]
						{
							requestSecurityTokenResponse.RequestType,
							profile.WSTrust.IssueRequestType
						})));
					}
					flag11 = true;
				}
				else
				{
					((XmlReader)(object)reader).Skip();
				}
				continue;
			}
			((XmlReader)(object)reader).ReadEndElement();
			if (XmlNames.WSSpecificationVersion.WSTrustOasis2007 != profile.WSTrust.Version)
			{
				break;
			}
			if (profile.WSTrust.RequestSecurityTokenResponseCollection == ((XmlReader)(object)reader).LocalName && profile.WSTrust.Namespace == ((XmlReader)(object)reader).NamespaceURI && ((XmlReader)(object)reader).NodeType == XmlNodeType.EndElement)
			{
				((XmlReader)(object)reader).ReadEndElement();
				break;
			}
			throw InfoCardTrace.ThrowHelperError((Exception)new XmlException(SR.GetString("ServiceSTSCommunicationFailed")));
		}
		return requestSecurityTokenResponse;
	}

	public static GenericXmlSecurityToken ProcessBearerTokenData(XmlDictionaryReader reader, SecurityTokenSerializer tokenSerializer, SecurityTokenResolver resolver, ProtocolProfile profile, out DisplayToken displayToken)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		RequestSecurityTokenResponse requestSecurityTokenResponse = ReadRequestSecurityTokenResponse(reader, tokenSerializer, resolver, profile);
		displayToken = requestSecurityTokenResponse.DisplayToken ?? new DisplayToken();
		requestSecurityTokenResponse.ValidateRstrContents(SecurityKeyTypeInternal.NoKey);
		SecurityToken val = s_noProofToken;
		return new GenericXmlSecurityToken(requestSecurityTokenResponse.IssuedTokenElement, val, requestSecurityTokenResponse.Created, requestSecurityTokenResponse.Expires, requestSecurityTokenResponse.RequestedAttachedReference, requestSecurityTokenResponse.RequestedUnattachedReference, (ReadOnlyCollection<IAuthorizationPolicy>)null);
	}

	public static GenericXmlSecurityToken ProcessSymmetricTokenData(XmlDictionaryReader reader, SecurityTokenSerializer tokenSerializer, SecurityTokenResolver resolver, byte[] clientEntropyForSymmetric, ProtocolProfile profile, out DisplayToken displayToken)
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		RequestSecurityTokenResponse requestSecurityTokenResponse = ReadRequestSecurityTokenResponse(reader, tokenSerializer, resolver, profile);
		displayToken = requestSecurityTokenResponse.DisplayToken ?? new DisplayToken();
		requestSecurityTokenResponse.ValidateRstrContents(SecurityKeyTypeInternal.SymmetricKey);
		if (requestSecurityTokenResponse.EntropyToken != null)
		{
			InfoCardTrace.Assert(profile.WSTrust.ComputedKeyAlgorithm == requestSecurityTokenResponse.ComputedKeyAlgorithm, "We already made sure it is PSHA1 while processing RSTR", new object[0]);
			SecurityToken entropyToken = requestSecurityTokenResponse.EntropyToken;
			BinarySecretSecurityToken val = (BinarySecretSecurityToken)(object)((entropyToken is BinarySecretSecurityToken) ? entropyToken : null);
			if (val == null)
			{
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new TrustExchangeException(SR.GetString("InvalidEntropyContents")));
			}
			int num = clientEntropyForSymmetric.Length * 8;
			int intelligentKeySize = requestSecurityTokenResponse.GetIntelligentKeySize(symmetric: true, num);
			if (intelligentKeySize != num)
			{
				throw InfoCardTrace.ThrowHelperError((Exception)new InvalidOperationException("SymmetricProofKeyLengthMismatch"));
			}
			byte[] array = RequestSecurityTokenResponse.ComputeCombinedKey(clientEntropyForSymmetric, val.GetKeyBytes(), num);
			requestSecurityTokenResponse.ProofToken = (SecurityToken)new BinarySecretSecurityToken(array);
		}
		else if (requestSecurityTokenResponse.ProofToken == null)
		{
			requestSecurityTokenResponse.ProofToken = (SecurityToken)new BinarySecretSecurityToken(clientEntropyForSymmetric);
		}
		return new GenericXmlSecurityToken(requestSecurityTokenResponse.IssuedTokenElement, requestSecurityTokenResponse.ProofToken, requestSecurityTokenResponse.Created, requestSecurityTokenResponse.Expires, requestSecurityTokenResponse.RequestedAttachedReference, requestSecurityTokenResponse.RequestedUnattachedReference, (ReadOnlyCollection<IAuthorizationPolicy>)null);
	}

	public static GenericXmlSecurityToken ProcessAsymmetricTokenData(XmlDictionaryReader reader, RSA rsa, SecurityTokenSerializer tokenSerializer, SecurityTokenResolver resolver, ProtocolProfile profile, out DisplayToken displayToken)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		InfoCardTrace.Assert(null != rsa, "null rsa", new object[0]);
		RequestSecurityTokenResponse requestSecurityTokenResponse = ReadRequestSecurityTokenResponse(reader, tokenSerializer, resolver, profile);
		displayToken = requestSecurityTokenResponse.DisplayToken ?? new DisplayToken();
		requestSecurityTokenResponse.ValidateRstrContents(SecurityKeyTypeInternal.AsymmetricKey);
		SecurityToken val = (SecurityToken)new RsaSecurityToken(rsa);
		return new GenericXmlSecurityToken(requestSecurityTokenResponse.IssuedTokenElement, val, requestSecurityTokenResponse.Created, requestSecurityTokenResponse.Expires, requestSecurityTokenResponse.RequestedAttachedReference, requestSecurityTokenResponse.RequestedUnattachedReference, (ReadOnlyCollection<IAuthorizationPolicy>)null);
	}

	private static DisplayToken CreateDisplayToken(XmlDictionaryReader reader)
	{
		InfoCardTrace.Assert(null != reader, "null reader", new object[0]);
		DisplayToken result = new DisplayToken();
		XmlReader xmlReader = InfoCardSchemas.CreateReader(((XmlReader)(object)reader).ReadOuterXml());
		try
		{
			xmlReader.ReadStartElement("RequestedDisplayToken", "http://schemas.xmlsoap.org/ws/2005/05/identity");
			xmlReader.ReadStartElement("DisplayToken", "http://schemas.xmlsoap.org/ws/2005/05/identity");
			while (xmlReader.IsStartElement())
			{
				if (xmlReader.IsStartElement("DisplayClaim", "http://schemas.xmlsoap.org/ws/2005/05/identity"))
				{
					List<DisplayClaim> list = new List<DisplayClaim>();
					while (xmlReader.IsStartElement())
					{
						if (xmlReader.IsStartElement("DisplayClaim", "http://schemas.xmlsoap.org/ws/2005/05/identity"))
						{
							DisplayClaim displayClaim = ReadDisplayClaim(xmlReader);
							if (displayClaim != null)
							{
								list.Add(displayClaim);
							}
						}
						else
						{
							xmlReader.Skip();
						}
					}
					result = new DisplayToken(list);
				}
				else if (xmlReader.IsStartElement("DisplayTokenText", "http://schemas.xmlsoap.org/ws/2005/05/identity"))
				{
					string attribute = xmlReader.GetAttribute("MimeType");
					string text = xmlReader.ReadElementContentAsString();
					if (!string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(attribute))
					{
						result = new DisplayToken(text, attribute);
					}
				}
				else
				{
					xmlReader.Skip();
				}
			}
			xmlReader.ReadEndElement();
			xmlReader.ReadEndElement();
			return result;
		}
		catch (Exception ex)
		{
			result = null;
			if (InfoCardTrace.IsFatal(ex))
			{
				throw;
			}
			return result;
		}
	}

	private static DisplayClaim ReadDisplayClaim(XmlReader reader)
	{
		if (!reader.IsStartElement("DisplayClaim", "http://schemas.xmlsoap.org/ws/2005/05/identity"))
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new XmlException(SR.GetString("UnexpectedElement")));
		}
		string name = string.Empty;
		List<string> list = new List<string>();
		string description = string.Empty;
		string empty = string.Empty;
		empty = reader.GetAttribute("Uri", "http://schemas.xmlsoap.org/ws/2005/05/identity");
		if (string.IsNullOrEmpty(empty))
		{
			empty = reader.GetAttribute("Uri");
		}
		bool isEmptyElement = reader.IsEmptyElement;
		reader.ReadStartElement();
		if (!isEmptyElement)
		{
			while (reader.IsStartElement())
			{
				if (reader.IsStartElement("DisplayTag", "http://schemas.xmlsoap.org/ws/2005/05/identity"))
				{
					name = reader.ReadElementContentAsString();
				}
				else if (reader.IsStartElement("DisplayValue", "http://schemas.xmlsoap.org/ws/2005/05/identity"))
				{
					list.Add(reader.ReadElementContentAsString());
				}
				else if (reader.IsStartElement("Description", "http://schemas.xmlsoap.org/ws/2005/05/identity"))
				{
					description = reader.ReadElementContentAsString();
				}
				else
				{
					reader.Skip();
				}
			}
			reader.ReadEndElement();
		}
		return new DisplayClaim(name, list, description, empty);
	}
}
