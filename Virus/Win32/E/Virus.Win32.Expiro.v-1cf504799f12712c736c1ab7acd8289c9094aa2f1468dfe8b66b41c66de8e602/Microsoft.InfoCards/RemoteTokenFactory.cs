using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Security;
using System.ServiceModel.Security.Tokens;
using System.Xml;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class RemoteTokenFactory : TokenFactoryBase
{
	[ServiceContract(Namespace = "http://schemas.xmlsoap.org/ws/2005/05/identity", Name = "RequestBrowserToken")]
	internal interface ISts
	{
		[OperationContract(Name = "ProcessRequestSecurityTokenFeb2005", Action = "http://schemas.xmlsoap.org/ws/2005/02/trust/RST/Issue", ReplyAction = "http://schemas.xmlsoap.org/ws/2005/02/trust/RSTR/Issue", ProtectionLevel = ProtectionLevel.EncryptAndSign)]
		Message ProcessRequestSecurityTokenFeb2005(Message rstMessage);

		[OperationContract(Name = "ProcessRequestSecurityTokenWSTrust13", Action = "http://docs.oasis-open.org/ws-sx/ws-trust/200512/RST/Issue", ReplyAction = "http://docs.oasis-open.org/ws-sx/ws-trust/200512/RSTRC/IssueFinal", ProtectionLevel = ProtectionLevel.EncryptAndSign)]
		Message ProcessRequestSecurityTokenWSTrust13(Message rstMessage);
	}

	internal const string MetadataExchangeClientKey = "MetadataExchangeClientKey";

	private ServiceEndpoint m_endPoint;

	private ChannelFactory<ISts> m_channelFactory;

	private object m_channelChangeSync;

	private IWebProxy m_proxy;

	private ProtocolProfile m_protocolProfile;

	private Dictionary<string, bool> m_disclosedClaims;

	public RemoteTokenFactory(ServiceEndpoint endPoint, IWebProxy proxy)
	{
		m_endPoint = endPoint;
		m_channelChangeSync = new object();
		m_proxy = proxy;
	}

	protected override TokenDescriptor ProduceToken(InfoCard card, TokenCreationParameter parameter, TokenFactoryCredential credential, InfoCardPolicy policy, bool discloseOptional)
	{
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected O, but got Unknown
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected O, but got Unknown
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected O, but got Unknown
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected O, but got Unknown
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Expected O, but got Unknown
		//IL_0523: Unknown result type (might be due to invalid IL or missing references)
		//IL_052a: Expected O, but got Unknown
		//IL_06a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_077d: Expected O, but got Unknown
		InfoCardTrace.ThrowInvalidArgumentConditional(null == card, "card");
		InfoCardTrace.ThrowInvalidArgumentConditional(null == parameter, "parameter");
		InfoCardTrace.ThrowInvalidArgumentConditional(null == credential, "credential");
		InfoCardTrace.ThrowInvalidArgumentConditional(null == policy, "policy");
		RSACryptoServiceProvider rSACryptoServiceProvider = null;
		byte[] array = null;
		SymmetricAlgorithm symmetricAlgorithm = null;
		RSAKeyValue val = null;
		string internalTokenReference = string.Empty;
		string externalTokenReference = string.Empty;
		GenericXmlSecurityToken val2 = null;
		m_protocolProfile = policy.ProtocolVersionProfile;
		bool flag = false;
		RSATokenProvider rSATokenProvider = null;
		try
		{
			if (SecurityKeyTypeInternal.AsymmetricKey == policy.KeyType)
			{
				rSACryptoServiceProvider = card.GetPublicCryptography(policy.Recipient.GetIdentifier());
				flag = true;
				InfoCardTrace.Assert(null == array, "Null in in asymmetric case", new object[0]);
			}
			else if (policy.KeyType == SecurityKeyTypeInternal.SymmetricKey)
			{
				array = new byte[policy.GetIntelligentKeySize(isSelfIssuedCardSelected: false) / 8u];
				RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
				rNGCryptoServiceProvider.GetNonZeroBytes(array);
				InfoCardTrace.Assert(null == rSACryptoServiceProvider, "Null in symmetric case", new object[0]);
			}
			else
			{
				InfoCardTrace.Assert(null == rSACryptoServiceProvider, "Null in no proof key case", new object[0]);
				InfoCardTrace.Assert(null == array, "Null in no proof key case", new object[0]);
				InfoCardTrace.Assert(SecurityKeyTypeInternal.NoKey == policy.KeyType, "Null in no proof key case", new object[0]);
			}
			if (m_endPoint == null)
			{
				m_endPoint = DoMexExchange(parameter, m_proxy);
			}
			BindingElementCollection val3 = m_endPoint.get_Binding().CreateBindingElements();
			SecurityBindingElement val4 = val3.Find<SecurityBindingElement>();
			if (val4 == null)
			{
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new TrustExchangeException(SR.GetString("IndigoNoSuitableEndpointsForAddress", new object[1] { m_endPoint.get_Address().get_Uri() })));
			}
			if (val4.get_MessageSecurityVersion().get_TrustVersion() == TrustVersion.get_WSTrust13())
			{
				m_protocolProfile.WSTrust = XmlNames.WSTrustOasis2007.Instance;
			}
			else
			{
				m_protocolProfile.WSTrust = XmlNames.WSTrustXmlSoap2005.Instance;
			}
			Binding val5 = Utility.BuildBindingWithMaxMessageSize(m_endPoint.get_Binding());
			EndpointAddress address = m_endPoint.get_Address();
			if (flag)
			{
				SupportingTokenParameters val6;
				if (val4.get_OptionalOperationSupportingTokenParameters().ContainsKey(m_protocolProfile.WSTrust.RequestSecurityTokenAction))
				{
					val6 = val4.get_OptionalOperationSupportingTokenParameters()[m_protocolProfile.WSTrust.RequestSecurityTokenAction];
				}
				else
				{
					val6 = new SupportingTokenParameters();
					val4.get_OptionalOperationSupportingTokenParameters()[m_protocolProfile.WSTrust.RequestSecurityTokenAction] = val6;
				}
				bool flag2 = true;
				foreach (SecurityTokenParameters item in val6.get_Endorsing())
				{
					if (item is RsaSecurityTokenParameters)
					{
						flag2 = false;
						break;
					}
				}
				if (flag2)
				{
					RsaSecurityTokenParameters val7 = new RsaSecurityTokenParameters();
					((SecurityTokenParameters)val7).set_InclusionMode((SecurityTokenInclusionMode)1);
					((SecurityTokenParameters)val7).set_RequireDerivedKeys(false);
					val6.get_Endorsing().Add((SecurityTokenParameters)(object)val7);
				}
				val5 = (Binding)new CustomBinding((IEnumerable<BindingElement>)val3);
			}
			val5 = (Binding)new CustomBinding((IEnumerable<BindingElement>)HttpProxyTransportBindingElement.ReplaceHttpTransportWithProxy(val5.CreateBindingElements(), m_proxy));
			InfoCardServiceClientCredentials infoCardServiceClientCredentials = new InfoCardServiceClientCredentials(credential, m_protocolProfile);
			if (flag)
			{
				rSATokenProvider = (infoCardServiceClientCredentials.EndorsingSignatureTokenProvider = new RSATokenProvider(policy, card));
			}
			ChannelFactory<ISts> val8 = null;
			bool flag3 = false;
			List<string> list;
			DisplayToken displayToken;
			try
			{
				InfoCardTrace.Assert(!flag3, "Will set to true upon sucess", new object[0]);
				lock (m_channelChangeSync)
				{
					if (base.IsAborted)
					{
						throw InfoCardTrace.ThrowHelperError((Exception)new UserCancelledException());
					}
					val8 = new ChannelFactory<ISts>(val5, address);
					ClientCredentials val9 = ((ChannelFactory)val8).get_Endpoint().get_Behaviors().Find<ClientCredentials>();
					if (val9 != null)
					{
						((Collection<IEndpointBehavior>)(object)((ChannelFactory)val8).get_Endpoint().get_Behaviors()).Remove((IEndpointBehavior)(object)val9);
					}
					((ChannelFactory)val8).get_Endpoint().get_Behaviors().Remove<ClientCredentials>();
					((Collection<IEndpointBehavior>)(object)((ChannelFactory)val8).get_Endpoint().get_Behaviors()).Add((IEndpointBehavior)(object)infoCardServiceClientCredentials);
					X509Certificate2Collection x509Certificate2Collection = null;
					bool chainTrustPassed = false;
					switch (parameter.CredentialType)
					{
					default:
						InfoCardTrace.ThrowInvalidArgumentConditional(true, "CredentialType");
						break;
					case TokenFactoryCredentialType.UserNamePasswordCredential:
						((ClientCredentials)infoCardServiceClientCredentials).get_UserName().set_UserName(((UserNameTokenFactoryCredential)credential).UserName);
						((ClientCredentials)infoCardServiceClientCredentials).get_UserName().set_Password(((UserNameTokenFactoryCredential)credential).Password);
						x509Certificate2Collection = GetCertificateChainFromAddress(address);
						InfoCardX509Validator.ValidateChainOrPeer(x509Certificate2Collection[0], x509Certificate2Collection, out chainTrustPassed);
						((ClientCredentials)infoCardServiceClientCredentials).get_ServiceCertificate().set_DefaultCertificate(x509Certificate2Collection[0]);
						break;
					case TokenFactoryCredentialType.SelfIssuedCredential:
					{
						infoCardServiceClientCredentials.IsSelfIssuedCred = true;
						SelfIssuedTokenFactoryCredential selfIssuedTokenFactoryCredential = (SelfIssuedTokenFactoryCredential)credential;
						infoCardServiceClientCredentials.SelectedCard = selfIssuedTokenFactoryCredential.LocalCard;
						x509Certificate2Collection = GetCertificateChainFromAddress(address);
						X509Certificate2 x509Certificate = x509Certificate2Collection[0];
						InfoCardX509Validator.ValidateChainOrPeer(x509Certificate, x509Certificate2Collection, out chainTrustPassed);
						Recipient.RecipientCertParameters recipientParams;
						string recipientId = Recipient.CertGetRecipientIdHash(x509Certificate, x509Certificate2Collection, chainTrustPassed, out recipientParams);
						string text = Recipient.CertGetRecipientOrganizationIdHash(x509Certificate, x509Certificate2Collection, chainTrustPassed);
						EnsureSelfIssuedCardHasLedgerEntryForIssuer(selfIssuedTokenFactoryCredential.LocalCard, x509Certificate, recipientId, text, recipientParams, text);
						((ClientCredentials)infoCardServiceClientCredentials).get_ServiceCertificate().set_DefaultCertificate(x509Certificate);
						break;
					}
					case TokenFactoryCredentialType.X509CertificateCredential:
						((ClientCredentials)infoCardServiceClientCredentials).get_ClientCertificate().set_Certificate(((X509CertificateTokenFactoryCredential)credential).Certificate);
						x509Certificate2Collection = GetCertificateChainFromAddress(address);
						InfoCardX509Validator.ValidateChainOrPeer(x509Certificate2Collection[0], x509Certificate2Collection, out chainTrustPassed);
						((ClientCredentials)infoCardServiceClientCredentials).get_ServiceCertificate().set_DefaultCertificate(x509Certificate2Collection[0]);
						break;
					case TokenFactoryCredentialType.KerberosCredential:
						break;
					}
					((ClientCredentials)infoCardServiceClientCredentials).get_ServiceCertificate().get_Authentication().set_CertificateValidationMode((X509CertificateValidationMode)4);
					((ClientCredentials)infoCardServiceClientCredentials).get_ServiceCertificate().get_Authentication().set_CustomCertificateValidator(InfoCardX509Validator.Create(x509Certificate2Collection));
					m_channelFactory = val8;
				}
				try
				{
					ISts sts = val8.CreateChannel();
					if (rSACryptoServiceProvider != null)
					{
						val = new RSAKeyValue((RSA)rSACryptoServiceProvider);
					}
					m_disclosedClaims = card.GetClaimsToBeDisclosed(policy, discloseOptional);
					list = new List<string>(m_disclosedClaims.Count);
					list.AddRange(m_disclosedClaims.Keys);
					RequestSecurityToken requestSecurityToken = CreateRst(val5.get_MessageVersion().get_Addressing(), policy, card, discloseOptional, val, array, new CultureInfo(credential.LCID));
					Message rstMessage = Message.CreateMessage(val5.get_MessageVersion(), m_protocolProfile.WSTrust.RequestSecurityTokenAction, (BodyWriter)(object)requestSecurityToken);
					Message val10 = null;
					if (XmlNames.WSSpecificationVersion.WSTrustXmlSoap2005 == m_protocolProfile.WSTrust.Version)
					{
						val10 = sts.ProcessRequestSecurityTokenFeb2005(rstMessage);
					}
					else if (XmlNames.WSSpecificationVersion.WSTrustOasis2007 == m_protocolProfile.WSTrust.Version)
					{
						val10 = sts.ProcessRequestSecurityTokenWSTrust13(rstMessage);
					}
					else
					{
						InfoCardTrace.Assert(false, "Unsupported version of WS-Trust detected", new object[0]);
					}
					WSIdentityFaultException.ThrowIfFaultMessage(val10, CultureInfo.GetCultureInfo(credential.LCID));
					if (policy.KeyType == SecurityKeyTypeInternal.SymmetricKey)
					{
						val2 = RequestSecurityTokenResponseHelper.ProcessSymmetricTokenData(val10.GetReaderAtBodyContents(), (SecurityTokenSerializer)(object)m_protocolProfile.TokenSerializer, null, array, m_protocolProfile, out displayToken);
						if (val2.get_ProofToken().get_SecurityKeys().Count < 1)
						{
							throw InfoCardTrace.ThrowHelperError((Exception)(object)new TrustExchangeException(SR.GetString("NoSymmetricKeyFound")));
						}
						foreach (SecurityKey securityKey in val2.get_ProofToken().get_SecurityKeys())
						{
							InMemorySymmetricSecurityKey val11 = (InMemorySymmetricSecurityKey)(object)((securityKey is InMemorySymmetricSecurityKey) ? securityKey : null);
							if (val11 != null)
							{
								symmetricAlgorithm = new RijndaelManaged();
								symmetricAlgorithm.Key = ((SymmetricSecurityKey)(InMemorySymmetricSecurityKey)securityKey).GetSymmetricKey();
								break;
							}
						}
						if (symmetricAlgorithm == null)
						{
							throw InfoCardTrace.ThrowHelperError((Exception)(object)new TrustExchangeException(SR.GetString("NoSymmetricKeyFound")));
						}
					}
					else if (SecurityKeyTypeInternal.AsymmetricKey == policy.KeyType)
					{
						val2 = RequestSecurityTokenResponseHelper.ProcessAsymmetricTokenData(val10.GetReaderAtBodyContents(), rSACryptoServiceProvider, (SecurityTokenSerializer)(object)m_protocolProfile.TokenSerializer, null, m_protocolProfile, out displayToken);
					}
					else
					{
						InfoCardTrace.Assert(SecurityKeyTypeInternal.NoKey == policy.KeyType, "Bad enum member for SecurityKeyTypeInternal", new object[0]);
						val2 = RequestSecurityTokenResponseHelper.ProcessBearerTokenData(val10.GetReaderAtBodyContents(), (SecurityTokenSerializer)(object)m_protocolProfile.TokenSerializer, null, m_protocolProfile, out displayToken);
					}
					((CommunicationObject)val8).Close();
					flag3 = true;
				}
				finally
				{
					lock (m_channelChangeSync)
					{
						if (!flag3)
						{
							((CommunicationObject)val8).Abort();
						}
						m_channelFactory = null;
					}
				}
			}
			catch (EndpointNotFoundException val12)
			{
				EndpointNotFoundException inner = val12;
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new TrustExchangeException(SR.GetString("EndpointNotFound"), (Exception)(object)inner));
			}
			catch (InfoCardBaseException)
			{
				throw;
			}
			catch (Exception ex)
			{
				if (InfoCardTrace.IsFatal(ex))
				{
					throw;
				}
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new TrustExchangeException(SR.GetString("ProblemRetrievingTokenFromIdentityProvider"), ex));
			}
			XmlElement xmlElement = val2.get_TokenXml();
			if (policy.ImmediateTokenRecipient is X509RecipientIdentity x509RecipientIdentity && !IsEncryptedXml(xmlElement) && AppliesToBehaviorDecisionTable.GetAppliesToBehaviorDecisionForRst(policy, card.RequireAppliesto) == AppliesToBehaviorDecision.DoNotSend)
			{
				try
				{
					xmlElement = EncryptionUtility.EncryptSecurityToken(asymmetricKeyWrapAlgorithm: (policy.KeyType == SecurityKeyTypeInternal.SymmetricKey) ? SecurityAlgorithmSuite.get_Default().get_DefaultAsymmetricKeyWrapAlgorithm() : ((SecurityKeyTypeInternal.AsymmetricKey != policy.KeyType) ? SecurityAlgorithmSuite.get_Default().get_DefaultAsymmetricKeyWrapAlgorithm() : ((!string.IsNullOrEmpty(policy.OptionalRstParams.EncryptWith)) ? policy.OptionalRstParams.EncryptWith : SecurityAlgorithmSuite.get_Default().get_DefaultAsymmetricKeyWrapAlgorithm())), elem: xmlElement, cert: x509RecipientIdentity.LeafCertificate, encryptingAlgorithm: (!string.IsNullOrEmpty(policy.OptionalRstParams.EncryptionAlgorithm)) ? policy.OptionalRstParams.EncryptionAlgorithm : SecurityAlgorithmSuite.get_Default().get_DefaultEncryptionAlgorithm(), profile: policy.ProtocolVersionProfile);
				}
				catch (Exception ex2)
				{
					if (InfoCardTrace.IsFatal(ex2))
					{
						throw;
					}
					throw InfoCardTrace.ThrowHelperError((Exception)(object)new TrustExchangeException("ServiceTokenEncryptionFailed", ex2));
				}
			}
			GetKeyIdentifierClauses(val2, policy.ProtocolVersionProfile, out internalTokenReference, out externalTokenReference);
			FillOutDisplayToken(card, displayToken);
			TokenDescriptor result = new TokenDescriptor(((SecurityToken)val2).get_Id(), ((SecurityToken)val2).get_ValidFrom(), ((SecurityToken)val2).get_ValidTo(), xmlElement, displayToken, symmetricAlgorithm, internalTokenReference, externalTokenReference, list);
			symmetricAlgorithm = null;
			val2 = null;
			return result;
		}
		finally
		{
			if (rSACryptoServiceProvider != null)
			{
				((IDisposable)rSACryptoServiceProvider).Dispose();
				rSACryptoServiceProvider = null;
			}
			if (val != null)
			{
				((IDisposable)val.get_Key()).Dispose();
				val.set_Key((RSA)null);
			}
			if (symmetricAlgorithm != null)
			{
				((IDisposable)symmetricAlgorithm).Dispose();
				symmetricAlgorithm = null;
			}
			if (rSATokenProvider != null)
			{
				((IDisposable)rSATokenProvider).Dispose();
				rSATokenProvider = null;
			}
		}
	}

	protected override void OnAbort()
	{
		lock (m_channelChangeSync)
		{
			if (!base.IsAborted && m_channelFactory != null)
			{
				((CommunicationObject)m_channelFactory).Abort();
			}
		}
	}

	private X509Certificate2Collection GetCertificateChainFromAddress(EndpointAddress address)
	{
		if ((EndpointAddress)null == address || address.get_Identity() == null)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new TrustExchangeException(SR.GetString("NoCertificateInEndPoint")));
		}
		EndpointIdentity identity = address.get_Identity();
		X509CertificateEndpointIdentity val = (X509CertificateEndpointIdentity)(object)((identity is X509CertificateEndpointIdentity) ? identity : null);
		if (val == null || val.get_Certificates() == null || val.get_Certificates().Count < 1)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new TrustExchangeException(SR.GetString("NoCertificateInEndPoint")));
		}
		return val.get_Certificates();
	}

	public static ServiceEndpoint DoMexExchange(TokenCreationParameter param, IWebProxy proxy)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		ServiceEndpoint val = null;
		bool flag = false;
		if (param != null && !((EndpointAddress)null == param.Epr))
		{
			EndpointAddress val2 = Utility.DeriveMexAddress(param.Epr);
			if ((EndpointAddress)null == val2)
			{
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new TrustExchangeException(SR.GetString("InvalidServiceUri")));
			}
			Binding mexBinding = Utility.BuildBindingWithMaxMessageSize((Binding)new WSHttpBinding((SecurityMode)1));
			InfoCardMetadataExchangeClient infoCardMetadataExchangeClient = new InfoCardMetadataExchangeClient(mexBinding);
			infoCardMetadataExchangeClient.Proxy = proxy;
			MetadataSet val3 = null;
			((MetadataExchangeClient)infoCardMetadataExchangeClient).set_ResolveMetadataReferences(true);
			((MetadataExchangeClient)infoCardMetadataExchangeClient).set_MaximumResolvedReferences(InfoCardConstants.MaximumMexChainLength);
			Exception inner = null;
			try
			{
				val3 = ((MetadataExchangeClient)infoCardMetadataExchangeClient).GetMetadata(val2);
				flag = true;
			}
			catch (Exception ex)
			{
				if (InfoCardTrace.IsFatal(ex))
				{
					throw;
				}
			}
			if (!flag)
			{
				try
				{
					val3 = ((MetadataExchangeClient)infoCardMetadataExchangeClient).GetMetadata(val2.get_Uri(), (MetadataExchangeClientMode)1);
					flag = true;
				}
				catch (Exception ex2)
				{
					if (InfoCardTrace.IsFatal(ex2))
					{
						throw;
					}
					inner = ex2;
				}
			}
			if (!flag)
			{
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new TrustExchangeException(SR.GetString("EndpointNotFound"), inner));
			}
			WsdlImporter val4 = new WsdlImporter(val3);
			((MetadataImporter)val4).get_State().Add("MetadataExchangeClientKey", infoCardMetadataExchangeClient);
			ServiceEndpointCollection val5 = ((MetadataImporter)val4).ImportAllEndpoints();
			if (val5 != null)
			{
				foreach (ServiceEndpoint item in (Collection<ServiceEndpoint>)(object)val5)
				{
					if (Utility.CompareUri(item.get_Address().get_Uri(), param.Epr.get_Uri()))
					{
						ISecurityCapabilities property = item.get_Binding().GetProperty<ISecurityCapabilities>(new BindingParameterCollection());
						if (property != null && property.get_SupportedRequestProtectionLevel() == ProtectionLevel.EncryptAndSign && property.get_SupportedResponseProtectionLevel() == ProtectionLevel.EncryptAndSign && property.get_SupportsServerAuthentication())
						{
							val = item;
							break;
						}
					}
				}
				if (val == null)
				{
					throw InfoCardTrace.ThrowHelperError((Exception)(object)new TrustExchangeException(SR.GetString("IndigoNoSuitableEndpointsForAddress", new object[1] { param.Epr.get_Uri().AbsoluteUri })));
				}
				return val;
			}
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new TrustExchangeException(SR.GetString("IndigoNoSuitableEndpointsForAddress", new object[1] { param.Epr.get_Uri().AbsoluteUri })));
		}
		throw InfoCardTrace.ThrowHelperError((Exception)(object)new TrustExchangeException(SR.GetString("InvalidServiceUri")));
	}

	private RequestSecurityToken CreateRst(AddressingVersion version, InfoCardPolicy policy, InfoCard card, bool discloseOptional, RSAKeyValue val, byte[] clientEntropyForSymmetric, CultureInfo displayCulture)
	{
		InfoCardTrace.ThrowInvalidArgumentConditional(null == policy, "policy");
		InfoCardTrace.ThrowInvalidArgumentConditional(null == card, "card");
		RequestSecurityTokenParameters rstParams = new RequestSecurityTokenParameters(version, card, policy, discloseOptional, val, m_disclosedClaims, "ProcessRequestSecurityToken", clientEntropyForSymmetric, displayCulture);
		return new RequestSecurityTokenForRemoteTokenFactory(rstParams);
	}

	private void GetKeyIdentifierClauses(GenericXmlSecurityToken tok, ProtocolProfile profile, out string internalTokenReference, out string externalTokenReference)
	{
		if (tok.get_InternalTokenReference() != null && tok.get_ExternalTokenReference() != null)
		{
			try
			{
				using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
				{
					((SecurityTokenSerializer)profile.TokenSerializer).WriteKeyIdentifierClause((XmlWriter)(object)XmlDictionaryWriter.CreateDictionaryWriter((XmlWriter)new XmlTextWriter(stringWriter)), tok.get_InternalTokenReference());
					stringWriter.Flush();
					internalTokenReference = stringWriter.GetStringBuilder().ToString();
				}
				using StringWriter stringWriter2 = new StringWriter(CultureInfo.InvariantCulture);
				((SecurityTokenSerializer)profile.TokenSerializer).WriteKeyIdentifierClause((XmlWriter)(object)XmlDictionaryWriter.CreateDictionaryWriter((XmlWriter)new XmlTextWriter(stringWriter2)), tok.get_ExternalTokenReference());
				stringWriter2.Flush();
				externalTokenReference = stringWriter2.GetStringBuilder().ToString();
				return;
			}
			catch (XmlException inner)
			{
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new TrustExchangeException(SR.GetString("IPSTSClientInvalidTokenReference"), inner));
			}
		}
		throw InfoCardTrace.ThrowHelperError((Exception)(object)new TrustExchangeException(SR.GetString("IPSTSClientInvalidTokenReference")));
	}

	private void EnsureSelfIssuedCardHasLedgerEntryForIssuer(InfoCard card, X509Certificate2 issuerCert, string recipientId, string recipientOrgId, Recipient.RecipientCertParameters recipientParams, string immediateTokenRecipientOrganizationIdentifier)
	{
		LedgerEntryCollection ledger = card.GetLedger();
		StoreConnection connection = StoreConnection.GetConnection();
		try
		{
			ledger.Get(connection);
			if (!ledger.ContainsKey(recipientId))
			{
				connection.BeginTransaction();
				try
				{
					InfoCardMasterKey masterKey = card.GetMasterKey(connection);
					if (card.IsPinProtected)
					{
						InfoCardTrace.Assert(!string.IsNullOrEmpty(card.Pin), "Should not be null here", new object[0]);
						masterKey.Decrypt(masterKey.GetPinHelper(card.Pin));
					}
					Recipient recipient = new Recipient(issuerCert, recipientId, recipientOrgId, isCertCached: false, 0u, recipientParams);
					recipient.Save(connection);
					LedgerEntry ledgerEntry = LedgerEntry.NewLedgerEntry(card.Id, recipient, card.Key, immediateTokenRecipientOrganizationIdentifier);
					ledger.Add(ledgerEntry);
					ledgerEntry.Save(connection);
					connection.CommitTransaction();
					return;
				}
				catch
				{
					connection.RollbackTransaction();
					throw;
				}
			}
			InfoCardTrace.Assert(immediateTokenRecipientOrganizationIdentifier == recipientOrgId, "For the self issued case the RP should be same as token recipient", new object[0]);
		}
		finally
		{
			connection.Close();
		}
	}

	private void FillOutDisplayToken(InfoCard card, DisplayToken displayToken)
	{
		if (displayToken.ClaimList == null)
		{
			return;
		}
		InfoCardClaimCollection claims = card.GetClaims();
		foreach (DisplayClaim claim in displayToken.ClaimList)
		{
			if (!string.IsNullOrEmpty(claim.Name))
			{
				continue;
			}
			string text = null;
			string id = claim.Id;
			if (!string.IsNullOrEmpty(claim.Id))
			{
				if (claims.ContainsKey(id))
				{
					text = claims[id].DisplayTag;
				}
				if (string.IsNullOrEmpty(text))
				{
					text = id;
				}
			}
			else
			{
				text = SR.GetString("ServiceDisplayTokenNoClaimName");
			}
			claim.Name = text;
		}
	}

	private bool IsEncryptedXml(XmlElement content)
	{
		if ("EncryptedData" == content.LocalName)
		{
			return "http://www.w3.org/2001/04/xmlenc#" == content.NamespaceURI;
		}
		return false;
	}
}
