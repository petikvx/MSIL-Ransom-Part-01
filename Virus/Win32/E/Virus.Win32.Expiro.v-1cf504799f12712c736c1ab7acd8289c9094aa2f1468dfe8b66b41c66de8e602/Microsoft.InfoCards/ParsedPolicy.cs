using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class ParsedPolicy
{
	private string m_policyXmlOriginal;

	private string m_policyXmlPrimary;

	private string m_policyXmlSecondary;

	private PolicyType m_policyType;

	public string PolicyXmlOriginal => m_policyXmlOriginal;

	public string PolicyXmlPrimary => m_policyXmlPrimary;

	public string PolicyXmlSecondary => m_policyXmlSecondary;

	public PolicyType PolicyType => m_policyType;

	public ParsedPolicy(string policyXmlOriginal, string policyXmlPrimary, string policyXmlSecondary)
	{
		InfoCardTrace.Assert(!string.IsNullOrEmpty(policyXmlOriginal), "Original Policy Xml cannot be null or empty", new object[0]);
		m_policyXmlOriginal = policyXmlOriginal;
		m_policyXmlPrimary = policyXmlPrimary;
		m_policyXmlSecondary = policyXmlSecondary;
		if (!string.IsNullOrEmpty(policyXmlPrimary) && string.IsNullOrEmpty(policyXmlSecondary))
		{
			m_policyType = PolicyType.PrimaryOnly;
		}
		else if (!string.IsNullOrEmpty(policyXmlPrimary) && !string.IsNullOrEmpty(policyXmlSecondary))
		{
			m_policyType = PolicyType.Composite;
		}
		else if (string.IsNullOrEmpty(policyXmlPrimary) && !string.IsNullOrEmpty(policyXmlSecondary))
		{
			m_policyType = PolicyType.SecondaryOnly;
		}
		else
		{
			InfoCardTrace.Assert(false, "Both policies cannot be empty", new object[0]);
		}
	}
}
