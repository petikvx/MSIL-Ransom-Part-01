using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class GetPolicyDetailsRequest : UIAgentRequest
{
	private InfoCardPolicy m_policy;

	private Recipient m_recipient;

	private string m_privacyPolicyLink = string.Empty;

	public GetPolicyDetailsRequest(IntPtr rpcHandle, Stream inArgs, Stream outArgs, ClientUIRequest parent)
		: base(rpcHandle, inArgs, outArgs, parent)
	{
	}

	protected override void OnInitializeAsSystem()
	{
		base.OnInitializeAsSystem();
		m_policy = GetPolicy();
	}

	protected override void OnMarshalInArgs()
	{
	}

	protected override void OnProcess()
	{
		InfoCardTrace.Assert(null != m_policy, "Null policy", new object[0]);
		StoreConnection connection = StoreConnection.GetConnection();
		try
		{
			List<QueryParameter> list = new List<QueryParameter>();
			QueryParameter item = new QueryParameter("ix_objecttype", -3);
			list.Add(item);
			item = new QueryParameter("ix_name", m_policy.Recipient.GetIdentifier());
			list.Add(item);
			DataRow singleRow = connection.GetSingleRow(list.ToArray());
			if (m_policy.Recipient is X509RecipientIdentity x509RecipientIdentity)
			{
				base.ParentRequest.CertCacheAdd(m_policy.Recipient.GetIdentifier(), x509RecipientIdentity.LeafCertificate);
			}
			if (singleRow != null)
			{
				m_recipient = new Recipient(new MemoryStream(singleRow.GetDataField()), m_policy.Recipient, isCertCached: true);
				if (m_recipient.Trust == Recipient.TrustDecision.IsTrusted && m_recipient.PrivacyPolicyVersion != m_policy.PrivacyPolicyVersion)
				{
					m_recipient.Trust = Recipient.TrustDecision.PolicyVersionChange;
				}
				m_recipient.PrivacyPolicyVersion = m_policy.PrivacyPolicyVersion;
			}
			else
			{
				m_recipient = new Recipient(m_policy.Recipient, isCertCached: true, m_policy.PrivacyPolicyVersion);
				m_recipient.Trust = Recipient.TrustDecision.NoTrustDecision;
			}
			m_privacyPolicyLink = m_policy.PrivacyPolicyLink;
		}
		finally
		{
			connection.Close();
		}
	}

	protected override void OnMarshalOutArgs()
	{
		InfoCardTrace.Assert(null != m_policy, "Null policy", new object[0]);
		BinaryWriter binaryWriter = new BinaryWriter(base.OutArgs, Encoding.Unicode);
		binaryWriter.Write(m_policy.RequiresManagedCard);
		binaryWriter.Write(m_policy.RequiresSelfIssuedCard);
		binaryWriter.Write(base.ParentRequest is GetBrowserTokenRequest);
		m_recipient.Serialize(binaryWriter);
		Utility.SerializeString(binaryWriter, m_privacyPolicyLink);
		if (m_policy.RequiredClaims != null)
		{
			binaryWriter.Write(m_policy.RequiredClaims.Length);
			for (int i = 0; i < m_policy.RequiredClaims.Length; i++)
			{
				Utility.SerializeString(binaryWriter, m_policy.RequiredClaims[i]);
			}
		}
		else
		{
			binaryWriter.Write(0);
		}
		if (m_policy.OptionalClaims != null)
		{
			binaryWriter.Write(m_policy.OptionalClaims.Length);
			for (int j = 0; j < m_policy.OptionalClaims.Length; j++)
			{
				Utility.SerializeString(binaryWriter, m_policy.OptionalClaims[j]);
			}
		}
		else
		{
			binaryWriter.Write(0);
		}
	}
}
