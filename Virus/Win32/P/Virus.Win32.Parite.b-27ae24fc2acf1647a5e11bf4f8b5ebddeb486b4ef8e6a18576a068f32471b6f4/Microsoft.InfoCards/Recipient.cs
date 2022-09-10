using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IdentityModel.Tokens;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class Recipient
{
	public enum TrustDecision : byte
	{
		NoTrustDecision,
		IsTrusted,
		IsNotTrusted,
		PolicyVersionChange
	}

	public enum IdentityType : byte
	{
		DNS,
		X509
	}

	private enum IdType : byte
	{
		RecipientId,
		OrganizationId,
		PPIDSeed
	}

	public struct RecipientCertParameters
	{
		public string m_cn;

		public string m_organization;

		public string m_locality;

		public string m_state;

		public string m_country;

		public Utility.SubjectAtrributeHAFlags m_certHAFlags;

		public RecipientCertParameters(string cn, string organization, string locality, string state, string country, Utility.SubjectAtrributeHAFlags certHAFlags)
		{
			m_cn = cn;
			m_organization = organization;
			m_locality = locality;
			m_state = state;
			m_country = country;
			m_certHAFlags = certHAFlags;
		}
	}

	private struct RecipientAttribute
	{
		private string m_name;

		private string m_delimitingString;

		public string DelimitingString => m_delimitingString;

		public string Name => m_name;

		public RecipientAttribute(string name, string delimitingString)
		{
			m_name = name;
			m_delimitingString = delimitingString;
		}
	}

	private const int InvalidRow = 0;

	private const byte Version = 1;

	private const byte m_marker = 29;

	public const int CERT_NAME_ATTR_TYPE = 3;

	public const string szOID_SUBJECT_CN = "2.5.4.3";

	public const string szOID_ORGANIZATION_NAME = "2.5.4.10";

	public const string szOID_LOCALITY_NAME = "2.5.4.7";

	public const string szOID_STATE_OR_PROVINCE_NAME = "2.5.4.8";

	public const string szOID_COUNTRY_NAME = "2.5.4.6";

	private const int attributeMaxLength = 1024;

	private static readonly RecipientAttribute CNAttr = new RecipientAttribute("2.5.4.3", "CN");

	private static readonly RecipientAttribute OrgAttr = new RecipientAttribute("2.5.4.10", "O");

	private static readonly RecipientAttribute LocalityAttr = new RecipientAttribute("2.5.4.7", "L");

	private static readonly RecipientAttribute StateOrProvinceAttr = new RecipientAttribute("2.5.4.8", "S");

	private static readonly RecipientAttribute CountryAttr = new RecipientAttribute("2.5.4.6", "C");

	private string m_recipientId;

	private string m_recipientOrganizationId;

	private string m_issuerName;

	private string m_subjectName;

	private uint m_privacyNoticeVersion;

	private IdentityType m_type;

	private TrustDecision m_trustDecision;

	private RecipientCertParameters m_recipientParams = new RecipientCertParameters("", "", "", "", "", Utility.SubjectAtrributeHAFlags.NotEnabled);

	private bool m_isCertCached;

	private int m_rowId;

	private byte[] m_publicKey;

	private List<X509Logo> m_logoMetadata;

	public string RecipientId
	{
		get
		{
			InfoCardTrace.Assert(!string.IsNullOrEmpty(m_recipientId), "Must be populated before this property is accessed", new object[0]);
			return m_recipientId;
		}
	}

	public RecipientCertParameters RecipientParameters => m_recipientParams;

	public uint PrivacyPolicyVersion
	{
		get
		{
			return m_privacyNoticeVersion;
		}
		set
		{
			m_privacyNoticeVersion = value;
		}
	}

	public TrustDecision Trust
	{
		get
		{
			return m_trustDecision;
		}
		set
		{
			m_trustDecision = value;
		}
	}

	public Recipient(Stream stream)
		: this(stream, isCertCached: false)
	{
	}

	public Recipient(Stream stream, RecipientIdentity identity, bool isCertCached)
		: this(stream, isCertCached)
	{
		if (identity is X509RecipientIdentity x509RecipientIdentity)
		{
			m_type = IdentityType.X509;
			AddLogoMetadata(x509RecipientIdentity.LeafCertificate);
			m_recipientParams = x509RecipientIdentity.RecipientParams;
		}
	}

	private Recipient(Stream stream, bool isCertCached)
	{
		m_isCertCached = isCertCached;
		Deserialize(stream);
	}

	public Recipient(RecipientIdentity identity, bool isCertCached, uint privacyNoticeVersion)
	{
		m_trustDecision = TrustDecision.NoTrustDecision;
		m_isCertCached = isCertCached;
		m_privacyNoticeVersion = privacyNoticeVersion;
		m_recipientId = identity.GetIdentifier();
		m_recipientOrganizationId = identity.GetOrganizationIdentifier();
		m_subjectName = identity.GetName();
		if (identity is X509RecipientIdentity x509RecipientIdentity)
		{
			m_type = IdentityType.X509;
			m_issuerName = x509RecipientIdentity.LeafCertificate.GetNameInfo(X509NameType.SimpleName, forIssuer: true);
			m_recipientParams = x509RecipientIdentity.RecipientParams;
			m_publicKey = x509RecipientIdentity.LeafCertificate.GetPublicKey();
			AddLogoMetadata(x509RecipientIdentity.LeafCertificate);
		}
	}

	public Recipient(X509Certificate2 cert, string recipientId, string recipientOrgId, bool isCertCached, uint privacyNoticeVersion, RecipientCertParameters recipientParameters)
	{
		m_type = IdentityType.X509;
		m_trustDecision = TrustDecision.NoTrustDecision;
		m_publicKey = cert.GetPublicKey();
		m_isCertCached = isCertCached;
		m_privacyNoticeVersion = privacyNoticeVersion;
		m_subjectName = cert.FriendlyName;
		if (string.IsNullOrEmpty(m_subjectName))
		{
			m_subjectName = cert.GetNameInfo(X509NameType.SimpleName, forIssuer: false);
		}
		m_issuerName = cert.GetNameInfo(X509NameType.SimpleName, forIssuer: true);
		m_recipientId = recipientId;
		m_recipientOrganizationId = recipientOrgId;
		m_recipientParams = recipientParameters;
		AddLogoMetadata(cert);
	}

	private static byte[] CertGetRecipientIdBytesForChainTrust(X509Certificate2 recipientCert, X509Certificate2Collection supportingRecipientCerts, IdType idtype, out RecipientCertParameters recipientParams)
	{
		//IL_02a0: Expected O, but got Unknown
		recipientParams = new RecipientCertParameters("", "", "", "", "", Utility.SubjectAtrributeHAFlags.NotEnabled);
		string text = "";
		string certAttribute = GetCertAttribute(OrgAttr.Name, recipientCert.Handle);
		string certAttribute2 = GetCertAttribute(LocalityAttr.Name, recipientCert.Handle);
		string certAttribute3 = GetCertAttribute(StateOrProvinceAttr.Name, recipientCert.Handle);
		string certAttribute4 = GetCertAttribute(CountryAttr.Name, recipientCert.Handle);
		recipientParams.m_cn = GetCertAttribute(CNAttr.Name, recipientCert.Handle);
		recipientParams.m_organization = certAttribute;
		recipientParams.m_locality = certAttribute2;
		recipientParams.m_state = certAttribute3;
		recipientParams.m_country = certAttribute4;
		if (string.IsNullOrEmpty(certAttribute))
		{
			if (!string.IsNullOrEmpty(recipientParams.m_cn))
			{
				string s = string.Format(CultureInfo.InvariantCulture, "|{0}=\"{1}\"|", new object[2] { CNAttr.DelimitingString, recipientParams.m_cn });
				return Encoding.Unicode.GetBytes(s);
			}
			return recipientCert.GetPublicKey();
		}
		string text2 = ((IdType.OrganizationId == idtype || IdType.PPIDSeed == idtype) ? string.Format(CultureInfo.InvariantCulture, "|{0}=\"{1}\"|{2}=\"{3}\"|{4}=\"{5}\"|{6}=\"{7}\"|", OrgAttr.DelimitingString, certAttribute, LocalityAttr.DelimitingString, certAttribute2, StateOrProvinceAttr.DelimitingString, certAttribute3, CountryAttr.DelimitingString, certAttribute4) : string.Format(CultureInfo.InvariantCulture, "|{0}=\"{1}\"|{2}=\"{3}\"|{4}=\"{5}\"|{6}=\"{7}\"|{8}=\"{9}\"|", CNAttr.DelimitingString, recipientParams.m_cn, OrgAttr.DelimitingString, certAttribute, LocalityAttr.DelimitingString, certAttribute2, StateOrProvinceAttr.DelimitingString, certAttribute3, CountryAttr.DelimitingString, certAttribute4));
		Utility.SubjectAtrributeHAFlags certFlags = Utility.SubjectAtrributeHAFlags.NotEnabled;
		if (Utility.GetCertHAFlags(recipientCert, supportingRecipientCerts, ref certFlags))
		{
			recipientParams.m_certHAFlags = certFlags;
			_ = Utility.IsSubjectAtrributeHAFlagsSet(certFlags, Utility.SubjectAtrributeHAFlags.LocStateCountryHA) ^ Utility.IsSubjectAtrributeHAFlagsSet(certFlags, Utility.SubjectAtrributeHAFlags.OrganizationHA);
			text = text2;
			if (string.IsNullOrEmpty(text))
			{
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new UntrustedRecipientException(SR.GetString("InvalidHACertificateStructure")));
			}
		}
		else
		{
			X509Chain chain;
			try
			{
				InfoCardX509Validator.ValidateChain(recipientCert, supportingRecipientCerts, out chain);
			}
			catch (SecurityTokenValidationException val)
			{
				SecurityTokenValidationException inner = val;
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new UntrustedRecipientException(SR.GetString("UnableToBuildChainForNonHARecipient"), (Exception)(object)inner));
			}
			if (IdType.OrganizationId == idtype)
			{
				text = "|Non-EV";
			}
			if (idtype == IdType.RecipientId)
			{
				for (int i = 1; i < chain.ChainElements.Count; i++)
				{
					X509ChainElement x509ChainElement = chain.ChainElements[i];
					text = string.Format(CultureInfo.InvariantCulture, "|ChainElement=\"{0}\"{1}", new object[2]
					{
						x509ChainElement.Certificate.Subject,
						text
					});
				}
			}
			text += text2;
		}
		return Encoding.Unicode.GetBytes(text);
	}

	public static string CertGetRecipientOrganizationPPIDSeedHash(X509Certificate2 recipientCert, X509Certificate2Collection supportingRecipientCerts, bool isChainTrusted)
	{
		RecipientCertParameters recipientParams;
		byte[] buffer = (isChainTrusted ? CertGetRecipientIdBytesForChainTrust(recipientCert, supportingRecipientCerts, IdType.PPIDSeed, out recipientParams) : recipientCert.GetPublicKey());
		byte[] inArray;
		using (SHA256 sHA = new SHA256Managed())
		{
			inArray = sHA.ComputeHash(buffer);
		}
		return Convert.ToBase64String(inArray);
	}

	public static string CertGetRecipientOrganizationIdHash(X509Certificate2 recipientCert, X509Certificate2Collection supportingRecipientCerts, bool isChainTrusted)
	{
		RecipientCertParameters recipientParams;
		byte[] buffer = (isChainTrusted ? CertGetRecipientIdBytesForChainTrust(recipientCert, supportingRecipientCerts, IdType.OrganizationId, out recipientParams) : recipientCert.GetPublicKey());
		byte[] inArray;
		using (SHA256 sHA = new SHA256Managed())
		{
			inArray = sHA.ComputeHash(buffer);
		}
		return Convert.ToBase64String(inArray);
	}

	public static string CertGetRecipientIdHash(X509Certificate2 recipientCert, X509Certificate2Collection supportingRecipientCerts, bool isChainTrusted, out RecipientCertParameters recipientParams)
	{
		byte[] buffer;
		if (!isChainTrusted)
		{
			buffer = recipientCert.GetPublicKey();
			recipientParams = new RecipientCertParameters(GetCertAttribute(CNAttr.Name, recipientCert.Handle), GetCertAttribute(OrgAttr.Name, recipientCert.Handle), GetCertAttribute(LocalityAttr.Name, recipientCert.Handle), GetCertAttribute(StateOrProvinceAttr.Name, recipientCert.Handle), GetCertAttribute(CountryAttr.Name, recipientCert.Handle), Utility.SubjectAtrributeHAFlags.NotEnabled);
		}
		else
		{
			buffer = CertGetRecipientIdBytesForChainTrust(recipientCert, supportingRecipientCerts, IdType.RecipientId, out recipientParams);
		}
		byte[] inArray;
		using (SHA256 sHA = new SHA256Managed())
		{
			inArray = sHA.ComputeHash(buffer);
		}
		return Convert.ToBase64String(inArray);
	}

	private static string GetCertAttribute(string geographicAttributeName, IntPtr certHandle)
	{
		StringBuilder stringBuilder = new StringBuilder(1024);
		NativeMethods.CertGetNameStringW(certHandle, 3, 0, geographicAttributeName, stringBuilder, 1024);
		return stringBuilder.ToString();
	}

	private void ThrowIfNotComplete()
	{
		bool flag = m_recipientId != null && null != m_subjectName;
		if (IdentityType.X509 == m_type)
		{
			flag = flag && m_issuerName != null && !Utility.ArrayIsNullOrEmpty(m_publicKey);
		}
		if (!flag)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new SerializationIncompleteException(GetType()));
		}
	}

	private void AddLogoMetadata(X509Certificate2 cert)
	{
		X509LogoTypeExtension x509LogoTypeExtension = X509LogoTypeExtension.FromCertificate(cert);
		if (x509LogoTypeExtension != null)
		{
			x509LogoTypeExtension.TryDecodeExtension();
			m_logoMetadata = x509LogoTypeExtension.Logos;
		}
	}

	public void Serialize(BinaryWriter writer)
	{
		AgentSerialize(writer);
	}

	public void AgentSerialize(BinaryWriter writer)
	{
		ThrowIfNotComplete();
		writer.Write((byte)1);
		writer.Write((byte)m_type);
		writer.Write(m_isCertCached);
		writer.Write((uint)m_recipientParams.m_certHAFlags);
		Utility.SerializeString(writer, m_recipientParams.m_cn);
		Utility.SerializeString(writer, m_recipientParams.m_organization);
		Utility.SerializeString(writer, m_recipientParams.m_locality);
		Utility.SerializeString(writer, m_recipientParams.m_state);
		Utility.SerializeString(writer, m_recipientParams.m_country);
		Utility.SerializeString(writer, m_recipientId);
		Utility.SerializeString(writer, m_recipientOrganizationId);
		Utility.SerializeString(writer, m_issuerName);
		Utility.SerializeString(writer, m_subjectName);
		writer.Write(m_privacyNoticeVersion);
		Utility.SerializeBytes(writer, m_publicKey);
		writer.Write((byte)m_trustDecision);
		if (m_logoMetadata == null)
		{
			writer.Write(0);
		}
		else
		{
			writer.Write(m_logoMetadata.Count);
			foreach (X509Logo logoMetadatum in m_logoMetadata)
			{
				logoMetadatum.Serialize(writer);
			}
		}
		writer.Write((byte)29);
	}

	public void SerializeToStore(BinaryWriter writer)
	{
		ThrowIfNotComplete();
		writer.Write((byte)1);
		writer.Write((uint)m_recipientParams.m_certHAFlags);
		Utility.SerializeString(writer, m_recipientParams.m_cn);
		Utility.SerializeString(writer, m_recipientParams.m_organization);
		Utility.SerializeString(writer, m_recipientParams.m_locality);
		Utility.SerializeString(writer, m_recipientParams.m_state);
		Utility.SerializeString(writer, m_recipientParams.m_country);
		Utility.SerializeString(writer, m_recipientId);
		Utility.SerializeString(writer, m_recipientOrganizationId);
		Utility.SerializeString(writer, m_issuerName);
		Utility.SerializeString(writer, m_subjectName);
		writer.Write(m_privacyNoticeVersion);
		Utility.SerializeBytes(writer, m_publicKey);
		writer.Write((byte)m_trustDecision);
		writer.Write((byte)29);
	}

	public void Deserialize(Stream stream)
	{
		BinaryReader binaryReader = new InfoCardBinaryReader(stream, Encoding.Unicode);
		if (1 != binaryReader.ReadByte())
		{
			InfoCardTrace.Assert(false, "version mismatch deserializing recipient stream", new object[0]);
		}
		m_recipientParams = default(RecipientCertParameters);
		m_recipientParams.m_certHAFlags = (Utility.SubjectAtrributeHAFlags)binaryReader.ReadUInt32();
		m_recipientParams.m_cn = Utility.DeserializeString(binaryReader);
		m_recipientParams.m_organization = Utility.DeserializeString(binaryReader);
		m_recipientParams.m_locality = Utility.DeserializeString(binaryReader);
		m_recipientParams.m_state = Utility.DeserializeString(binaryReader);
		m_recipientParams.m_country = Utility.DeserializeString(binaryReader);
		m_recipientId = Utility.DeserializeString(binaryReader);
		m_recipientOrganizationId = Utility.DeserializeString(binaryReader);
		m_issuerName = Utility.DeserializeString(binaryReader);
		m_subjectName = Utility.DeserializeString(binaryReader);
		m_privacyNoticeVersion = binaryReader.ReadUInt32();
		m_publicKey = binaryReader.ReadBytes(binaryReader.ReadInt32());
		if (m_publicKey.Length == 0)
		{
			m_type = IdentityType.DNS;
		}
		else
		{
			m_type = IdentityType.X509;
		}
		m_trustDecision = (TrustDecision)binaryReader.ReadByte();
		if (29 != binaryReader.ReadByte())
		{
			InfoCardTrace.Assert(false, "Invalid stream detected deserilizing recipient", new object[0]);
		}
		ThrowIfNotComplete();
	}

	public void Save(StoreConnection con)
	{
		DataRow dataRow = TryGetRow(con, QueryDetails.FullHeader);
		if (dataRow == null)
		{
			dataRow = new DataRow();
			dataRow.ObjectType = -3;
			dataRow.GlobalId = Guid.NewGuid();
		}
		dataRow.SetIndexValue("ix_name", m_recipientId);
		MemoryStream memoryStream = new MemoryStream();
		BinaryWriter writer = new BinaryWriter(memoryStream, Encoding.Unicode);
		SerializeToStore(writer);
		dataRow.SetDataField(memoryStream.ToArray());
		con.Save(dataRow);
		m_rowId = dataRow.LocalId;
	}

	public override string ToString()
	{
		return base.ToString();
	}

	public bool IsOrganizationVerified()
	{
		return (m_recipientParams.m_certHAFlags & (Utility.SubjectAtrributeHAFlags.Enabled | Utility.SubjectAtrributeHAFlags.OrganizationHA)) == (Utility.SubjectAtrributeHAFlags.Enabled | Utility.SubjectAtrributeHAFlags.OrganizationHA);
	}

	protected DataRow TryGetRow(StoreConnection con, QueryDetails details)
	{
		return con.GetSingleRow(QueryDetails.FullHeader, new QueryParameter("ix_objecttype", -3), new QueryParameter("ix_name", m_recipientId));
	}
}
