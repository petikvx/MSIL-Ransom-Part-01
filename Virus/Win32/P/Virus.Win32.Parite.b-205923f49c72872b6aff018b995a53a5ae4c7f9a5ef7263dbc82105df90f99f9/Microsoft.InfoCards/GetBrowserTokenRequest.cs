using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.IdentityModel.Policy;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Security;
using System.ServiceModel.Security.Tokens;
using System.Text;
using System.Xml;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class GetBrowserTokenRequest : GetTokenRequest
{
	private class CreateIssuedTokenClientCredentials : ClientCredentials
	{
		private GetBrowserTokenRequest request;

		public CreateIssuedTokenClientCredentials(GetBrowserTokenRequest request)
		{
			InfoCardTrace.ThrowInvalidArgumentConditional(request == null, "request");
			this.request = request;
		}

		protected internal CreateIssuedTokenClientCredentials(CreateIssuedTokenClientCredentials other)
			: base((ClientCredentials)(object)other)
		{
			request = other.request;
		}

		protected override ClientCredentials CloneCore()
		{
			return (ClientCredentials)(object)new CreateIssuedTokenClientCredentials(this);
		}

		protected internal override SecurityToken GetInfoCardSecurityToken(bool requiresInfoCard, CardSpacePolicyElement[] chain, SecurityTokenSerializer tokenSerializer)
		{
			return request.CreateIssuedToken(chain, tokenSerializer);
		}

		public override void ApplyClientBehavior(ServiceEndpoint serviceEndpoint, ClientRuntime behavior)
		{
			((ClientCredentials)this).ApplyClientBehavior(serviceEndpoint, behavior);
			bool flag = false;
			foreach (IInteractiveChannelInitializer interactiveChannelInitializer in behavior.get_InteractiveChannelInitializers())
			{
				if (interactiveChannelInitializer is InfocardInteractiveChannelInitializer)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new TrustExchangeException(SR.GetString("IdentityProviderRequestedUnsupportedAuthType")));
			}
		}
	}

	[ServiceContract]
	internal interface ISts
	{
		[OperationContract(Name = "ProcessRequestSecurityTokenFeb2005", Action = "http://schemas.xmlsoap.org/ws/2005/02/trust/RST/Issue", ReplyAction = "http://schemas.xmlsoap.org/ws/2005/02/trust/RSTR/Issue", ProtectionLevel = ProtectionLevel.EncryptAndSign)]
		Message ProcessRequestSecurityTokenFeb2005(Message rstMessage);

		[OperationContract(Name = "ProcessRequestSecurityTokenWSTrust13", Action = "http://docs.oasis-open.org/ws-sx/ws-trust/200512/RST/Issue", ReplyAction = "http://docs.oasis-open.org/ws-sx/ws-trust/200512/RSTRC/IssueFinal", ProtectionLevel = ProtectionLevel.EncryptAndSign)]
		Message ProcessRequestSecurityTokenWSTrust13(Message rstMessage);
	}

	public const int POLICY_V1 = 1;

	public const int POLICY_V2 = 2;

	private GetBrowserTokenParameters m_params;

	private ServiceEndpoint m_svcEpr;

	private byte[] m_rawToken;

	private SelfIssuedAuthProofToken m_proofToken;

	private ProtocolProfile m_protocolProfile;

	public GetBrowserTokenRequest(Process callingProcess, WindowsIdentity callingIdentity, InfoCardUIAgent uiAgent, IntPtr rpcHandle, Stream inArgs, Stream outArgs)
		: base(callingProcess, callingIdentity, uiAgent, rpcHandle, inArgs, outArgs)
	{
		m_protocolProfile = new ProtocolProfile();
	}

	private static bool IsReferralToManagedIssuer(Binding issuerBinding)
	{
		bool result = false;
		if (issuerBinding != null)
		{
			UseManagedPresentationBindingElement val = issuerBinding.CreateBindingElements().Find<UseManagedPresentationBindingElement>();
			if (val != null)
			{
				result = true;
			}
		}
		return result;
	}

	protected override void OnMarshalInArgs()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected O, but got Unknown
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected O, but got Unknown
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected O, but got Unknown
		BinaryReader binaryReader = new InfoCardBinaryReader(base.InArgs, Encoding.Unicode);
		try
		{
			m_params = new GetBrowserTokenParameters();
			int num = binaryReader.ReadInt32();
			if (1 != num && 2 != num)
			{
				throw InfoCardTrace.ThrowHelperError((Exception)new InfoCardArgumentException(SR.GetString("InvalidFlagsSpecified")));
			}
			m_params.Load(binaryReader, num);
			if (null == m_params.Issuer.PolicyUrl)
			{
				CreateInfoCardPolicyFromBrowserParams();
				return;
			}
			if (!Utility.CompareUri(XmlNames.WSIdentity.SelfIssuerUriValue, m_params.Issuer.Address) && !Utility.CompareUri(XmlNames.WSIdentity.AnonymousIssuerUriValue, m_params.Issuer.Address))
			{
				if (null == m_params.Issuer.Address)
				{
					throw InfoCardTrace.ThrowHelperError((Exception)new InfoCardArgumentException(SR.GetString("NoIssuerSpecifiedWhenMexIsSpecified")));
				}
				ServiceEndpoint val = null;
				ServiceEndpointCollection val2 = null;
				try
				{
					val2 = GetServiceEndpointCollection(m_params.Issuer.Address, m_params.Issuer.PolicyUrl);
				}
				catch (Exception ex)
				{
					if (InfoCardTrace.IsFatal(ex))
					{
						throw;
					}
					val2 = null;
				}
				if (val2 != null && val2.Find(m_params.Issuer.Address) != null)
				{
					val = val2.Find(m_params.Issuer.Address);
					if (!IsReferralToManagedIssuer(val.get_Binding()) && DoesEndpointSatisfySecurityRequirements(val) && DoesEndpointSatisfyIssuedTokenRequirements(val))
					{
						if (Uri.UriSchemeHttps != m_params.Recipient.Address.Scheme)
						{
							throw InfoCardTrace.ThrowHelperError((Exception)new InfoCardArgumentException(SR.GetString("RPStsWithNoSSLFailure")));
						}
						m_svcEpr = val;
						BindingElementCollection val3 = val.get_Binding().CreateBindingElements();
						SecurityBindingElement val4 = val3.Find<SecurityBindingElement>();
						InfoCardTrace.Assert(null != val4, "No SecurityBindingElement was found in the BindingElementCollection", new object[0]);
						if (TrustVersion.get_WSTrust13() == val4.get_MessageSecurityVersion().get_TrustVersion())
						{
							m_protocolProfile.WSTrust = XmlNames.WSTrustOasis2007.Instance;
						}
					}
				}
				CreateInfoCardPolicyFromBrowserParams();
				return;
			}
			throw InfoCardTrace.ThrowHelperError((Exception)new InfoCardArgumentException(SR.GetString("SelfOrAnonIssuerNotAllowedWhenMexSpecified", new object[1] { m_params.Issuer.Address })));
		}
		catch (InfoCardBaseException)
		{
			throw;
		}
		catch (Exception ex2)
		{
			if (InfoCardTrace.IsFatal(ex2))
			{
				throw;
			}
			throw InfoCardTrace.ThrowHelperError((Exception)new InfoCardArgumentException(SR.GetString("ServiceInvalidArguments"), ex2));
		}
	}

	private void CreateInfoCardPolicyFromBrowserParams()
	{
		CardSpacePolicyElement val = m_params.CreatePolicyElement(m_protocolProfile);
		InfoCardPolicy infoCardPolicy = PolicyFactory.CreatePolicyForGetBrowserTokenRequest(val, val.get_PolicyNoticeLink(), (uint)val.get_PolicyNoticeVersion(), RecipientIdentity.CreateIdentity(m_params.Recipient.CreateEndpointAddress(), validate: true), PolicyUsageContext.Browser);
		infoCardPolicy.Validate();
		base.Policy = infoCardPolicy;
	}

	private bool DoesEndpointSatisfyIssuedTokenRequirements(ServiceEndpoint serviceEndpoint)
	{
		if (serviceEndpoint != null)
		{
			bool disallowedStpDetected = false;
			IssuedSecurityTokenParameters val = TryGetNextStsIssuedTokenParameters(serviceEndpoint.get_Binding().CreateBindingElements(), ref disallowedStpDetected);
			if (val != null)
			{
				return true;
			}
		}
		return false;
	}

	private bool DoesEndpointSatisfySecurityRequirements(ServiceEndpoint serviceEndpoint)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		if (serviceEndpoint != null)
		{
			ISecurityCapabilities property = serviceEndpoint.get_Binding().GetProperty<ISecurityCapabilities>(new BindingParameterCollection());
			if (property != null && property.get_SupportedRequestProtectionLevel() == ProtectionLevel.EncryptAndSign && property.get_SupportedResponseProtectionLevel() == ProtectionLevel.EncryptAndSign && property.get_SupportsClientAuthentication() && property.get_SupportsServerAuthentication())
			{
				return true;
			}
		}
		return false;
	}

	protected override void OnMarshalOutArgs()
	{
		BinaryWriter binaryWriter = new BinaryWriter(base.OutArgs, Encoding.Unicode);
		try
		{
			try
			{
				binaryWriter.Write(m_rawToken.Length);
				binaryWriter.Write(m_rawToken, 0, m_rawToken.Length);
			}
			finally
			{
				Array.Clear(m_rawToken, 0, m_rawToken.Length);
			}
		}
		catch (Exception ex)
		{
			if (InfoCardTrace.IsFatal(ex))
			{
				throw;
			}
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new TrustExchangeException(SR.GetString("ServiceFailedToWriteToken"), ex));
		}
	}

	protected override void OnProcess()
	{
		try
		{
			if (m_svcEpr == null)
			{
				base.OnProcess();
				if (base.ProcessingException != null)
				{
					throw InfoCardTrace.ThrowHelperError(base.ProcessingException);
				}
				using MemoryStream memoryStream = new MemoryStream();
				XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
				xmlWriterSettings.CloseOutput = false;
				xmlWriterSettings.Encoding = Encoding.UTF8;
				xmlWriterSettings.OmitXmlDeclaration = true;
				using (XmlWriter w = XmlWriter.Create(memoryStream, xmlWriterSettings))
				{
					base.Token.ProtectedToken.WriteTo(w);
				}
				m_rawToken = new byte[memoryStream.Length - 3L];
				Array.Copy(memoryStream.GetBuffer(), 3, m_rawToken, 0, Convert.ToInt32(memoryStream.Length - 3L));
				return;
			}
			CreateIssuedTokenClientCredentials createIssuedTokenClientCredentials = CreateClientCredentials(m_svcEpr);
			((ClientCredentials)createIssuedTokenClientCredentials).get_Windows().set_AllowNtlm(false);
			Binding val = FedChainUpdateProxyAndRestrictTransportBindingWrapper(m_svcEpr.get_Binding(), base.UserProxy);
			ChannelFactory<ISts> channelFactory = new ChannelFactory<ISts>(val, m_svcEpr.get_Address());
			try
			{
				((ChannelFactory)channelFactory).get_Endpoint().get_Binding().set_OpenTimeout(new TimeSpan(5, 0, 0));
				((ChannelFactory)channelFactory).get_Endpoint().get_Binding().set_SendTimeout(new TimeSpan(5, 0, 0));
				((ChannelFactory)channelFactory).get_Endpoint().get_Binding().set_ReceiveTimeout(new TimeSpan(5, 0, 0));
				((ChannelFactory)channelFactory).get_Endpoint().get_Binding().set_CloseTimeout(new TimeSpan(5, 0, 0));
				((ChannelFactory)channelFactory).get_Endpoint().get_Behaviors().Remove<ClientCredentials>();
				((Collection<IEndpointBehavior>)(object)((ChannelFactory)channelFactory).get_Endpoint().get_Behaviors()).Add((IEndpointBehavior)(object)createIssuedTokenClientCredentials);
				InfoCardTrace.Assert(!((ChannelFactory)channelFactory).get_Credentials().get_Windows().get_AllowNtlm(), "Should be false", new object[0]);
				ISts sts = channelFactory.CreateChannel();
				if (base.Policy == null)
				{
					CreateInfoCardPolicyFromBrowserParams();
				}
				RequestSecurityTokenParameters rstParams = new RequestSecurityTokenParameters(m_svcEpr.get_Binding().get_MessageVersion().get_Addressing(), m_params, m_protocolProfile, base.Policy, discloseOptionalClaims: true);
				RequestSecurityToken requestSecurityToken = new RequestSecurityTokenForGetBrowserToken(rstParams);
				Message rstMsg = Message.CreateMessage(m_svcEpr.get_Binding().get_MessageVersion(), m_protocolProfile.WSTrust.RequestSecurityTokenAction, (BodyWriter)(object)requestSecurityToken);
				Message rstrMsg = null;
				if (XmlNames.WSSpecificationVersion.WSTrustXmlSoap2005 == m_protocolProfile.WSTrust.Version)
				{
					ExecuteCancelable(delegate
					{
						rstrMsg = sts.ProcessRequestSecurityTokenFeb2005(rstMsg);
					}, delegate
					{
						((CommunicationObject)channelFactory).Abort();
					});
				}
				else if (XmlNames.WSSpecificationVersion.WSTrustOasis2007 == m_protocolProfile.WSTrust.Version)
				{
					ExecuteCancelable(delegate
					{
						rstrMsg = sts.ProcessRequestSecurityTokenWSTrust13(rstMsg);
					}, delegate
					{
						((CommunicationObject)channelFactory).Abort();
					});
				}
				else
				{
					InfoCardTrace.Assert(false, "Unsupported version of WS-Trust detected", new object[0]);
				}
				InfoCardTrace.Assert(null != rstrMsg, "Should have thrown before this if message is null", new object[0]);
				WSIdentityFaultException.ThrowIfFaultMessage(rstrMsg, CultureInfo.GetCultureInfo(base.UserLanguage));
				using (XmlReader reader = rstrMsg.GetReaderAtBodyContents())
				{
					using MemoryStream memoryStream2 = new MemoryStream();
					XmlWriterSettings xmlWriterSettings2 = new XmlWriterSettings();
					xmlWriterSettings2.CloseOutput = false;
					xmlWriterSettings2.Encoding = Encoding.UTF8;
					xmlWriterSettings2.OmitXmlDeclaration = true;
					using (XmlWriter writer = XmlWriter.Create(memoryStream2, xmlWriterSettings2))
					{
						WriteRequestedTokenFrom(reader, writer);
					}
					m_rawToken = new byte[memoryStream2.Length - 3L];
					Array.Copy(memoryStream2.GetBuffer(), 3, m_rawToken, 0, Convert.ToInt32(memoryStream2.Length - 3L));
				}
				((CommunicationObject)channelFactory).Close();
			}
			finally
			{
				if (channelFactory != null)
				{
					((IDisposable)channelFactory).Dispose();
				}
			}
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
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new TrustExchangeException(SR.GetString("ServiceSTSCommunicationFailed"), ex));
		}
	}

	public static void WriteSourceUrlAppliesTo(XmlWriter writer, GetBrowserTokenParameters browserParams, ProtocolProfile profile)
	{
		EndpointAddress val = browserParams.Recipient.CreateEndpointAddress();
		writer.WriteStartElement(profile.WSPolicy.DefaultPrefix, profile.WSPolicy.AppliesTo, profile.WSPolicy.Namespace);
		val.WriteTo(AddressingVersion.get_WSAddressing10(), writer);
		writer.WriteEndElement();
	}

	private static void CheckOptionalTokenParameters(SupportingTokenParameters oestp, IDictionary<string, SupportingTokenParameters> oostp, ref bool disallowedStpDetected)
	{
		ThrowOnMultipleAssignment<IssuedSecurityTokenParameters> issuedTokenParameters = new ThrowOnMultipleAssignment<IssuedSecurityTokenParameters>(SR.GetString("TooManyIssuedSecurityTokenParameters"));
		GetIssuedSecurityTokenParametersFromSupportingTokenParameters(oestp, issuedTokenParameters, ref disallowedStpDetected);
		foreach (SupportingTokenParameters value in oostp.Values)
		{
			GetIssuedSecurityTokenParametersFromSupportingTokenParameters(value, issuedTokenParameters, ref disallowedStpDetected);
		}
	}

	public static IssuedSecurityTokenParameters TryGetNextStsIssuedTokenParameters(BindingElementCollection bindingElements, ref bool disallowedStpDetected)
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		if (bindingElements == null)
		{
			return null;
		}
		ThrowOnMultipleAssignment<IssuedSecurityTokenParameters> val = new ThrowOnMultipleAssignment<IssuedSecurityTokenParameters>(SR.GetString("TooManyIssuedSecurityTokenParameters"));
		SecurityBindingElement val2 = bindingElements.Find<SecurityBindingElement>();
		if (val2 == null)
		{
			return null;
		}
		SupportingTokenParameters endpointSupportingTokenParameters = val2.get_EndpointSupportingTokenParameters();
		GetIssuedSecurityTokenParametersFromSupportingTokenParameters(endpointSupportingTokenParameters, val, ref disallowedStpDetected);
		IDictionary<string, SupportingTokenParameters> operationSupportingTokenParameters = val2.get_OperationSupportingTokenParameters();
		foreach (SupportingTokenParameters value in operationSupportingTokenParameters.Values)
		{
			GetIssuedSecurityTokenParametersFromSupportingTokenParameters(value, val, ref disallowedStpDetected);
		}
		if (val2 is AsymmetricSecurityBindingElement)
		{
			AsymmetricSecurityBindingElement val3 = (AsymmetricSecurityBindingElement)val2;
			CheckAndAssignIssuedTokenParameters(val3.get_InitiatorTokenParameters(), val, ref disallowedStpDetected);
			CheckAndAssignIssuedTokenParameters(val3.get_RecipientTokenParameters(), val, ref disallowedStpDetected);
		}
		else if (val2 is SymmetricSecurityBindingElement)
		{
			SymmetricSecurityBindingElement val4 = (SymmetricSecurityBindingElement)val2;
			SecurityTokenParameters protectionTokenParameters = val4.get_ProtectionTokenParameters();
			if (protectionTokenParameters is SecureConversationSecurityTokenParameters)
			{
				SecureConversationSecurityTokenParameters val5 = (SecureConversationSecurityTokenParameters)protectionTokenParameters;
				BindingElementCollection val6 = new BindingElementCollection();
				if (val5.get_BootstrapSecurityBindingElement() != null)
				{
					((Collection<BindingElement>)(object)val6).Add((BindingElement)(object)val5.get_BootstrapSecurityBindingElement());
				}
				CheckAndAssignIssuedTokenParameters((SecurityTokenParameters)(object)TryGetNextStsIssuedTokenParameters(val6, ref disallowedStpDetected), val, ref disallowedStpDetected);
			}
			else
			{
				CheckAndAssignIssuedTokenParameters(protectionTokenParameters, val, ref disallowedStpDetected);
			}
		}
		SupportingTokenParameters optionalEndpointSupportingTokenParameters = val2.get_OptionalEndpointSupportingTokenParameters();
		IDictionary<string, SupportingTokenParameters> optionalOperationSupportingTokenParameters = val2.get_OptionalOperationSupportingTokenParameters();
		CheckOptionalTokenParameters(optionalEndpointSupportingTokenParameters, optionalOperationSupportingTokenParameters, ref disallowedStpDetected);
		return val.get_Value();
	}

	public static void CheckAndAssignIssuedTokenParameters(SecurityTokenParameters stp, ThrowOnMultipleAssignment<IssuedSecurityTokenParameters> issuedTokenParameters, ref bool disallowedStpDetected)
	{
		if (stp != null)
		{
			InfoCardTrace.Assert(!(stp is SecureConversationSecurityTokenParameters), "Should have already filtered this", new object[0]);
			if (!(stp is IssuedSecurityTokenParameters) && !(stp is RsaSecurityTokenParameters) && !(stp is SslSecurityTokenParameters) && !(stp is X509SecurityTokenParameters))
			{
				disallowedStpDetected = true;
			}
			else
			{
				issuedTokenParameters.set_Value((IssuedSecurityTokenParameters)(object)((stp is IssuedSecurityTokenParameters) ? stp : null));
			}
		}
	}

	private static void GetIssuedSecurityTokenParametersFromSupportingTokenParameters(SupportingTokenParameters parameters, ThrowOnMultipleAssignment<IssuedSecurityTokenParameters> issuedTokenParameters, ref bool disallowedStpDetected)
	{
		GetIssuedSecurityTokenParametersFromCollection(parameters.get_Endorsing(), issuedTokenParameters, ref disallowedStpDetected);
		GetIssuedSecurityTokenParametersFromCollection(parameters.get_SignedEndorsing(), issuedTokenParameters, ref disallowedStpDetected);
		GetIssuedSecurityTokenParametersFromCollection(parameters.get_Signed(), issuedTokenParameters, ref disallowedStpDetected);
		GetIssuedSecurityTokenParametersFromCollection(parameters.get_SignedEncrypted(), issuedTokenParameters, ref disallowedStpDetected);
	}

	private static void GetIssuedSecurityTokenParametersFromCollection(Collection<SecurityTokenParameters> collection, ThrowOnMultipleAssignment<IssuedSecurityTokenParameters> issuedTokenParameters, ref bool disallowedStpDetected)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		foreach (SecurityTokenParameters item in collection)
		{
			if (item is SecureConversationSecurityTokenParameters)
			{
				SecureConversationSecurityTokenParameters val = (SecureConversationSecurityTokenParameters)item;
				BindingElementCollection val2 = new BindingElementCollection();
				if (val.get_BootstrapSecurityBindingElement() != null)
				{
					((Collection<BindingElement>)(object)val2).Add((BindingElement)(object)val.get_BootstrapSecurityBindingElement());
				}
				CheckAndAssignIssuedTokenParameters((SecurityTokenParameters)(object)TryGetNextStsIssuedTokenParameters(val2, ref disallowedStpDetected), issuedTokenParameters, ref disallowedStpDetected);
			}
			else
			{
				CheckAndAssignIssuedTokenParameters(item, issuedTokenParameters, ref disallowedStpDetected);
			}
		}
	}

	private CreateIssuedTokenClientCredentials CreateClientCredentials(ServiceEndpoint svcEpr)
	{
		//IL_021a: Expected O, but got Unknown
		CreateIssuedTokenClientCredentials createIssuedTokenClientCredentials = new CreateIssuedTokenClientCredentials(this);
		EndpointAddress val = svcEpr.get_Address();
		IssuedSecurityTokenParameters val2 = null;
		Binding val3 = svcEpr.get_Binding();
		X509Certificate2Collection x509Certificate2Collection = new X509Certificate2Collection();
		bool disallowedStpDetected = false;
		try
		{
			while (val3 != null)
			{
				val2 = TryGetNextStsIssuedTokenParameters(val3.CreateBindingElements(), ref disallowedStpDetected);
				if (val2 == null)
				{
					break;
				}
				if (!disallowedStpDetected)
				{
					if ((EndpointAddress)null == val2.get_IssuerAddress() || null == val2.get_IssuerAddress().get_Uri())
					{
						break;
					}
					EndpointIdentity identity = val.get_Identity();
					X509CertificateEndpointIdentity val4 = (X509CertificateEndpointIdentity)(object)((identity is X509CertificateEndpointIdentity) ? identity : null);
					if (val4 != null)
					{
						x509Certificate2Collection.AddRange(val4.get_Certificates());
						x509Certificate2Collection.Remove(val4.get_Certificates()[0]);
						bool chainTrustPassed = false;
						InfoCardX509Validator.ValidateChainOrPeer(val4.get_Certificates()[0], x509Certificate2Collection, out chainTrustPassed);
						((ClientCredentials)createIssuedTokenClientCredentials).get_ServiceCertificate().get_ScopedCertificates().Add(val.get_Uri(), val4.get_Certificates()[0]);
					}
					val3 = val2.get_IssuerBinding();
					val = val2.get_IssuerAddress();
					continue;
				}
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new UnsupportedPolicyOptionsException());
			}
			if (m_params.Issuer.LeafCertificate != null)
			{
				bool chainTrustPassed2 = false;
				InfoCardX509Validator.ValidateChainOrPeer(m_params.Issuer.LeafCertificate, m_params.Issuer.SupportingCertificates, out chainTrustPassed2);
				((ClientCredentials)createIssuedTokenClientCredentials).get_ServiceCertificate().set_DefaultCertificate(m_params.Issuer.LeafCertificate);
				x509Certificate2Collection.AddRange(m_params.Issuer.SupportingCertificates);
			}
			else
			{
				X509CertificateEndpointIdentity val5 = null;
				EndpointIdentity identity2 = svcEpr.get_Address().get_Identity();
				val5 = (X509CertificateEndpointIdentity)(object)((identity2 is X509CertificateEndpointIdentity) ? identity2 : null);
				if (val5 == null)
				{
					throw InfoCardTrace.ThrowHelperError((Exception)(object)new TrustExchangeException(SR.GetString("InvalidIPSTSPolicy")));
				}
				((ClientCredentials)createIssuedTokenClientCredentials).get_ServiceCertificate().set_DefaultCertificate(val5.get_Certificates()[0]);
				x509Certificate2Collection.AddRange(val5.get_Certificates());
				x509Certificate2Collection.Remove(val5.get_Certificates()[0]);
			}
			InfoCardTrace.Assert(null != ((ClientCredentials)createIssuedTokenClientCredentials).get_ServiceCertificate().get_DefaultCertificate(), "This is configured in both cases above - either via the incoming params or via the endpoint retrieved from mex", new object[0]);
			((ClientCredentials)createIssuedTokenClientCredentials).get_ServiceCertificate().get_Authentication().set_CertificateValidationMode((X509CertificateValidationMode)4);
			((ClientCredentials)createIssuedTokenClientCredentials).get_ServiceCertificate().get_Authentication().set_CustomCertificateValidator(InfoCardX509Validator.Create(x509Certificate2Collection));
			return createIssuedTokenClientCredentials;
		}
		catch (SecurityTokenValidationException val6)
		{
			SecurityTokenValidationException inner = val6;
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new IdentityValidationException(SR.GetString("RecipientCertificateNotValid"), (Exception)(object)inner));
		}
	}

	private void WriteRequestedTokenFrom(XmlReader reader, XmlWriter writer)
	{
		do
		{
			if (!reader.Read())
			{
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new TrustExchangeException(SR.GetString("NoTokenReturned")));
			}
		}
		while (!reader.IsStartElement(m_protocolProfile.WSTrust.RequestedSecurityToken, m_protocolProfile.WSTrust.Namespace));
		reader.Read();
		writer.WriteNode(reader, defattr: false);
	}

	private ServiceEndpointCollection GetServiceEndpointCollection(Uri serviceUri, Uri mexUri)
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected O, but got Unknown
		bool flag = false;
		InfoCardMetadataExchangeClient mex = new InfoCardMetadataExchangeClient();
		mex.Proxy = base.UserProxy;
		MetadataSet metadataSet = null;
		((MetadataExchangeClient)mex).set_ResolveMetadataReferences(true);
		((MetadataExchangeClient)mex).set_MaximumResolvedReferences(InfoCardConstants.MaximumMexChainLength);
		EndpointAddress metadataAddress = new EndpointAddress(mexUri, (AddressHeader[])(object)new AddressHeader[0]);
		try
		{
			ExecuteCancelable(delegate
			{
				metadataSet = ((MetadataExchangeClient)mex).GetMetadata(metadataAddress);
			}, delegate
			{
				mex.Abort();
			});
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
				ExecuteCancelable(delegate
				{
					metadataSet = ((MetadataExchangeClient)mex).GetMetadata(mexUri, (MetadataExchangeClientMode)1);
				}, delegate
				{
					mex.Abort();
				});
				flag = true;
			}
			catch (Exception ex2)
			{
				if (InfoCardTrace.IsFatal(ex2))
				{
					throw;
				}
			}
		}
		if (!flag)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new TrustExchangeException(SR.GetString("EndpointNotFound")));
		}
		WsdlImporter imp = new WsdlImporter(metadataSet);
		((MetadataImporter)imp).get_State().Add("MetadataExchangeClientKey", mex);
		ServiceEndpointCollection serviceEndpoints = null;
		ExecuteCancelable(delegate
		{
			serviceEndpoints = ((MetadataImporter)imp).ImportAllEndpoints();
		}, null);
		return serviceEndpoints;
	}

	private static BindingElementCollection FedChainUpdateProxyForHttpAndRestrictTransportBinding(BindingElementCollection bindingElements, IWebProxy proxy)
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		bindingElements = Utility.UpdateProxyForHttpAndRestrictTransportBinding(bindingElements, proxy, turnOffClientAuthOnTransport: true);
		bool disallowedStpDetected = false;
		IssuedSecurityTokenParameters val = TryGetNextStsIssuedTokenParameters(bindingElements, ref disallowedStpDetected);
		if (val != null && (EndpointAddress)null != val.get_IssuerAddress() && null != val.get_IssuerAddress().get_Uri() && val.get_IssuerBinding() != null)
		{
			val.set_IssuerBinding((Binding)new CustomBinding(FedChainUpdateProxyForHttpAndRestrictTransportBinding(val.get_IssuerBinding().CreateBindingElements(), proxy)));
		}
		return bindingElements;
	}

	private static Binding FedChainUpdateProxyAndRestrictTransportBindingWrapper(Binding binding, IWebProxy proxy)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		BindingElementCollection bindingElements = binding.CreateBindingElements();
		return (Binding)new CustomBinding(FedChainUpdateProxyForHttpAndRestrictTransportBinding(bindingElements, proxy));
	}

	private SecurityToken CreateIssuedToken(CardSpacePolicyElement[] policyElements, SecurityTokenSerializer tokenSerializer)
	{
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected O, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		WindowsImpersonationContext val = base.RequestorIdentity.Impersonate();
		try
		{
			try
			{
				int num = policyElements.Length - 1;
				InfoCardTrace.Assert(0 <= num, "lastElementIndex should be non-negative", new object[0]);
				if (policyElements[num].get_IsManagedIssuer())
				{
					num--;
				}
				int num2 = num;
				if (0 < num2)
				{
					InfoCardPolicy[] array = new InfoCardPolicy[num2];
					for (int i = 0; i < num2; i++)
					{
						array[i] = PolicyFactory.CreatePolicyForIntermediateGetBrowserTokenRequest(policyElements[i], null, 0u, null);
						array[i].Validate();
					}
				}
				InfoCardPolicy infoCardPolicy = PolicyFactory.CreatePolicyForGetBrowserTokenRequest(policyElements[num], m_params.PrivacyUrl, m_params.PrivacyVersion, RecipientIdentity.CreateIdentity(m_params.Recipient.CreateEndpointAddress(), validate: true), PolicyUsageContext.GetToken);
				infoCardPolicy.Validate();
				base.Policy = infoCardPolicy;
				base.OnProcess();
				if (base.ProcessingException != null)
				{
					throw InfoCardTrace.ThrowHelperError(base.ProcessingException);
				}
				SecurityKeyIdentifierClause val2 = tokenSerializer.ReadKeyIdentifierClause((XmlReader)(object)Utility.CreateReaderWithQuotas(base.Token.InternalTokenReference));
				SecurityKeyIdentifierClause val3 = tokenSerializer.ReadKeyIdentifierClause((XmlReader)(object)Utility.CreateReaderWithQuotas(base.Token.ExternalTokenReference));
				if (base.Token.SymmetricProof == null)
				{
					m_proofToken = new SelfIssuedAuthProofToken(GetPrivateCryptography(), base.Token.ExpirationTime);
				}
				else
				{
					m_proofToken = new SelfIssuedAuthProofToken(new InMemorySymmetricSecurityKey(base.Token.SymmetricProof.Key), base.Token.ExpirationTime);
				}
				return (SecurityToken)new GenericXmlSecurityToken(base.Token.ProtectedToken, (SecurityToken)(object)m_proofToken, base.Token.EffectiveTime, base.Token.ExpirationTime, val2, val3, (ReadOnlyCollection<IAuthorizationPolicy>)null);
			}
			finally
			{
				val.Undo();
			}
		}
		catch
		{
			throw;
		}
	}

	protected override void OnDisposeAsUser()
	{
		base.OnDisposeAsUser();
		if (m_proofToken != null)
		{
			((IDisposable)m_proofToken).Dispose();
			m_proofToken = null;
		}
	}
}
