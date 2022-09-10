using System;
using System.Collections.ObjectModel;
using System.IdentityModel.Policy;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;
using System.ServiceModel;
using System.ServiceModel.Security.Tokens;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class CustomTokenProvider : SecurityTokenProvider, IDisposable
{
	private InfoCardPolicy m_policy;

	private InfoCard m_card;

	private IssuedSecurityTokenParameters m_parameters;

	private TokenDescriptor m_token;

	private EndpointAddress m_target;

	private SelfIssuedSamlTokenFactory m_tokenFactory;

	private bool m_isSelfIssuedCreds;

	private ProtocolProfile m_protocolProfile;

	private SelfIssuedAuthProofToken m_proofToken;

	public CustomTokenProvider(IssuedSecurityTokenParameters parameters, InfoCard card, EndpointAddress target, bool isSelfIssuedCreds, ProtocolProfile profile)
	{
		m_isSelfIssuedCreds = isSelfIssuedCreds;
		m_card = card;
		m_parameters = parameters;
		m_target = target;
		m_protocolProfile = profile;
		ValidatePolicy();
		m_tokenFactory = new SelfIssuedSamlTokenFactory();
	}

	public void Dispose()
	{
		if (m_token != null)
		{
			m_token.Dispose();
			m_token = null;
		}
		if (m_proofToken != null)
		{
			m_proofToken.Dispose();
			m_proofToken = null;
		}
	}

	private void ValidatePolicy()
	{
		try
		{
			m_policy = PolicyFactory.CreatePolicyForCustomTokenProvider(m_target, m_parameters, m_protocolProfile);
			m_policy.SetRecipientInfo(m_policy.ImmediateTokenRecipient, null, 0u);
			if (m_isSelfIssuedCreds)
			{
				m_policy.ThrowIfNonPpidClaimsPresent();
			}
			m_policy.Validate();
		}
		catch (Exception ex)
		{
			if (InfoCardTrace.IsFatal(ex))
			{
				throw;
			}
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new TrustExchangeException(SR.GetString("FailedReadingIPSTSPolicy"), ex));
		}
	}

	protected override SecurityToken GetTokenCore(TimeSpan timeout)
	{
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected O, but got Unknown
		StoreConnection connection = StoreConnection.GetConnection();
		m_card.Connection = connection;
		try
		{
			m_token = m_tokenFactory.CreateToken(m_card, null, m_policy, discloseOptional: false);
			if (m_token.SymmetricProof == null)
			{
				m_proofToken = new SelfIssuedAuthProofToken(m_card.GetPrivateCryptography(m_policy.Recipient.GetIdentifier()), m_token.ExpirationTime);
			}
			else
			{
				m_proofToken = new SelfIssuedAuthProofToken(new InMemorySymmetricSecurityKey(m_token.SymmetricProof.Key), m_token.ExpirationTime);
			}
			return (SecurityToken)new GenericXmlSecurityToken(m_token.ProtectedToken, (SecurityToken)(object)m_proofToken, m_token.EffectiveTime, m_token.ExpirationTime, (SecurityKeyIdentifierClause)new SamlAssertionKeyIdentifierClause(m_token.TokenId), (SecurityKeyIdentifierClause)null, (ReadOnlyCollection<IAuthorizationPolicy>)null);
		}
		finally
		{
			connection.Close();
			m_card.Connection = null;
		}
	}
}
