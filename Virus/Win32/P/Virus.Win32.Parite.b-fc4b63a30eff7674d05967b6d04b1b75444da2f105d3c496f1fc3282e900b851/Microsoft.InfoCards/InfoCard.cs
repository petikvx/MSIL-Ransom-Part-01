using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class InfoCard : IXmlSerializable
{
	private enum PinAction : byte
	{
		NoPin,
		PinSame,
		PinAdded,
		PinRemoved,
		PinChanged
	}

	private const int InvalidRow = 0;

	private const byte Marker = 29;

	private const byte Version = 1;

	public const int KeySize = 2048;

	public const int MasterKeySize = 32;

	public const int SaltSize = 16;

	private InfoCardClaimCollection m_claims;

	private DateTime m_expiresOn = DateTime.MaxValue;

	private uint m_epoch;

	private Uri m_id;

	private DateTime m_issuedOn = DateTime.MinValue;

	private bool m_isImported;

	private DateTime m_installedOn = DateTime.Now;

	private string m_issuerName = string.Empty;

	private string m_language = string.Empty;

	private LedgerEntryCollection m_ledger;

	private byte[] m_logo;

	private string m_mimeType = string.Empty;

	private string m_name = string.Empty;

	private DateTime m_lastUpdate = DateTime.MinValue;

	private int m_rowId;

	private StoreConnection m_storeConnection;

	private int m_backgroundColor;

	private string[] m_tokenTypes;

	private RequireAppliesToStatus m_requireAppliesTo;

	private byte[] m_pinHash;

	private bool m_isSelfIssued;

	private byte[] m_salt;

	private InfoCardMasterKey m_masterKey;

	private string m_privacyPolicyLink = string.Empty;

	private byte[] m_issuerIdentifierAsBytes;

	private Uri m_issuer;

	private uint m_privacyPolicyVersion;

	private string m_pin = string.Empty;

	private string m_oldPin = string.Empty;

	private PinAction m_pinAction;

	private InfocardExtendedInformationCollection m_extendedInformation;

	private bool m_readIssuerInformation;

	private RPIdentityRequirement m_rpStrongIdentityRequired;

	private List<TokenCreationParameter> m_creationParameters;

	public string[] TokenTypes
	{
		set
		{
			m_tokenTypes = value;
		}
	}

	public List<TokenCreationParameter> CreationParameters
	{
		get
		{
			if (m_creationParameters == null)
			{
				m_creationParameters = new List<TokenCreationParameter>();
			}
			return m_creationParameters;
		}
	}

	public DateTime ExpiresOn
	{
		get
		{
			return m_expiresOn;
		}
		set
		{
			m_expiresOn = value;
		}
	}

	public uint Epoch
	{
		get
		{
			return m_epoch;
		}
		set
		{
			m_epoch = value;
		}
	}

	public Uri Id
	{
		get
		{
			return m_id;
		}
		set
		{
			m_id = value;
		}
	}

	public DateTime IssuedOn
	{
		get
		{
			return m_issuedOn;
		}
		set
		{
			m_issuedOn = value;
		}
	}

	public string IssuerName
	{
		get
		{
			return m_issuerName;
		}
		set
		{
			m_issuerName = value;
		}
	}

	public byte[] IssuerIdentifierAsBytes
	{
		get
		{
			return m_issuerIdentifierAsBytes;
		}
		set
		{
			m_issuerIdentifierAsBytes = value;
		}
	}

	public Uri Issuer
	{
		set
		{
			m_issuer = value;
		}
	}

	public string Language
	{
		get
		{
			return m_language;
		}
		set
		{
			m_language = value;
		}
	}

	public RequireAppliesToStatus RequireAppliesto
	{
		get
		{
			return m_requireAppliesTo;
		}
		set
		{
			m_requireAppliesTo = value;
		}
	}

	public bool IsSelfIssued
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

	public string PrivacyPolicyLink
	{
		get
		{
			return m_privacyPolicyLink;
		}
		set
		{
			m_privacyPolicyLink = value;
		}
	}

	public uint PrivacyPolicyVersion => m_privacyPolicyVersion;

	public StoreConnection Connection
	{
		set
		{
			m_storeConnection = value;
		}
	}

	public byte[] Logo
	{
		get
		{
			return m_logo;
		}
		set
		{
			m_logo = value;
		}
	}

	public string LogoMimeType
	{
		get
		{
			return m_mimeType;
		}
		set
		{
			m_mimeType = value;
		}
	}

	public string Name
	{
		get
		{
			return m_name;
		}
		set
		{
			m_name = value;
		}
	}

	public DateTime LastUpdate
	{
		get
		{
			return m_lastUpdate;
		}
		set
		{
			m_lastUpdate = value;
		}
	}

	public int BackgroundColor
	{
		get
		{
			return m_backgroundColor;
		}
		set
		{
			m_backgroundColor = value;
		}
	}

	public byte[] HashSalt
	{
		get
		{
			return m_salt;
		}
		set
		{
			m_salt = value;
		}
	}

	public string[] SupportedClaimTypes
	{
		get
		{
			List<string> list = new List<string>();
			foreach (string key in GetClaims().Keys)
			{
				if (!IsSelfIssued || !string.IsNullOrEmpty(GetClaims()[key].Value))
				{
					list.Add(key);
				}
			}
			return list.ToArray();
		}
	}

	public bool IsImported
	{
		set
		{
			m_isImported = value;
		}
	}

	public DateTime InstalledOn
	{
		set
		{
			m_installedOn = value;
		}
	}

	public bool IsPinProtected
	{
		get
		{
			if (m_pinHash != null)
			{
				return m_pinHash.Length > 0;
			}
			return false;
		}
	}

	public string Pin => m_pin;

	public byte[] Key
	{
		get
		{
			if (m_masterKey != null)
			{
				return m_masterKey.Key;
			}
			return null;
		}
	}

	public InfoCard()
	{
		m_lastUpdate = DateTime.UtcNow;
	}

	public InfoCard(Uri id)
	{
		m_id = id;
	}

	public InfoCard(Stream stream)
	{
		Deserialize(stream);
	}

	public InfoCardClaimCollection GetClaims()
	{
		if (m_claims == null)
		{
			if (null == m_id)
			{
				InfoCardTrace.Assert(null != m_id, "m_id", new object[0]);
			}
			m_claims = new InfoCardClaimCollection(m_id);
			if (m_storeConnection != null)
			{
				m_claims.Get(m_storeConnection);
			}
		}
		return m_claims;
	}

	public static IssuerInformation GetIssuerInformation(string xml)
	{
		IssuerInformation issuerInformation = new IssuerInformation();
		if (!string.IsNullOrEmpty(xml))
		{
			try
			{
				issuerInformation.ReadIssuerInformation(InfoCardSchemas.CreateReader(xml));
				return issuerInformation;
			}
			catch (Exception ex)
			{
				if (InfoCardTrace.IsFatal(ex))
				{
					throw;
				}
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new InvalidCardException(SR.GetString("ServiceUnableToDeserializeInfoCardStream"), ex));
			}
		}
		return issuerInformation;
	}

	public InfocardExtendedInformationCollection GetExtendedInformation()
	{
		if (m_extendedInformation == null)
		{
			InfoCardTrace.Assert(null != m_id, "m_id", new object[0]);
			m_extendedInformation = new InfocardExtendedInformationCollection(m_id);
			if (m_storeConnection != null)
			{
				m_extendedInformation.Get(m_storeConnection);
			}
		}
		return m_extendedInformation;
	}

	public RPIdentityRequirement GetRPIdentityRequirement()
	{
		if (m_rpStrongIdentityRequired == null)
		{
			m_rpStrongIdentityRequired = new RPIdentityRequirement(m_id, RPIdentityRequirement: false);
			if (m_storeConnection != null)
			{
				m_rpStrongIdentityRequired.Get(m_storeConnection);
			}
		}
		return m_rpStrongIdentityRequired;
	}

	public void AddClaim(InfoCardClaim claim)
	{
		InfoCardTrace.Assert(null != claim, "null claim", new object[0]);
		GetClaims().Add(claim);
	}

	public void AddLedgerEntry(LedgerEntry entry)
	{
		InfoCardTrace.Assert(null != entry, "null ledger entry", new object[0]);
		GetLedger().Add(entry);
	}

	public LedgerEntryCollection GetLedger()
	{
		if (m_ledger == null)
		{
			InfoCardTrace.Assert(null != m_id, "m_id is null", new object[0]);
			m_ledger = new LedgerEntryCollection(m_id);
			if (m_storeConnection != null)
			{
				m_ledger.Get(m_storeConnection);
			}
		}
		return m_ledger;
	}

	public LedgerEntry TryGetLedgerEntry(StoreConnection connection, string recipientIdentifier)
	{
		LedgerEntry ledgerEntry = null;
		InfoCardTrace.Assert(null != connection, "The store connection cannot be null.", new object[0]);
		InfoCardTrace.Assert(!string.IsNullOrEmpty(recipientIdentifier), "A recipient identifier must be specified.", new object[0]);
		if (m_ledger != null && m_ledger.ContainsKey(recipientIdentifier))
		{
			ledgerEntry = m_ledger[recipientIdentifier];
		}
		if (ledgerEntry == null)
		{
			DataRow singleRow = connection.GetSingleRow(new QueryParameter("ix_objecttype", -1), new QueryParameter("ix_parentid", GlobalId.DeriveFrom(m_id.ToString())), new QueryParameter("ix_name", recipientIdentifier));
			if (singleRow != null)
			{
				ledgerEntry = new LedgerEntry(new MemoryStream(singleRow.GetDataField()), connection);
			}
		}
		return ledgerEntry;
	}

	public LedgerEntry CreateLedgerEntry(Recipient recipient, string immediateTokenRecipientOrganizationIdentifier)
	{
		InfoCardTrace.Assert(null != recipient, "A recipient must be specified.", new object[0]);
		if (m_ledger == null)
		{
			InfoCardTrace.Assert(null != m_id, "The card identifier must be defined.", new object[0]);
			m_ledger = new LedgerEntryCollection(Id);
		}
		LedgerEntry ledgerEntry = LedgerEntry.NewLedgerEntry(Id, recipient, Key, immediateTokenRecipientOrganizationIdentifier);
		m_ledger.Add(ledgerEntry);
		return ledgerEntry;
	}

	public void CheckAndUpdateLedgerEntry(LedgerEntry entry, string immediateTokenRecipientOrgId)
	{
		if (entry.CheckAndUpdateSubjectKey(immediateTokenRecipientOrgId, Key))
		{
			if (m_ledger == null)
			{
				InfoCardTrace.Assert(null != Id, "The card identifier must be defined.", new object[0]);
				m_ledger = new LedgerEntryCollection(Id);
			}
			if (m_ledger.ContainsKey(entry.Recipient.RecipientId))
			{
				m_ledger[entry.Recipient.RecipientId] = entry;
			}
			else
			{
				m_ledger.Add(entry);
			}
		}
	}

	public InfoCardMasterKey GetMasterKey(StoreConnection connection)
	{
		InfoCardTrace.Assert(null != connection, "Store connection should not be null", new object[0]);
		m_masterKey = new InfoCardMasterKey(m_id);
		m_masterKey.Get(connection);
		return m_masterKey;
	}

	public void Decrypt()
	{
		InfoCardTrace.Assert(null != m_masterKey, "The GetMasterKey must be called before using this method.", new object[0]);
		PinProtectionHelper pinHelper = m_masterKey.GetPinHelper(m_pin);
		m_masterKey.Decrypt(pinHelper);
		GetClaims().Decrypt(pinHelper);
	}

	public void ClearSensitiveData()
	{
		if (m_masterKey != null)
		{
			Array.Clear(m_masterKey.Key, 0, m_masterKey.Key.Length);
		}
	}

	public static byte[] GenerateSalt()
	{
		byte[] array = new byte[16];
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		rNGCryptoServiceProvider.GetBytes(array);
		return array;
	}

	public void ThrowIfNotComplete()
	{
		if (!IsComplete())
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new SerializationIncompleteException(GetType()));
		}
	}

	public bool IsComplete()
	{
		bool flag = !string.IsNullOrEmpty(m_language) && null != m_id && null != m_issuer && !Utility.ArrayIsNullOrEmpty(m_tokenTypes) && m_privacyPolicyLink != null && !Utility.ArrayIsNullOrEmpty(m_salt) && m_epoch != 0 && DateTime.MinValue != m_issuedOn && DateTime.MinValue != m_expiresOn && DateTime.MinValue != m_lastUpdate;
		if (!IsSelfIssued)
		{
			flag = flag && CreationParameters.Count > 0 && null != m_issuerIdentifierAsBytes;
		}
		return flag;
	}

	private RSACryptoServiceProvider GetPrivateKeyPairRsaProvider(string recipientIdentifier)
	{
		LedgerEntry ledgerEntry = TryGetLedgerEntry(m_storeConnection, recipientIdentifier);
		InfoCardTrace.Assert(null != ledgerEntry, "null ledger", new object[0]);
		RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(2048);
		rSACryptoServiceProvider.ImportCspBlob(ledgerEntry.SubjectKey);
		return rSACryptoServiceProvider;
	}

	public RSACryptoServiceProvider GetPrivateCryptography(string recipientIdentifier)
	{
		return GetPrivateKeyPairRsaProvider(recipientIdentifier);
	}

	public RSACryptoServiceProvider GetPublicCryptography(string recipientIdentifier)
	{
		RSACryptoServiceProvider privateKeyPairRsaProvider = GetPrivateKeyPairRsaProvider(recipientIdentifier);
		privateKeyPairRsaProvider.ImportCspBlob(privateKeyPairRsaProvider.ExportCspBlob(includePrivateParameters: false));
		InfoCardTrace.Assert(privateKeyPairRsaProvider.PublicOnly, "GetPublicCryptography returns a public only rsa", new object[0]);
		return privateKeyPairRsaProvider;
	}

	private void Serialize(Stream stream)
	{
		ThrowIfNotComplete();
		BinaryWriter binaryWriter = new BinaryWriter(stream, Encoding.Unicode);
		binaryWriter.Write((byte)1);
		binaryWriter.Write(m_expiresOn.ToFileTimeUtc());
		binaryWriter.Write(m_epoch);
		Utility.SerializeUri(binaryWriter, m_id);
		binaryWriter.Write(m_issuedOn.ToFileTimeUtc());
		binaryWriter.Write(m_isImported);
		binaryWriter.Write(m_installedOn.ToFileTimeUtc());
		binaryWriter.Write(m_isSelfIssued);
		Utility.SerializeUri(binaryWriter, m_issuer);
		Utility.SerializeString(binaryWriter, m_issuerName);
		Utility.SerializeBytes(binaryWriter, m_issuerIdentifierAsBytes);
		Utility.SerializeString(binaryWriter, m_language);
		Utility.SerializeBytes(binaryWriter, m_logo);
		Utility.SerializeString(binaryWriter, m_mimeType);
		Utility.SerializeString(binaryWriter, m_name);
		binaryWriter.Write(m_lastUpdate.ToFileTimeUtc());
		binaryWriter.Write(m_backgroundColor);
		binaryWriter.Write((byte)m_requireAppliesTo);
		Utility.SerializeString(binaryWriter, m_privacyPolicyLink);
		binaryWriter.Write(m_privacyPolicyVersion);
		Utility.SerializeBytes(binaryWriter, m_pinHash);
		Utility.SerializeBytes(binaryWriter, m_salt);
		binaryWriter.Write(m_tokenTypes.Length);
		for (int i = 0; i < m_tokenTypes.Length; i++)
		{
			Utility.SerializeString(binaryWriter, m_tokenTypes[i]);
		}
		binaryWriter.Write((m_creationParameters != null) ? m_creationParameters.Count : 0);
		if (m_creationParameters != null)
		{
			for (int j = 0; j < m_creationParameters.Count; j++)
			{
				m_creationParameters[j].Serialize(binaryWriter);
			}
		}
		Utility.SerializeString(binaryWriter, string.Empty);
		Utility.SerializeString(binaryWriter, string.Empty);
		binaryWriter.Write((byte)m_pinAction);
		binaryWriter.Write((byte)29);
	}

	public void AgentSerialize(Stream stream, bool initCalcAttributesForGetToken, InfoCardPolicy policy, StoreConnection storeConnection, CultureInfo userCulture)
	{
		Serialize(stream);
		m_storeConnection = storeConnection;
		GetRPIdentityRequirement().Serialize(stream);
		GetExtendedInformation().Serialize(stream);
		string issuerInformationElement = GetExtendedInformation().GetIssuerInformationElement();
		GetIssuerInformation(issuerInformationElement).Serialize(stream);
		InfoCardClaimCollection claims = GetClaims();
		if (policy != null && IsSelfIssued)
		{
			CultureInfo currentUICulture = Thread.CurrentThread.CurrentUICulture;
			try
			{
				Thread.CurrentThread.CurrentUICulture = userCulture;
				string value = Utility.CreatePpid(Convert.FromBase64String(policy.ImmediateTokenRecipient.GetOrganizationPPIDIdentifier()), m_id);
				claims.Add(new InfoCardClaim(InfoCardConstants.PPIDClaimsUri, value, InfoCardConstants.ClaimsDescription(InfoCardConstants.PPID), InfoCardConstants.ClaimDisplayTag(InfoCardConstants.PPID)));
			}
			finally
			{
				Thread.CurrentThread.CurrentUICulture = currentUICulture;
			}
		}
		claims.AgentSerialize(stream);
		BinaryWriter binaryWriter = new BinaryWriter(stream, Encoding.Unicode);
		if (initCalcAttributesForGetToken)
		{
			binaryWriter.Write(DoesCardMatchPolicySet(policy));
			binaryWriter.Write(CardMatchesPolicyRequiredIssuer(policy));
			binaryWriter.Write(HasCardBeenUsedBefore(policy.Recipient.GetIdentifier(), storeConnection));
			binaryWriter.Write(HaveRequestedClaimsChanged(policy, storeConnection));
			binaryWriter.Write(WillSendAppliesToInRst(policy));
			binaryWriter.Write(DoesCardSupportAnyOptionalClaims(policy));
			binaryWriter.Write(DoesCardMatchNonClaimPolicyRequirements(policy));
		}
		else
		{
			binaryWriter.Write(value: false);
			binaryWriter.Write(value: false);
			binaryWriter.Write(value: false);
			binaryWriter.Write(value: false);
			binaryWriter.Write(value: false);
			binaryWriter.Write(value: false);
			binaryWriter.Write(value: false);
		}
		binaryWriter.Flush();
	}

	public void CopyMetaData(InfoCard card)
	{
		m_salt = new byte[card.HashSalt.Length];
		Array.Copy(card.HashSalt, 0, m_salt, 0, card.HashSalt.Length);
		m_pinHash = new byte[card.m_pinHash.Length];
		Array.Copy(card.m_pinHash, 0, m_pinHash, 0, card.m_pinHash.Length);
	}

	private bool DoesCardSupportAnyOptionalClaims(InfoCardPolicy policy)
	{
		List<string> list = new List<string>(policy.OptionalClaims);
		foreach (string key in GetClaims().Keys)
		{
			if (list.Contains(key))
			{
				return true;
			}
		}
		return false;
	}

	private bool WillSendAppliesToInRst(InfoCardPolicy policy)
	{
		AppliesToBehaviorDecision appliesToBehaviorDecisionForPolicyMatch = AppliesToBehaviorDecisionTable.GetAppliesToBehaviorDecisionForPolicyMatch(policy, RequireAppliesto);
		if (AppliesToBehaviorDecision.SendCustomAppliesTo != appliesToBehaviorDecisionForPolicyMatch && AppliesToBehaviorDecision.SendRPAppliesTo != appliesToBehaviorDecisionForPolicyMatch)
		{
			return false;
		}
		return true;
	}

	private void Deserialize(Stream stream)
	{
		BinaryReader binaryReader = new InfoCardBinaryReader(stream, Encoding.Unicode);
		if (1 != binaryReader.ReadByte())
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new InvalidCardException("ServiceCardWrongVersion"));
		}
		m_expiresOn = DateTime.FromFileTimeUtc(binaryReader.ReadInt64());
		m_epoch = binaryReader.ReadUInt32();
		m_id = new Uri(Utility.DeserializeString(binaryReader));
		m_issuedOn = DateTime.FromFileTimeUtc(binaryReader.ReadInt64());
		m_isImported = binaryReader.ReadBoolean();
		m_installedOn = DateTime.FromFileTimeUtc(binaryReader.ReadInt64());
		m_isSelfIssued = binaryReader.ReadBoolean();
		m_issuer = Utility.DeserializeUri(binaryReader);
		m_issuerName = Utility.DeserializeString(binaryReader);
		int count = binaryReader.ReadInt32();
		m_issuerIdentifierAsBytes = binaryReader.ReadBytes(count);
		m_language = Utility.DeserializeString(binaryReader);
		int num = binaryReader.ReadInt32();
		InfoCardTrace.Assert(0 <= num && num < 1048576, "logo length out of range {0}", new object[1] { num });
		m_logo = binaryReader.ReadBytes(num);
		m_mimeType = Utility.DeserializeString(binaryReader);
		m_name = Utility.DeserializeString(binaryReader);
		m_lastUpdate = DateTime.FromFileTimeUtc(binaryReader.ReadInt64());
		m_backgroundColor = binaryReader.ReadInt32();
		m_requireAppliesTo = (RequireAppliesToStatus)binaryReader.ReadByte();
		m_privacyPolicyLink = Utility.DeserializeString(binaryReader);
		m_privacyPolicyVersion = binaryReader.ReadUInt32();
		int num2 = binaryReader.ReadInt32();
		InfoCardTrace.Assert(0 <= num2 && num2 < 1024, "pin hash out fo range {0}", new object[1] { num2 });
		m_pinHash = binaryReader.ReadBytes(num2);
		int num3 = binaryReader.ReadInt32();
		InfoCardTrace.Assert(0 <= num3 && num3 < 1024, "salt length out of range {0}", new object[1] { num3 });
		m_salt = binaryReader.ReadBytes(num3);
		int num4 = binaryReader.ReadInt32();
		InfoCardTrace.Assert(32 > num4, "too many token types", new object[0]);
		m_tokenTypes = new string[num4];
		for (int i = 0; i < num4; i++)
		{
			m_tokenTypes[i] = Utility.DeserializeString(binaryReader);
		}
		int num5 = binaryReader.ReadInt32();
		InfoCardTrace.Assert(0 <= num5 && num5 < 128, "creation parametes out of range {0}", new object[1] { num5 });
		for (int j = 0; j < num5; j++)
		{
			TokenCreationParameter tokenCreationParameter = new TokenCreationParameter();
			tokenCreationParameter.Deserialize(binaryReader);
			CreationParameters.Add(tokenCreationParameter);
		}
		m_pin = Utility.DeserializeString(binaryReader);
		m_oldPin = Utility.DeserializeString(binaryReader);
		m_pinAction = (PinAction)binaryReader.ReadByte();
		if (29 != binaryReader.ReadByte())
		{
			InfoCardTrace.Assert(false, "malformed stream detected", new object[0]);
		}
		ThrowIfNotComplete();
	}

	public Dictionary<string, bool> GetClaimsToBeDisclosed(InfoCardPolicy policy, bool discloseOptional)
	{
		Dictionary<string, bool> dictionary = new Dictionary<string, bool>(policy.RequiredClaims.Length);
		for (int i = 0; i < policy.RequiredClaims.Length; i++)
		{
			dictionary.Add(policy.RequiredClaims[i], value: false);
		}
		if (discloseOptional)
		{
			for (int j = 0; j < policy.OptionalClaims.Length; j++)
			{
				string key = policy.OptionalClaims[j];
				if (GetClaims().ContainsKey(key))
				{
					dictionary.Add(policy.OptionalClaims[j], value: true);
				}
			}
		}
		return dictionary;
	}

	public bool DoesCardMatchPolicySet(InfoCardPolicy policy)
	{
		InfoCardTrace.Assert(null != policy, "null policy", new object[0]);
		bool flag = true;
		List<string> list = new List<string>(SupportedClaimTypes);
		if (policy.RequiredClaims != null)
		{
			string[] requiredClaims = policy.RequiredClaims;
			foreach (string text in requiredClaims)
			{
				if (!list.Contains(text) && (!IsSelfIssued || !(InfoCardConstants.PPIDClaimsUri == text)))
				{
					flag = false;
					break;
				}
			}
		}
		if (flag)
		{
			return DoesCardMatchNonClaimPolicyRequirements(policy);
		}
		return false;
	}

	public bool DoesCardMatchNonClaimPolicyRequirements(InfoCardPolicy policy)
	{
		InfoCardTrace.Assert(null != policy, "null policy", new object[0]);
		bool flag = true;
		if (!IsSelfIssued && AppliesToBehaviorDecision.FailMatch == AppliesToBehaviorDecisionTable.GetAppliesToBehaviorDecisionForPolicyMatch(policy, RequireAppliesto))
		{
			flag = false;
		}
		bool result = true;
		if (GetRPIdentityRequirement().StrongIdentityRequired && !(policy.ImmediateTokenRecipient is X509RecipientIdentity))
		{
			result = false;
		}
		if ((!IsSelfIssued || !policy.RequiresManagedCard) && CardMatchesPolicyTokenType(policy) && CardMatchesPolicyRequiredIssuer(policy) && flag)
		{
			return result;
		}
		return false;
	}

	public bool HaveRequestedClaimsChanged(InfoCardPolicy policy, StoreConnection connection)
	{
		InfoCardTrace.Assert(null != m_id, "Null id", new object[0]);
		InfoCardTrace.Assert(null != policy, "null policy", new object[0]);
		InfoCardTrace.Assert(null != connection, "null connection", new object[0]);
		LedgerEntry ledgerEntry = TryGetLedgerEntry(connection, policy.Recipient.GetIdentifier());
		if (ledgerEntry == null)
		{
			return true;
		}
		IList list = ledgerEntry.DisclosedClaims ?? new string[0];
		int num = 0;
		if (policy.RequiredClaims != null)
		{
			num = policy.RequiredClaims.Length;
		}
		if (num > list.Count)
		{
			return true;
		}
		bool flag = true;
		string[] requiredClaims = policy.RequiredClaims;
		foreach (string value in requiredClaims)
		{
			if (!list.Contains(value))
			{
				flag = false;
				break;
			}
		}
		return !flag;
	}

	private bool CardMatchesPolicyTokenType(InfoCardPolicy policy)
	{
		if (string.IsNullOrEmpty(policy.OptionalRstParams.TokenType))
		{
			return true;
		}
		string[] tokenTypes = m_tokenTypes;
		int num = 0;
		while (true)
		{
			if (num < tokenTypes.Length)
			{
				string text = tokenTypes[num];
				if (text == policy.OptionalRstParams.TokenType)
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	private bool CardMatchesPolicyRequiredIssuer(InfoCardPolicy policy)
	{
		if (!((EndpointAddress)null == policy.Issuer) && !(null == policy.Issuer.get_Uri()) && !Utility.CompareUri(policy.Issuer.get_Uri(), XmlNames.WSIdentity.AnonymousIssuerUriValue))
		{
			if (m_isSelfIssued && Utility.CompareUri(policy.Issuer.get_Uri(), XmlNames.WSIdentity.SelfIssuerUriValue))
			{
				return true;
			}
			if (!m_isSelfIssued && Utility.CompareUri(policy.Issuer.get_Uri(), m_issuer))
			{
				return true;
			}
			return false;
		}
		return true;
	}

	public bool HasCardBeenUsedBefore(string recipientId, StoreConnection connection)
	{
		return null != connection.GetSingleRow(QueryDetails.Identifiers, new QueryParameter("ix_objecttype", -1), new QueryParameter("ix_name", recipientId), new QueryParameter("ix_parentid", GlobalId.DeriveFrom(m_id.ToString())));
	}

	public void Get(StoreConnection con)
	{
		InfoCardTrace.Assert(null != m_id, "null id", new object[0]);
		InfoCardTrace.Assert(null != con, "null connection", new object[0]);
		m_storeConnection = con;
		DataRow row = GetRow(con, QueryDetails.FullRow);
		Deserialize(new MemoryStream(row.GetDataField()));
		m_rowId = row.LocalId;
	}

	public void Save(StoreConnection con)
	{
		ThrowIfNotComplete();
		InfoCardTrace.Assert(null != con, "null connection", new object[0]);
		DataRow dataRow = TryGetRow(con, QueryDetails.FullHeader);
		bool flag = false;
		if (dataRow == null)
		{
			if (m_masterKey == null)
			{
				m_masterKey = InfoCardMasterKey.NewMasterKey(m_id);
			}
			flag = true;
			dataRow = new DataRow();
			dataRow.ObjectType = 1;
			dataRow.GlobalId = GlobalId.DeriveFrom(m_id.ToString());
		}
		InfoCardClaimCollection infoCardClaimCollection = null;
		switch (m_pinAction)
		{
		case PinAction.PinSame:
			infoCardClaimCollection = m_claims.Clone();
			GetMasterKey(con);
			m_claims.Encrypt(m_masterKey.GetPinHelper(m_pin));
			break;
		case PinAction.PinAdded:
		{
			infoCardClaimCollection = m_claims.Clone();
			GetMasterKey(con);
			PinProtectionHelper pinHelper2 = new PinProtectionHelper(m_pin);
			m_masterKey.Encrypt(pinHelper2);
			m_claims.Encrypt(pinHelper2);
			flag = true;
			break;
		}
		case PinAction.PinRemoved:
			GetMasterKey(con);
			m_masterKey.Decrypt(m_masterKey.GetPinHelper(m_oldPin));
			flag = true;
			break;
		case PinAction.PinChanged:
		{
			infoCardClaimCollection = m_claims.Clone();
			GetMasterKey(con);
			m_masterKey.Decrypt(m_masterKey.GetPinHelper(m_oldPin));
			PinProtectionHelper pinHelper = new PinProtectionHelper(m_pin);
			m_masterKey.Encrypt(pinHelper);
			m_claims.Encrypt(pinHelper);
			flag = true;
			break;
		}
		}
		if (flag)
		{
			m_masterKey.Save(con);
		}
		m_pinAction = (IsPinProtected ? PinAction.PinSame : PinAction.NoPin);
		string[] array;
		if (IsSelfIssued)
		{
			array = new string[1] { "http://schemas.xmlsoap.org/ws/2005/05/identity/issuer/self" };
		}
		else
		{
			array = new string[CreationParameters.Count];
			int num = 0;
			foreach (TokenCreationParameter creationParameter in CreationParameters)
			{
				array[num++] = creationParameter.Epr.get_Uri().ToString();
			}
		}
		dataRow.SetIndexValue("ix_production_svc_uri", array);
		InfoCardTrace.Assert(null != m_claims, "Must already be initialized at this point", new object[0]);
		dataRow.SetIndexValue("ix_supportclaim", SupportedClaimTypes);
		if (CreationParameters.Count > 0)
		{
			object[] array2 = new object[CreationParameters.Count];
			int num2 = 0;
			foreach (TokenCreationParameter creationParameter2 in CreationParameters)
			{
				array2[num2++] = (int)creationParameter2.CredentialType;
			}
			dataRow.SetIndexValue("ix_supportauth", array2);
		}
		MemoryStream memoryStream = new MemoryStream();
		Serialize(memoryStream);
		dataRow.SetDataField(memoryStream.ToArray());
		con.Save(dataRow);
		m_rowId = dataRow.LocalId;
		if (m_extendedInformation != null)
		{
			m_extendedInformation.Save(con);
		}
		m_claims.Save(con, m_isSelfIssued);
		if (infoCardClaimCollection != null)
		{
			m_claims = infoCardClaimCollection;
		}
		GetRPIdentityRequirement().Save(con);
	}

	public override string ToString()
	{
		return base.ToString();
	}

	public static InfoCard NewCard(CultureInfo userCulture)
	{
		InfoCard infoCard = new InfoCard();
		infoCard.m_expiresOn = DateTime.MaxValue;
		infoCard.m_epoch = 1u;
		infoCard.m_id = new Uri("urn:uuid:" + Guid.NewGuid());
		infoCard.m_issuedOn = DateTime.UtcNow;
		infoCard.m_isImported = false;
		infoCard.m_installedOn = DateTime.UtcNow;
		infoCard.m_isSelfIssued = true;
		infoCard.m_issuerName = SR.GetString("SelfIssuedIssuerName");
		infoCard.m_issuer = XmlNames.WSIdentity.SelfIssuerUriValue;
		infoCard.m_language = userCulture.TwoLetterISOLanguageName;
		infoCard.m_logo = new byte[0];
		infoCard.m_name = null;
		infoCard.m_lastUpdate = DateTime.UtcNow;
		infoCard.m_backgroundColor = 16777215;
		infoCard.m_requireAppliesTo = RequireAppliesToStatus.NotPresent;
		infoCard.m_salt = GenerateSalt();
		infoCard.m_tokenTypes = new string[2] { "urn:oasis:names:tc:SAML:1.0:assertion", "http://docs.oasis-open.org/wss/oasis-wss-saml-token-profile-1.1#SAMLV1.1" };
		CultureInfo currentUICulture = Thread.CurrentThread.CurrentUICulture;
		try
		{
			Thread.CurrentThread.CurrentUICulture = userCulture;
			for (int i = 0; i < InfoCardConstants.SelfIssuedClaimsUris.Length; i++)
			{
				InfoCardClaim claim = new InfoCardClaim(InfoCardConstants.SelfIssuedClaimsUris[i], null, InfoCardConstants.ClaimsDescription(InfoCardConstants.SelfIssuedClaimsUris[i]), InfoCardConstants.ClaimDisplayTag(InfoCardConstants.SelfIssuedClaimsUris[i]));
				infoCard.AddClaim(claim);
			}
		}
		finally
		{
			Thread.CurrentThread.CurrentUICulture = currentUICulture;
		}
		InfoCardTrace.Assert(null == infoCard.m_masterKey, "Card key is only populated during save", new object[0]);
		return infoCard;
	}

	protected DataRow GetRow(StoreConnection con, QueryDetails details)
	{
		InfoCardTrace.Assert(null != con, " null connection", new object[0]);
		DataRow dataRow = TryGetRow(con, details);
		InfoCardTrace.Assert(null != dataRow, "null row", new object[0]);
		InfoCardTrace.Assert(1 == dataRow.ObjectType, "Attempt to deserialize an incorrect object type {0}", new object[1] { dataRow.ObjectType });
		return dataRow;
	}

	protected DataRow TryGetRow(StoreConnection con, QueryDetails details)
	{
		InfoCardTrace.Assert(null != m_id, "null id", new object[0]);
		InfoCardTrace.Assert(null != con, "null connection", new object[0]);
		return con.GetSingleRow(details, new QueryParameter("ix_globalid", GlobalId.DeriveFrom(m_id.ToString())));
	}

	public void ReadXml(XmlReader reader)
	{
		if ("RoamingInformationCard" == reader.LocalName)
		{
			ReadRoamingInfoCard(reader);
			return;
		}
		if ("InformationCard" == reader.LocalName)
		{
			ReadImportedInfoCard(reader);
			return;
		}
		InfoCardTrace.Assert(false, "Invalid element found. Did schema validation fail? Found {0}", new object[1] { reader.LocalName });
	}

	public XmlSchema GetSchema()
	{
		return null;
	}

	public void WriteXml(XmlWriter writer)
	{
		ThrowIfNotComplete();
		writer.WriteStartElement("RoamingInformationCard", "http://schemas.xmlsoap.org/ws/2005/05/identity");
		writer.WriteStartElement("InformationCardMetaData", "http://schemas.xmlsoap.org/ws/2005/05/identity");
		writer.WriteAttributeString("lang", "http://www.w3.org/XML/1998/namespace", m_language);
		writer.WriteStartElement("InformationCardReference", "http://schemas.xmlsoap.org/ws/2005/05/identity");
		writer.WriteStartElement("CardId", "http://schemas.xmlsoap.org/ws/2005/05/identity");
		writer.WriteString(m_id.AbsoluteUri);
		writer.WriteEndElement();
		writer.WriteStartElement("CardVersion", "http://schemas.xmlsoap.org/ws/2005/05/identity");
		writer.WriteString(m_epoch.ToString(CultureInfo.InvariantCulture));
		writer.WriteEndElement();
		writer.WriteEndElement();
		if (!string.IsNullOrEmpty(m_name))
		{
			writer.WriteStartElement("CardName", "http://schemas.xmlsoap.org/ws/2005/05/identity");
			writer.WriteString(m_name);
			writer.WriteEndElement();
		}
		if (m_logo != null && m_logo.Length != 0)
		{
			writer.WriteStartElement("CardImage", "http://schemas.xmlsoap.org/ws/2005/05/identity");
			if (!string.IsNullOrEmpty(m_mimeType))
			{
				writer.WriteAttributeString("MimeType", m_mimeType);
			}
			string text = Convert.ToBase64String(m_logo);
			writer.WriteString(text);
			writer.WriteEndElement();
		}
		writer.WriteStartElement("Issuer", "http://schemas.xmlsoap.org/ws/2005/05/identity");
		if (null != m_issuer)
		{
			writer.WriteString(m_issuer.AbsoluteUri);
		}
		writer.WriteEndElement();
		writer.WriteStartElement("TimeIssued", "http://schemas.xmlsoap.org/ws/2005/05/identity");
		writer.WriteString(XmlConvert.ToString(m_issuedOn, XmlDateTimeSerializationMode.Utc));
		writer.WriteEndElement();
		writer.WriteStartElement("TimeExpires", "http://schemas.xmlsoap.org/ws/2005/05/identity");
		writer.WriteString(XmlConvert.ToString(m_expiresOn, XmlDateTimeSerializationMode.Utc));
		writer.WriteEndElement();
		if (m_creationParameters != null)
		{
			writer.WriteStartElement("TokenServiceList", "http://schemas.xmlsoap.org/ws/2005/05/identity");
			foreach (TokenCreationParameter creationParameter in m_creationParameters)
			{
				creationParameter.WriteXml(writer);
			}
			writer.WriteEndElement();
		}
		writer.WriteStartElement("SupportedTokenTypeList", "http://schemas.xmlsoap.org/ws/2005/05/identity");
		string[] tokenTypes = m_tokenTypes;
		foreach (string value in tokenTypes)
		{
			writer.WriteElementString("TokenType", "http://schemas.xmlsoap.org/ws/2005/02/trust", value);
		}
		writer.WriteEndElement();
		writer.WriteStartElement("SupportedClaimTypeList", "http://schemas.xmlsoap.org/ws/2005/05/identity");
		foreach (string key in GetClaims().Keys)
		{
			InfoCardClaim infoCardClaim = GetClaims()[key];
			if (!m_isSelfIssued || !Utility.CompareUri(infoCardClaim.Id, InfoCardConstants.PPIDClaimsUri))
			{
				writer.WriteStartElement("SupportedClaimType", "http://schemas.xmlsoap.org/ws/2005/05/identity");
				writer.WriteAttributeString("Uri", infoCardClaim.Id);
				if (!string.IsNullOrEmpty(infoCardClaim.DisplayTag))
				{
					writer.WriteElementString("DisplayTag", "http://schemas.xmlsoap.org/ws/2005/05/identity", infoCardClaim.DisplayTag);
				}
				if (!string.IsNullOrEmpty(infoCardClaim.Description))
				{
					writer.WriteElementString("Description", "http://schemas.xmlsoap.org/ws/2005/05/identity", infoCardClaim.Description);
				}
				writer.WriteEndElement();
			}
		}
		writer.WriteEndElement();
		if (m_requireAppliesTo != 0)
		{
			writer.WriteStartElement("RequireAppliesTo", "http://schemas.xmlsoap.org/ws/2005/05/identity");
			if (RequireAppliesToStatus.Optional == m_requireAppliesTo)
			{
				writer.WriteAttributeString("Optional", "true");
			}
			writer.WriteEndElement();
		}
		if (!string.IsNullOrEmpty(m_privacyPolicyLink))
		{
			writer.WriteStartElement("PrivacyNotice", "http://schemas.xmlsoap.org/ws/2005/05/identity");
			if (0 < m_privacyPolicyVersion)
			{
				writer.WriteAttributeString("Version", m_privacyPolicyVersion.ToString(CultureInfo.InvariantCulture));
			}
			writer.WriteString(m_privacyPolicyLink);
			writer.WriteEndElement();
		}
		if (GetRPIdentityRequirement().StrongIdentityRequired)
		{
			writer.WriteStartElement("RequireStrongRecipientIdentity", "http://schemas.xmlsoap.org/ws/2007/01/identity");
			writer.WriteEndElement();
		}
		if (GetExtendedInformation() != null)
		{
			foreach (InfocardExtendedInformationEntry item in m_extendedInformation)
			{
				item.WriteXml(writer);
			}
		}
		writer.WriteStartElement("IsSelfIssued", "http://schemas.xmlsoap.org/ws/2005/05/identity");
		writer.WriteString(XmlConvert.ToString(m_isSelfIssued));
		writer.WriteEndElement();
		if (!Utility.ArrayIsNullOrEmpty(m_pinHash))
		{
			writer.WriteStartElement("PinDigest", "http://schemas.xmlsoap.org/ws/2005/05/identity");
			writer.WriteString(Convert.ToBase64String(m_pinHash));
			writer.WriteEndElement();
		}
		writer.WriteStartElement("HashSalt", "http://schemas.xmlsoap.org/ws/2005/05/identity");
		writer.WriteString(Convert.ToBase64String(m_salt));
		writer.WriteEndElement();
		writer.WriteStartElement("TimeLastUpdated", "http://schemas.xmlsoap.org/ws/2005/05/identity");
		writer.WriteString(XmlConvert.ToString(m_lastUpdate, XmlDateTimeSerializationMode.Utc));
		writer.WriteEndElement();
		writer.WriteStartElement("IssuerId", "http://schemas.xmlsoap.org/ws/2005/05/identity");
		if (m_issuerIdentifierAsBytes != null)
		{
			writer.WriteString(Convert.ToBase64String(m_issuerIdentifierAsBytes, Base64FormattingOptions.None));
		}
		writer.WriteEndElement();
		writer.WriteStartElement("IssuerName", "http://schemas.xmlsoap.org/ws/2005/05/identity");
		if (!string.IsNullOrEmpty(m_issuerName))
		{
			writer.WriteString(m_issuerName);
		}
		writer.WriteEndElement();
		writer.WriteStartElement("BackgroundColor", "http://schemas.xmlsoap.org/ws/2005/05/identity");
		writer.WriteString(XmlConvert.ToString(m_backgroundColor));
		writer.WriteEndElement();
		writer.WriteEndElement();
		writer.WriteStartElement("InformationCardPrivateData", "http://schemas.xmlsoap.org/ws/2005/05/identity");
		InfoCardTrace.Assert(null != m_masterKey, "Masterkey Cannot be null when trying to export a card", new object[0]);
		writer.WriteStartElement("MasterKey", "http://schemas.xmlsoap.org/ws/2005/05/identity");
		writer.WriteString(Convert.ToBase64String(m_masterKey.Key));
		writer.WriteEndElement();
		if (IsSelfIssued)
		{
			writer.WriteStartElement("ClaimValueList", "http://schemas.xmlsoap.org/ws/2005/05/identity");
			foreach (string key2 in GetClaims().Keys)
			{
				InfoCardClaim infoCardClaim2 = GetClaims()[key2];
				if (!Utility.CompareUri(infoCardClaim2.Id, InfoCardConstants.PPIDClaimsUri))
				{
					writer.WriteStartElement("ClaimValue", "http://schemas.xmlsoap.org/ws/2005/05/identity");
					writer.WriteAttributeString("Uri", infoCardClaim2.Id);
					if (!string.IsNullOrEmpty(infoCardClaim2.Value))
					{
						writer.WriteElementString("Value", "http://schemas.xmlsoap.org/ws/2005/05/identity", infoCardClaim2.Value);
					}
					else
					{
						writer.WriteElementString("Value", "http://schemas.xmlsoap.org/ws/2005/05/identity", string.Empty);
					}
					writer.WriteEndElement();
				}
			}
			writer.WriteEndElement();
		}
		writer.WriteEndElement();
		writer.WriteEndElement();
	}

	private void ReadImportedInfoCard(XmlReader reader)
	{
		InfoCardTrace.Assert(null != reader, "null reader", new object[0]);
		if (!reader.IsStartElement("InformationCard", "http://schemas.xmlsoap.org/ws/2005/05/identity"))
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new InvalidCardException(SR.GetString("UnexpectedElement")));
		}
		Language = reader.GetAttribute("lang", "http://www.w3.org/XML/1998/namespace");
		if (string.IsNullOrEmpty(Language))
		{
			Language = reader.GetAttribute("lang");
		}
		reader.ReadStartElement();
		ReadBaseInfoCard(reader);
		if (!IsSelfIssued && Utility.CompareUri(m_issuer, XmlNames.WSIdentity.SelfIssuerUriValue))
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new InvalidCardException(SR.GetString("SelfIssuedUriUsed")));
		}
		if (m_extendedInformation == null)
		{
			m_extendedInformation = new InfocardExtendedInformationCollection(m_id);
		}
	}

	private void ReadRoamingInfoCard(XmlReader reader)
	{
		InfoCardTrace.Assert(null != reader, "null reader", new object[0]);
		if (!reader.IsStartElement("RoamingInformationCard", "http://schemas.xmlsoap.org/ws/2005/05/identity"))
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new InvalidCardException(SR.GetString("UnexpectedElement")));
		}
		reader.ReadStartElement();
		Language = reader.GetAttribute("lang", "http://www.w3.org/XML/1998/namespace");
		if (string.IsNullOrEmpty(Language))
		{
			Language = reader.GetAttribute("lang");
		}
		ReadBaseInfoCard(reader);
		if (m_isSelfIssued)
		{
			InfoCardClaimCollection claims = GetClaims();
			if (claims.ContainsKey(InfoCardConstants.PPIDClaimsUri))
			{
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new InvalidCardException(SR.GetString("InvalidImportFile")));
			}
		}
		ReadInfoCardPrivateData(reader);
	}

	private void ReadInfoCardPrivateData(XmlReader reader)
	{
		while (reader.Read())
		{
			switch (reader.LocalName)
			{
			case "ClaimValueList":
				ReadClaimValues(reader);
				break;
			case "MasterKey":
			{
				byte[] array = Utility.ReadByteStreamFromBase64(reader).ToArray();
				if (IsPinProtected)
				{
					if (array == null || PinProtectionHelper.EncryptedMasterKeySize != array.Length)
					{
						throw InfoCardTrace.ThrowHelperError((Exception)(object)new InvalidCardException(SR.GetString("InvalidImportFile")));
					}
					m_masterKey = new InfoCardMasterKey(m_id, array);
				}
				else
				{
					if (array == null || 32 != array.Length)
					{
						throw InfoCardTrace.ThrowHelperError((Exception)(object)new InvalidCardException(SR.GetString("InvalidImportFile")));
					}
					m_masterKey = new InfoCardMasterKey(m_id, array);
				}
				break;
			}
			case "RoamingInformationCard":
				if (XmlNodeType.EndElement == reader.NodeType)
				{
					return;
				}
				break;
			}
		}
	}

	private void ReadBaseInfoCard(XmlReader reader)
	{
		try
		{
			while (true)
			{
				if (!reader.Read())
				{
					return;
				}
				if ("http://schemas.xmlsoap.org/ws/2005/05/identity" == reader.NamespaceURI && XmlNodeType.EndElement == reader.NodeType && ("InformationCard" == reader.LocalName || "InformationCardMetaData" == reader.LocalName))
				{
					break;
				}
				if ("http://schemas.xmlsoap.org/ws/2005/05/identity" != reader.NamespaceURI && XmlNodeType.Element == reader.NodeType)
				{
					if ("http://schemas.xmlsoap.org/ws/2007/01/identity" == reader.NamespaceURI && "IssuerInformation" == reader.LocalName)
					{
						if (!m_readIssuerInformation)
						{
							InfocardExtendedInformationEntry infocardExtendedInformationEntry = new InfocardExtendedInformationEntry();
							infocardExtendedInformationEntry.ReadXml(reader);
							if (m_extendedInformation == null)
							{
								m_extendedInformation = new InfocardExtendedInformationCollection(m_id);
							}
							m_extendedInformation.Add(infocardExtendedInformationEntry);
							m_readIssuerInformation = true;
							continue;
						}
						throw InfoCardTrace.ThrowHelperError((Exception)(object)new InvalidCardException(SR.GetString("MultipleIssuerInformation")));
					}
					InfocardExtendedInformationEntry infocardExtendedInformationEntry2 = new InfocardExtendedInformationEntry();
					infocardExtendedInformationEntry2.ReadXml(reader);
				}
				if ("http://schemas.xmlsoap.org/ws/2005/05/identity" == reader.NamespaceURI && XmlNodeType.EndElement != reader.NodeType)
				{
					switch (reader.LocalName)
					{
					case "CardId":
						Id = new Uri(reader.ReadString().Trim());
						break;
					case "CardVersion":
						Epoch = Convert.ToUInt32(reader.ReadString().Trim(), CultureInfo.InvariantCulture);
						break;
					case "CardImage":
						LogoMimeType = reader.GetAttribute("MimeType", "http://schemas.xmlsoap.org/ws/2005/05/identity");
						if (string.IsNullOrEmpty(LogoMimeType))
						{
							LogoMimeType = reader.GetAttribute("MimeType");
						}
						Logo = Utility.ReadByteStreamFromBase64(reader).ToArray();
						break;
					case "CardName":
						Name = reader.ReadString().Trim();
						break;
					case "IssuerName":
						IssuerName = reader.ReadString().Trim();
						break;
					case "Issuer":
						Issuer = new Uri(reader.ReadString().Trim());
						break;
					case "TimeExpires":
						ExpiresOn = XmlConvert.ToDateTime(reader.ReadString().Trim(), XmlDateTimeSerializationMode.Utc);
						break;
					case "TimeIssued":
						IssuedOn = XmlConvert.ToDateTime(reader.ReadString().Trim(), XmlDateTimeSerializationMode.Utc);
						break;
					case "SupportedClaimTypeList":
						ReadClaims(reader);
						break;
					case "SupportedTokenTypeList":
					{
						List<string> list = ReadTokenType(reader);
						TokenTypes = list.ToArray();
						break;
					}
					case "RequireAppliesTo":
					{
						string attribute = reader.GetAttribute("Optional", "http://schemas.xmlsoap.org/ws/2005/05/identity");
						if (string.IsNullOrEmpty(attribute))
						{
							attribute = reader.GetAttribute("Optional");
						}
						if (!string.IsNullOrEmpty(attribute) && ("true" == attribute || "1" == attribute))
						{
							RequireAppliesto = RequireAppliesToStatus.Optional;
						}
						else
						{
							RequireAppliesto = RequireAppliesToStatus.Required;
						}
						break;
					}
					case "TokenServiceList":
						ReadAuthServices(reader);
						break;
					case "PrivacyNotice":
						ReadPrivacyPolicy(reader);
						break;
					case "IsSelfIssued":
						IsSelfIssued = Convert.ToBoolean(reader.ReadString().Trim(), CultureInfo.InvariantCulture);
						if (IsSelfIssued && m_readIssuerInformation)
						{
							throw InfoCardTrace.ThrowHelperError((Exception)(object)new InvalidCardException(SR.GetString("ExtendedInfoInSelfIssued")));
						}
						break;
					case "PinDigest":
					{
						byte[] array3 = Utility.ReadByteStreamFromBase64(reader).ToArray();
						if (array3 != null && array3.Length != 0)
						{
							m_pinHash = array3;
						}
						break;
					}
					case "HashSalt":
					{
						byte[] array2 = Utility.ReadByteStreamFromBase64(reader).ToArray();
						if (array2 != null && array2.Length != 0)
						{
							HashSalt = array2;
						}
						break;
					}
					case "TimeLastUpdated":
					{
						string text = reader.ReadString().Trim();
						if (!string.IsNullOrEmpty(text))
						{
							LastUpdate = XmlConvert.ToDateTime(text, XmlDateTimeSerializationMode.Utc);
						}
						break;
					}
					case "IssuerId":
					{
						byte[] array = Utility.ReadByteStreamFromBase64(reader).ToArray();
						if (array != null && array.Length != 0)
						{
							IssuerIdentifierAsBytes = array;
						}
						break;
					}
					case "BackgroundColor":
						BackgroundColor = Convert.ToInt32(reader.ReadString().Trim(), CultureInfo.InvariantCulture);
						break;
					}
				}
				else if ("http://schemas.xmlsoap.org/ws/2007/01/identity" == reader.NamespaceURI && XmlNodeType.EndElement != reader.NodeType && "RequireStrongRecipientIdentity" == reader.LocalName && "http://schemas.xmlsoap.org/ws/2007/01/identity" == reader.NamespaceURI)
				{
					GetRPIdentityRequirement().StrongIdentityRequired = true;
				}
			}
			reader.ReadEndElement();
		}
		catch (UriFormatException inner)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new InvalidCardException(SR.GetString("InvalidUriFormat"), inner));
		}
	}

	private void ReadPrivacyPolicy(XmlReader reader)
	{
		InfoCardTrace.Assert(null != reader, "null reader", new object[0]);
		if (!reader.IsStartElement("PrivacyNotice", "http://schemas.xmlsoap.org/ws/2005/05/identity"))
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new InvalidCardException(SR.GetString("UnexpectedElement")));
		}
		string attribute = reader.GetAttribute("Version", "http://www.w3.org/XML/1998/namespace");
		if (string.IsNullOrEmpty(attribute))
		{
			attribute = reader.GetAttribute("Version");
		}
		if (!string.IsNullOrEmpty(attribute))
		{
			m_privacyPolicyVersion = Convert.ToUInt32(attribute, CultureInfo.InvariantCulture);
		}
		m_privacyPolicyLink = reader.ReadString().Trim();
	}

	private void ReadClaimValues(XmlReader reader)
	{
		InfoCardTrace.Assert(null != reader, "null reader", new object[0]);
		if (!reader.IsStartElement("ClaimValueList", "http://schemas.xmlsoap.org/ws/2005/05/identity"))
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new InvalidCardException(SR.GetString("UnexpectedElement")));
		}
		while (reader.Read() && (XmlNodeType.EndElement != reader.NodeType || !("ClaimValueList" == reader.LocalName)))
		{
			if (!("http://schemas.xmlsoap.org/ws/2005/05/identity" == reader.NamespaceURI) || !("ClaimValue" == reader.LocalName) || XmlNodeType.Element != reader.NodeType)
			{
				continue;
			}
			string attribute = reader.GetAttribute("Uri", "http://www.w3.org/XML/1998/namespace");
			if (string.IsNullOrEmpty(attribute))
			{
				attribute = reader.GetAttribute("Uri");
			}
			reader.Read();
			string text = reader.ReadString().Trim();
			if (IsPinProtected || text.Length <= 255)
			{
				if (string.IsNullOrEmpty(attribute))
				{
					continue;
				}
				if (m_claims.ContainsKey(attribute))
				{
					if (!string.IsNullOrEmpty(text) && !IsPinProtected)
					{
						if (InfoCardConstants.Gender == attribute && !("0" == text) && !("1" == text) && !("2" == text))
						{
							throw InfoCardTrace.ThrowHelperError((Exception)(object)new InvalidCardException(SR.GetString("InvalidImportFile")));
						}
						if (InfoCardConstants.DateOfBirth == attribute)
						{
							try
							{
								XmlConvert.ToDateTime(text, XmlDateTimeSerializationMode.Utc);
							}
							catch (Exception ex)
							{
								if (InfoCardTrace.IsFatal(ex))
								{
									InfoCardService.Crash(ex);
								}
								throw InfoCardTrace.ThrowHelperError((Exception)(object)new InvalidCardException(SR.GetString("InvalidImportFile")));
							}
						}
					}
					m_claims[attribute].Value = text;
					continue;
				}
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new InvalidCardException(SR.GetString("InvalidImportFile")));
			}
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new InvalidCardException(SR.GetString("TooLongClaimValue")));
		}
	}

	private void ReadClaims(XmlReader reader)
	{
		InfoCardTrace.Assert(null != reader, "null reader", new object[0]);
		if (!reader.IsStartElement("SupportedClaimTypeList", "http://schemas.xmlsoap.org/ws/2005/05/identity"))
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new InvalidCardException(SR.GetString("UnexpectedElement")));
		}
		while (reader.Read() && (XmlNodeType.EndElement != reader.NodeType || !("SupportedClaimTypeList" == reader.LocalName)))
		{
			if ("http://schemas.xmlsoap.org/ws/2005/05/identity" == reader.NamespaceURI && "SupportedClaimType" == reader.LocalName)
			{
				InfoCardClaim infoCardClaim = ReadSingleClaim(reader);
				if (infoCardClaim != null)
				{
					AddClaim(infoCardClaim);
				}
			}
		}
	}

	private InfoCardClaim ReadSingleClaim(XmlReader reader)
	{
		InfoCardTrace.Assert(null != reader, "null reader", new object[0]);
		if (!reader.IsStartElement("SupportedClaimType", "http://schemas.xmlsoap.org/ws/2005/05/identity"))
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new InvalidCardException(SR.GetString("UnexpectedElement")));
		}
		string text = null;
		string displaytag = null;
		string description = null;
		string value = null;
		text = reader.GetAttribute("Uri", "http://schemas.xmlsoap.org/ws/2005/05/identity");
		if (string.IsNullOrEmpty(text))
		{
			text = reader.GetAttribute("Uri");
		}
		if (reader.IsEmptyElement)
		{
			if (!string.IsNullOrEmpty(text))
			{
				return new InfoCardClaim(text, value, description, displaytag);
			}
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new InvalidCardException(SR.GetString("ClaimIdNull")));
		}
		while (reader.Read())
		{
			switch (reader.LocalName)
			{
			case "ClaimValue":
				if (IsSelfIssued)
				{
					value = reader.ReadString().Trim();
				}
				break;
			case "DisplayTag":
				displaytag = reader.ReadString().Trim();
				break;
			case "Description":
				description = reader.ReadString().Trim();
				break;
			case "SupportedClaimType":
				if (XmlNodeType.EndElement == reader.NodeType)
				{
					if (string.IsNullOrEmpty(text))
					{
						throw InfoCardTrace.ThrowHelperError((Exception)(object)new InvalidCardException(SR.GetString("ClaimIdNull")));
					}
					return new InfoCardClaim(text, value, description, displaytag);
				}
				break;
			}
		}
		return null;
	}

	private void ReadAuthServices(XmlReader reader)
	{
		InfoCardTrace.Assert(null != reader, "null reader", new object[0]);
		if (!reader.IsStartElement("TokenServiceList", "http://schemas.xmlsoap.org/ws/2005/05/identity"))
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new InvalidCardException(SR.GetString("UnexpectedElement")));
		}
		if (reader.IsEmptyElement)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new InvalidCardException(SR.GetString("NoAuthenticationServicesInCard")));
		}
		while (reader.Read())
		{
			switch (reader.LocalName)
			{
			case "TokenService":
				if (reader.NodeType != XmlNodeType.EndElement)
				{
					TokenCreationParameter tokenCreationParameter = new TokenCreationParameter();
					tokenCreationParameter.ReadXml(reader);
					if (!tokenCreationParameter.IsComplete())
					{
						throw InfoCardTrace.ThrowHelperError((Exception)(object)new InvalidCardException(SR.GetString("ServiceInvalidTokenService")));
					}
					CreationParameters.Add(tokenCreationParameter);
				}
				break;
			case "TokenServiceList":
				return;
			}
		}
	}

	private List<string> ReadTokenType(XmlReader reader)
	{
		InfoCardTrace.Assert(null != reader, "null reader", new object[0]);
		if (!reader.IsStartElement("SupportedTokenTypeList", "http://schemas.xmlsoap.org/ws/2005/05/identity"))
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new InvalidCardException(SR.GetString("UnexpectedElement")));
		}
		List<string> list = new List<string>();
		while (true)
		{
			if (reader.Read())
			{
				if (XmlNodeType.EndElement == reader.NodeType && "SupportedTokenTypeList" == reader.LocalName)
				{
					break;
				}
				if ("TokenType" == reader.LocalName && "http://schemas.xmlsoap.org/ws/2005/02/trust" == reader.NamespaceURI && XmlNodeType.EndElement != reader.NodeType && !reader.IsEmptyElement)
				{
					string text = reader.ReadString().Trim();
					if (!string.IsNullOrEmpty(text))
					{
						list.Add(text);
					}
				}
				continue;
			}
			return list;
		}
		return list;
	}
}
