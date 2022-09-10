using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.Xml;
using System.ServiceModel.Channels;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class RequestSecurityTokenParameters
{
	private AddressingVersion m_addressingVersion;

	private GetBrowserTokenParameters m_browserTokenParams;

	private InfoCardPolicy m_policy;

	private InfoCard m_card;

	private bool m_discloseOptionalClaims;

	private RSAKeyValue m_rsaKeyValue;

	private byte[] m_clientEntropyForSymmetric;

	private CultureInfo m_cultureInfo;

	private string m_context;

	private Dictionary<string, bool> m_disclosedClaims;

	private ProtocolProfile m_profile;

	public AddressingVersion Version => m_addressingVersion;

	public GetBrowserTokenParameters BrowserTokenParams => m_browserTokenParams;

	public InfoCardPolicy Policy => m_policy;

	public InfoCard Card => m_card;

	public bool DiscloseOptionalClaims => m_discloseOptionalClaims;

	public RSAKeyValue RSAKey => m_rsaKeyValue;

	public byte[] ClientEntropyForSymmetric => m_clientEntropyForSymmetric;

	public CultureInfo Culture => m_cultureInfo;

	public string Context => m_context;

	public Dictionary<string, bool> DisclosedClaims => m_disclosedClaims;

	public ProtocolProfile Profile => m_profile;

	public RequestSecurityTokenParameters(AddressingVersion version, InfoCard card, InfoCardPolicy policy, bool discloseOptionalClaims, RSAKeyValue rsaKeyValue, Dictionary<string, bool> disclosedClaims, string context, byte[] clientEntropyForSymmetric, CultureInfo displayCulture)
	{
		m_card = card;
		m_policy = policy;
		m_discloseOptionalClaims = discloseOptionalClaims;
		m_rsaKeyValue = rsaKeyValue;
		m_clientEntropyForSymmetric = clientEntropyForSymmetric;
		m_profile = policy.ProtocolVersionProfile;
		InfoCardTrace.Assert((m_rsaKeyValue == null && m_clientEntropyForSymmetric != null) || (m_rsaKeyValue == null && m_clientEntropyForSymmetric == null) || (m_rsaKeyValue != null && null == m_clientEntropyForSymmetric), "The three allowed cases are symmetric, noProofKey, asymmetric", new object[0]);
		m_disclosedClaims = disclosedClaims;
		m_addressingVersion = version;
		m_context = context;
		m_cultureInfo = displayCulture;
	}

	public RequestSecurityTokenParameters(AddressingVersion addressing, GetBrowserTokenParameters parameters, ProtocolProfile profile, InfoCardPolicy policy, bool discloseOptionalClaims)
	{
		m_browserTokenParams = parameters;
		m_addressingVersion = addressing;
		m_policy = policy;
		m_discloseOptionalClaims = discloseOptionalClaims;
		m_context = Guid.NewGuid().ToString();
		m_profile = profile;
	}
}
