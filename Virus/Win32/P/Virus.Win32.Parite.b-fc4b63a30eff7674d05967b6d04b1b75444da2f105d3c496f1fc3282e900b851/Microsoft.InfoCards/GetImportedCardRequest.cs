using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class GetImportedCardRequest : UIAgentRequest
{
	public enum ImportCardMatchStatus : byte
	{
		MatchNone,
		MatchSameVersion,
		MatchNewerVersion,
		MatchOlderVersion
	}

	private InfoCard m_card;

	private Recipient m_issuer;

	private string m_filename;

	private string m_policyLink;

	private InfoCardPolicy m_policy;

	private ImportCardMatchStatus m_matchFlag;

	public GetImportedCardRequest(IntPtr rpcHandle, Stream inArgs, Stream outArgs, ClientUIRequest parent)
		: base(rpcHandle, inArgs, outArgs, parent)
	{
		m_matchFlag = ImportCardMatchStatus.MatchNone;
	}

	protected override void OnInitializeAsSystem()
	{
		base.OnInitializeAsSystem();
		m_policy = GetPolicy();
	}

	protected override void OnMarshalInArgs()
	{
		BinaryReader reader = new InfoCardBinaryReader(base.InArgs, Encoding.Unicode);
		m_filename = Utility.DeserializeString(reader);
	}

	protected override void OnProcess()
	{
		StoreConnection connection = StoreConnection.GetConnection();
		try
		{
			InfoCardTrace.Assert(!string.IsNullOrEmpty(m_filename), "No file name provided for import", new object[0]);
			InfoCardXmlSerializer infoCardXmlSerializer = new InfoCardXmlSerializer(connection);
			infoCardXmlSerializer.CheckSignature = true;
			infoCardXmlSerializer.Deserialize(m_filename);
			m_card = infoCardXmlSerializer.Card;
			m_card.IsImported = true;
			m_card.InstalledOn = DateTime.Now;
			X509Certificate2 issuer = infoCardXmlSerializer.Issuer;
			if (issuer != null && m_card != null && m_card.IsComplete())
			{
				Recipient.RecipientCertParameters recipientParams;
				string text = Recipient.CertGetRecipientIdHash(issuer, infoCardXmlSerializer.AdditionalIssuerCerts, infoCardXmlSerializer.IsIssuerChainTrusted, out recipientParams);
				string recipientOrgId = Recipient.CertGetRecipientOrganizationIdHash(issuer, infoCardXmlSerializer.AdditionalIssuerCerts, infoCardXmlSerializer.IsIssuerChainTrusted);
				base.ParentRequest.CertCacheAdd(text, issuer);
				m_issuer = new Recipient(issuer, text, recipientOrgId, isCertCached: true, m_card.PrivacyPolicyVersion, recipientParams);
				if (m_issuer.IsOrganizationVerified())
				{
					m_card.IssuerName = m_issuer.RecipientParameters.m_organization;
				}
				else
				{
					m_card.IssuerName = m_issuer.RecipientParameters.m_cn;
				}
				m_policyLink = m_card.PrivacyPolicyLink;
				List<QueryParameter> list = new List<QueryParameter>();
				list.Add(new QueryParameter("ix_objecttype", 1));
				list.Add(new QueryParameter("ix_globalid", GlobalId.DeriveFrom(m_card.Id.ToString())));
				DataRow singleRow = connection.GetSingleRow(QueryDetails.FullRow, list.ToArray());
				if (singleRow == null)
				{
					return;
				}
				using MemoryStream stream = new MemoryStream(singleRow.GetDataField());
				InfoCard infoCard = new InfoCard(stream);
				if (infoCard.Epoch == m_card.Epoch)
				{
					m_matchFlag = ImportCardMatchStatus.MatchSameVersion;
				}
				else if (infoCard.Epoch < m_card.Epoch)
				{
					m_matchFlag = ImportCardMatchStatus.MatchOlderVersion;
				}
				else
				{
					m_matchFlag = ImportCardMatchStatus.MatchNewerVersion;
				}
				m_card.CopyMetaData(infoCard);
				return;
			}
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new ImportException(SR.GetString("InvalidImportFile")));
		}
		finally
		{
			connection.Close();
		}
	}

	protected override void OnMarshalOutArgs()
	{
		Stream outArgs = base.OutArgs;
		if (m_card != null && m_issuer != null && m_card.IsComplete())
		{
			StoreConnection connection = StoreConnection.GetConnection();
			try
			{
				m_card.AgentSerialize(outArgs, base.ParentRequest is GetTokenRequest, m_policy, connection, new CultureInfo(base.ParentRequest.UserLanguage));
				BinaryWriter binaryWriter = new BinaryWriter(outArgs, Encoding.Unicode);
				m_issuer.Serialize(binaryWriter);
				Utility.SerializeString(binaryWriter, m_policyLink);
				binaryWriter.Write((byte)m_matchFlag);
			}
			finally
			{
				connection.Close();
			}
		}
	}
}
