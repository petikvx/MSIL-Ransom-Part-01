using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Security.Principal;
using System.ServiceModel.Description;
using System.Text;
using System.Threading;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class GetTokenRequest : ClientUIRequest
{
	public enum TrustDecision : byte
	{
		NoTrustDecision,
		IsTrusted,
		IsNotTrusted
	}

	private InfoCardPolicy[] m_policyChain;

	private InfoCardPolicy m_policy;

	private TokenDescriptor m_token;

	private ITokenFactory m_tokenFactory;

	private LedgerEntry m_ledgerEntry;

	private InfoCard m_selectedCard;

	private Recipient m_recipient;

	private object m_createSecurityTokenDoneMonitor = new object();

	private bool m_isProcessingComplete = true;

	private bool m_userProceededToCreateToken;

	public TokenDescriptor Token => m_token;

	public InfoCardPolicy Policy
	{
		get
		{
			return m_policy;
		}
		protected set
		{
			m_policy = value;
		}
	}

	public GetTokenRequest(Process callingProcess, WindowsIdentity callingIdentity, InfoCardUIAgent uiAgent, IntPtr rpcHandle, Stream inArgs, Stream outArgs)
		: base(callingProcess, callingIdentity, uiAgent, rpcHandle, inArgs, outArgs, InfoCardUIAgent.CallMode.GetToken, ExceptionList.AllNonFatal)
	{
	}

	protected Recipient GetRecipient()
	{
		if (m_recipient == null)
		{
			m_recipient = new Recipient(m_policy.Recipient, isCertCached: false, m_policy.PrivacyPolicyVersion);
		}
		return m_recipient;
	}

	protected override void OnMarshalInArgs()
	{
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected O, but got Unknown
		BinaryReader binaryReader = new InfoCardBinaryReader(base.InArgs, Encoding.Unicode);
		int num = binaryReader.ReadInt32();
		if (num > 0 && num <= 50)
		{
			m_policyChain = new InfoCardPolicy[num];
			for (int i = 0; i < num; i++)
			{
				string recipientXml = Utility.DeserializeString(binaryReader);
				string issuerXml = Utility.DeserializeString(binaryReader);
				string policyXml = Utility.DeserializeString(binaryReader);
				string privacyUrl = Utility.DeserializeString(binaryReader);
				uint privacyVersion = binaryReader.ReadUInt32();
				bool isManaged = binaryReader.ReadBoolean();
				m_policyChain[i] = PolicyFactory.CreatePolicyForGetTokenRequest(binaryReader, recipientXml, issuerXml, policyXml, isManaged);
				if (i == 0)
				{
					m_policyChain[i].SetRecipientInfo(m_policyChain[0].ImmediateTokenRecipient, privacyUrl, privacyVersion);
				}
				else
				{
					m_policyChain[i].SetRecipientInfo(m_policyChain[0].ImmediateTokenRecipient, m_policyChain[0].PrivacyPolicyLink, m_policyChain[0].PrivacyPolicyVersion);
				}
			}
			int num2 = num - 1;
			if (m_policyChain[num2].IsManaged)
			{
				if (num2 == 0)
				{
					throw InfoCardTrace.ThrowHelperError((Exception)new InfoCardArgumentException(SR.GetString("InvalidPolicyLength")));
				}
				num2--;
			}
			m_policy = m_policyChain[num2];
			m_policy.Validate();
			return;
		}
		throw InfoCardTrace.ThrowHelperError((Exception)new InfoCardArgumentException(SR.GetString("InvalidPolicyLength")));
	}

	protected override void OnProcess()
	{
		StartAndWaitForUIAgent();
	}

	protected override void OnMarshalOutArgs()
	{
		BinaryWriter bwriter = new BinaryWriter(base.OutArgs, Encoding.Unicode);
		m_token.Write(bwriter);
		SymmetricAlgorithm symmetricProof = m_token.SymmetricProof;
		CryptoSession cryptoSession = null;
		if (symmetricProof == null)
		{
			RSACryptoServiceProvider privateCryptography = GetPrivateCryptography();
			cryptoSession = CryptoSession.Create(base.CallerProcess, m_token.ExpirationTime, RequestorIdentity, privateCryptography);
		}
		else
		{
			cryptoSession = CryptoSession.Create(base.CallerProcess, m_token.ExpirationTime, RequestorIdentity, symmetricProof.Key);
		}
		cryptoSession.Write(bwriter);
	}

	protected RSACryptoServiceProvider GetPrivateCryptography()
	{
		return m_selectedCard.GetPrivateCryptography(GetRecipient().RecipientId);
	}

	protected override void OnDisposeAsUser()
	{
		base.OnDisposeAsUser();
		if (m_token != null)
		{
			m_token.Dispose();
			m_token = null;
		}
	}

	public void CancelSelectCard()
	{
		m_userProceededToCreateToken = false;
		m_isProcessingComplete = true;
	}

	public int SelectCard(InfoCard card, bool isSelfIssued)
	{
		lock (m_createSecurityTokenDoneMonitor)
		{
			while (m_userProceededToCreateToken && !m_isProcessingComplete)
			{
				Monitor.Wait(m_createSecurityTokenDoneMonitor);
			}
			m_userProceededToCreateToken = false;
			m_isProcessingComplete = false;
			int num = 0;
			TokenCreationParameter parameter = null;
			ServiceEndpoint endPoint = null;
			IWebProxy proxy = null;
			StoreConnection connection = StoreConnection.GetConnection();
			try
			{
				card.Connection = connection;
				if (!isSelfIssued)
				{
					if (1 == card.CreationParameters.Count)
					{
						num = 0;
						parameter = card.CreationParameters[0];
					}
					else
					{
						for (int i = 0; i < card.CreationParameters.Count; i++)
						{
							try
							{
								endPoint = RemoteTokenFactory.DoMexExchange(card.CreationParameters[i], base.UserProxy);
								num = i;
								parameter = card.CreationParameters[num];
							}
							catch (TrustExchangeException)
							{
								if (i == card.CreationParameters.Count - 1)
								{
									throw InfoCardTrace.ThrowHelperError((Exception)(object)new TrustExchangeException(SR.GetString("InvalidServiceUri")));
								}
								continue;
							}
							break;
						}
					}
					proxy = base.UserProxy;
				}
			}
			finally
			{
				connection.Close();
			}
			m_tokenFactory = TokenFactoryFactory.Create(card, parameter, endPoint, proxy);
			m_selectedCard = card;
			return num;
		}
	}

	public void CancelCreateSecurityToken()
	{
		if (m_tokenFactory != null)
		{
			m_tokenFactory.Abort();
		}
		m_userProceededToCreateToken = true;
	}

	public DisplayToken CreateSecurityToken(TokenFactoryCredential credential, bool discloseOptional)
	{
		lock (m_createSecurityTokenDoneMonitor)
		{
			try
			{
				m_ledgerEntry = GetLedgerEntry();
				if (m_token != null)
				{
					m_token.Dispose();
					m_token = null;
				}
				using (credential)
				{
					m_token = m_tokenFactory.CreateToken(m_selectedCard, credential, m_policy, discloseOptional);
				}
				m_ledgerEntry.DisclosureDate = DateTime.UtcNow;
				m_ledgerEntry.DisclosedClaims = new string[m_token.DisclosedClaims.Count];
				for (int i = 0; i < m_token.DisclosedClaims.Count; i++)
				{
					m_ledgerEntry.DisclosedClaims[i] = m_token.DisclosedClaims[i];
				}
				Array.Clear(m_selectedCard.Key, 0, m_selectedCard.Key.Length);
				return m_token.DisplayToken;
			}
			finally
			{
				m_isProcessingComplete = true;
				m_userProceededToCreateToken = true;
				Monitor.Pulse(m_createSecurityTokenDoneMonitor);
			}
		}
	}

	private LedgerEntry GetLedgerEntry()
	{
		LedgerEntry ledgerEntry = null;
		StoreConnection connection = StoreConnection.GetConnection();
		try
		{
			ledgerEntry = m_selectedCard.TryGetLedgerEntry(connection, m_policy.Recipient.GetIdentifier());
			if (ledgerEntry == null)
			{
				return m_selectedCard.CreateLedgerEntry(GetRecipient(), m_policy.ImmediateTokenRecipient.GetOrganizationIdentifier());
			}
			m_selectedCard.CheckAndUpdateLedgerEntry(ledgerEntry, m_policy.ImmediateTokenRecipient.GetOrganizationIdentifier());
			return ledgerEntry;
		}
		finally
		{
			connection.Close();
		}
	}

	public void SaveLedgerEntry()
	{
		StoreConnection connection = StoreConnection.GetConnection();
		try
		{
			connection.BeginTransaction();
			try
			{
				m_ledgerEntry.Save(connection);
				connection.CommitTransaction();
			}
			catch
			{
				connection.RollbackTransaction();
				throw;
			}
		}
		finally
		{
			connection.Close();
		}
	}
}
