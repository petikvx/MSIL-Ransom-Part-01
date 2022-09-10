using System;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Security.Tokens;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class InfoCardServiceClientCredentials : ClientCredentials
{
	private class InfoCardServiceClientCredentialsSecurityTokenManager : ClientCredentialsSecurityTokenManager
	{
		private InfoCard m_card;

		private TokenFactoryCredential m_credentials;

		private ProtocolProfile m_protocolProfile;

		public InfoCardServiceClientCredentialsSecurityTokenManager(InfoCardServiceClientCredentials creds)
			: base((ClientCredentials)(object)creds)
		{
			m_card = creds.SelectedCard;
			m_credentials = creds.m_credentials;
			m_protocolProfile = creds.ProtocolVersionProfile;
		}

		public override SecurityTokenProvider CreateSecurityTokenProvider(SecurityTokenRequirement tokenRequirement)
		{
			//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e6: Invalid comparison between Unknown and I4
			if (tokenRequirement == null)
			{
				throw InfoCardTrace.ThrowHelperArgumentNull("tokenRequirement");
			}
			string tokenType = tokenRequirement.get_TokenType();
			bool flag = null != ((InfoCardServiceClientCredentials)(object)((ClientCredentialsSecurityTokenManager)this).get_ClientCredentials()).EndorsingSignatureTokenProvider;
			if (((ClientCredentialsSecurityTokenManager)this).IsIssuedSecurityTokenRequirement(tokenRequirement))
			{
				if (m_credentials.CredentialType != TokenFactoryCredentialType.SelfIssuedCredential)
				{
					throw InfoCardTrace.ThrowHelperError((Exception)(object)new TokenCreationException(SR.GetString("CardDoesNotMatchRequiredAuthType")));
				}
				IssuedSecurityTokenParameters property = tokenRequirement.GetProperty<IssuedSecurityTokenParameters>(ServiceModelSecurityTokenRequirement.get_IssuedSecurityTokenParametersProperty());
				EndpointAddress property2 = tokenRequirement.GetProperty<EndpointAddress>(ServiceModelSecurityTokenRequirement.get_TargetAddressProperty());
				if (property.get_IssuerAddress() != (EndpointAddress)null && Utility.CompareUri(property.get_IssuerAddress().get_Uri(), XmlNames.WSIdentity.SelfIssuerUriValue))
				{
					return (SecurityTokenProvider)(object)new CustomTokenProvider(property, m_card, property2, ((InfoCardServiceClientCredentials)(object)((ClientCredentialsSecurityTokenManager)this).get_ClientCredentials()).IsSelfIssuedCred, m_protocolProfile);
				}
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new TokenCreationException(SR.GetString("InvalidIssuerForIssuedToken")));
			}
			if (tokenType == SecurityTokenTypes.get_X509Certificate())
			{
				if ((int)tokenRequirement.get_KeyUsage() == 1)
				{
					if (m_credentials.CredentialType != TokenFactoryCredentialType.X509CertificateCredential)
					{
						throw InfoCardTrace.ThrowHelperError((Exception)(object)new TokenCreationException(SR.GetString("CardDoesNotMatchRequiredAuthType")));
					}
					return (SecurityTokenProvider)(object)new RemoteCryptoTokenProvider(((ClientCredentialsSecurityTokenManager)this).get_ClientCredentials().get_ClientCertificate().get_Certificate());
				}
				return ((ClientCredentialsSecurityTokenManager)this).CreateSecurityTokenProvider(tokenRequirement);
			}
			if (tokenType == ServiceModelSecurityTokenTypes.get_MutualSslnego())
			{
				if (m_credentials.CredentialType != TokenFactoryCredentialType.X509CertificateCredential)
				{
					throw InfoCardTrace.ThrowHelperError((Exception)(object)new TokenCreationException(SR.GetString("CardDoesNotMatchRequiredAuthType")));
				}
				return ((ClientCredentialsSecurityTokenManager)this).CreateSecurityTokenProvider(tokenRequirement);
			}
			if (tokenType == ServiceModelSecurityTokenTypes.get_AnonymousSslnego())
			{
				return ((ClientCredentialsSecurityTokenManager)this).CreateSecurityTokenProvider(tokenRequirement);
			}
			if (tokenType == ServiceModelSecurityTokenTypes.get_SecureConversation())
			{
				return ((ClientCredentialsSecurityTokenManager)this).CreateSecurityTokenProvider(tokenRequirement);
			}
			if (!(tokenType == SecurityTokenTypes.get_Kerberos()) && !(tokenType == ServiceModelSecurityTokenTypes.get_Spnego()))
			{
				if (tokenType == SecurityTokenTypes.get_UserName())
				{
					if (m_credentials.CredentialType != TokenFactoryCredentialType.UserNamePasswordCredential)
					{
						throw InfoCardTrace.ThrowHelperError((Exception)(object)new TokenCreationException(SR.GetString("CardDoesNotMatchRequiredAuthType")));
					}
					return ((ClientCredentialsSecurityTokenManager)this).CreateSecurityTokenProvider(tokenRequirement);
				}
				if (tokenType == ServiceModelSecurityTokenTypes.get_SspiCredential())
				{
					if (m_credentials.CredentialType != TokenFactoryCredentialType.KerberosCredential && m_credentials.CredentialType != TokenFactoryCredentialType.UserNamePasswordCredential)
					{
						throw InfoCardTrace.ThrowHelperError((Exception)(object)new TokenCreationException(SR.GetString("CardDoesNotMatchRequiredAuthType")));
					}
					return ((ClientCredentialsSecurityTokenManager)this).CreateSecurityTokenProvider(tokenRequirement);
				}
				if (tokenType == SecurityTokenTypes.get_Rsa() && flag)
				{
					InfoCardServiceClientCredentials infoCardServiceClientCredentials = (InfoCardServiceClientCredentials)(object)((ClientCredentialsSecurityTokenManager)this).get_ClientCredentials();
					return (SecurityTokenProvider)(object)infoCardServiceClientCredentials.EndorsingSignatureTokenProvider;
				}
				return ((ClientCredentialsSecurityTokenManager)this).CreateSecurityTokenProvider(tokenRequirement);
			}
			if (m_credentials.CredentialType != TokenFactoryCredentialType.KerberosCredential)
			{
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new TokenCreationException(SR.GetString("CardDoesNotMatchRequiredAuthType")));
			}
			return ((ClientCredentialsSecurityTokenManager)this).CreateSecurityTokenProvider(tokenRequirement);
		}
	}

	private InfoCard m_card;

	private TokenFactoryCredential m_credentials;

	private bool m_isSelfIssued;

	private ProtocolProfile m_protocolProfile;

	private RSATokenProvider m_endorsingSigTokenProvider;

	public InfoCard SelectedCard
	{
		get
		{
			return m_card;
		}
		set
		{
			m_card = value;
		}
	}

	public bool IsSelfIssuedCred
	{
		get
		{
			return m_isSelfIssued;
		}
		set
		{
			m_isSelfIssued = value;
		}
	}

	public RSATokenProvider EndorsingSignatureTokenProvider
	{
		get
		{
			return m_endorsingSigTokenProvider;
		}
		set
		{
			m_endorsingSigTokenProvider = value;
		}
	}

	public ProtocolProfile ProtocolVersionProfile => m_protocolProfile;

	public InfoCardServiceClientCredentials(TokenFactoryCredential creds, ProtocolProfile profile)
	{
		m_credentials = creds;
		m_protocolProfile = profile;
	}

	public InfoCardServiceClientCredentials(InfoCardServiceClientCredentials other, ProtocolProfile profile)
		: base((ClientCredentials)(object)other)
	{
		m_credentials = other.m_credentials;
		m_endorsingSigTokenProvider = other.m_endorsingSigTokenProvider;
		m_protocolProfile = profile;
	}

	protected override ClientCredentials CloneCore()
	{
		return (ClientCredentials)(object)new InfoCardServiceClientCredentials(this, m_protocolProfile);
	}

	public override void ApplyClientBehavior(ServiceEndpoint serviceEndpoint, ClientRuntime behavior)
	{
	}

	public override SecurityTokenManager CreateSecurityTokenManager()
	{
		return (SecurityTokenManager)(object)new InfoCardServiceClientCredentialsSecurityTokenManager(this);
	}
}
