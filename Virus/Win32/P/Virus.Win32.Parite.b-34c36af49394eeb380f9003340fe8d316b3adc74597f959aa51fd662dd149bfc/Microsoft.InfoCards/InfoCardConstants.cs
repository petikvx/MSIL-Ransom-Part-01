using System;
using System.Collections.Generic;
using System.IdentityModel.Claims;
using System.Xml;
using Microsoft.InfoCards.Diagnostics;
using Microsoft.Win32;

namespace Microsoft.InfoCards;

internal static class InfoCardConstants
{
	private const int DEFAULT_MAX_MESSAGE_SIZE = 20971520;

	private const int DEFAULT_MAX_MEX_CHAIN = 100;

	private const string MAX_MESSAGE_KEY = "MaximumMessageSize";

	private const string MAX_MEX_CHAIN = "MaximumMexChain";

	private const string INFOCARD_REGISTRY_KEY = "software\\microsoft\\infocard";

	private static int s_maxMessageSize;

	private static int s_maxMexChainLength;

	private static string[] s_SelfIssuedClaims;

	private static Dictionary<string, string> s_claimDisplayTags;

	private static Dictionary<string, string> s_claimDescription;

	private static XmlDictionaryReaderQuotas s_defaultQuotas;

	private static List<string> s_localTokenFactoryWhiteList;

	private static List<string> s_policyElementsToBeProcessed;

	public static int MaximumMessageSize => s_maxMessageSize;

	public static int MaximumMexChainLength => s_maxMexChainLength;

	public static string RegistryKey => "software\\microsoft\\infocard";

	public static string GivenName => ClaimTypes.get_GivenName();

	public static string EmailAddress => ClaimTypes.get_Email();

	public static string Surname => ClaimTypes.get_Surname();

	public static string StreetAddress => ClaimTypes.get_StreetAddress();

	public static string Locality => ClaimTypes.get_Locality();

	public static string StateOrProvince => ClaimTypes.get_StateOrProvince();

	public static string PostalCode => ClaimTypes.get_PostalCode();

	public static string Country => ClaimTypes.get_Country();

	public static string HomePhone => ClaimTypes.get_HomePhone();

	public static string OtherPhone => ClaimTypes.get_OtherPhone();

	public static string MobilePhone => ClaimTypes.get_MobilePhone();

	public static string DateOfBirth => ClaimTypes.get_DateOfBirth();

	public static string Gender => ClaimTypes.get_Gender();

	public static string PPID => ClaimTypes.get_PPID();

	public static string Webpage => ClaimTypes.get_Webpage();

	public static XmlDictionaryReaderQuotas DefaultQuotas => s_defaultQuotas;

	public static string[] SelfIssuedClaimsUris => s_SelfIssuedClaims;

	public static string PPIDClaimsUri => PPID;

	public static bool DoesLocalTokenFactoryWhiteListContain(string nameSpaceValue, string value)
	{
		return s_localTokenFactoryWhiteList.Contains(nameSpaceValue + "/" + value);
	}

	public static bool DoesPolicyElementsToBeProcessedListContain(string nameSpaceValue, string value)
	{
		return s_policyElementsToBeProcessed.Contains(nameSpaceValue + "/" + value);
	}

	public static string ClaimDisplayTag(string key)
	{
		string text = null;
		if (!s_claimDisplayTags.ContainsKey(key))
		{
			throw InfoCardTrace.ThrowHelperWarning((Exception)new ArgumentOutOfRangeException(SR.GetString("InvalidSelfIssuedUri")));
		}
		return SR.GetString(s_claimDisplayTags[key]);
	}

	public static string ClaimsDescription(string key)
	{
		string text = null;
		if (!s_claimDescription.ContainsKey(key))
		{
			throw InfoCardTrace.ThrowHelperWarning((Exception)new ArgumentOutOfRangeException(SR.GetString("InvalidSelfIssuedUri")));
		}
		return SR.GetString(s_claimDescription[key]);
	}

	static InfoCardConstants()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		s_SelfIssuedClaims = new string[14]
		{
			GivenName, Surname, EmailAddress, StreetAddress, Locality, StateOrProvince, PostalCode, Country, HomePhone, OtherPhone,
			MobilePhone, DateOfBirth, Gender, Webpage
		};
		s_claimDisplayTags = new Dictionary<string, string>();
		s_claimDescription = new Dictionary<string, string>();
		s_defaultQuotas = new XmlDictionaryReaderQuotas();
		s_localTokenFactoryWhiteList = new List<string>();
		s_policyElementsToBeProcessed = new List<string>();
		s_claimDisplayTags.Add(GivenName, "GivenNameText");
		s_claimDisplayTags.Add(EmailAddress, "EmailAddressText");
		s_claimDisplayTags.Add(Country, "CountryText");
		s_claimDisplayTags.Add(DateOfBirth, "DateOfBirthText");
		s_claimDisplayTags.Add(Gender, "GenderText");
		s_claimDisplayTags.Add(HomePhone, "HomePhoneText");
		s_claimDisplayTags.Add(Locality, "LocalityText");
		s_claimDisplayTags.Add(MobilePhone, "MobilePhoneText");
		s_claimDisplayTags.Add(OtherPhone, "OtherPhoneText");
		s_claimDisplayTags.Add(PostalCode, "PostalCodeText");
		s_claimDisplayTags.Add(StateOrProvince, "StateOrProvinceText");
		s_claimDisplayTags.Add(StreetAddress, "StreetAddressText");
		s_claimDisplayTags.Add(Surname, "SurnameText");
		s_claimDisplayTags.Add(PPID, "PPIDText");
		s_claimDisplayTags.Add(Webpage, "WebPageText");
		s_claimDescription.Add(GivenName, "GivenNameDescription");
		s_claimDescription.Add(EmailAddress, "EmailAddressDescription");
		s_claimDescription.Add(Country, "CountryDescription");
		s_claimDescription.Add(DateOfBirth, "DateOfBirthDescription");
		s_claimDescription.Add(Gender, "GenderDescription");
		s_claimDescription.Add(HomePhone, "HomePhoneDescription");
		s_claimDescription.Add(Locality, "LocalityDescription");
		s_claimDescription.Add(MobilePhone, "MobilePhoneDescription");
		s_claimDescription.Add(OtherPhone, "OtherPhoneDescription");
		s_claimDescription.Add(PostalCode, "PostalCodeDescription");
		s_claimDescription.Add(StateOrProvince, "StateOrProvinceDescription");
		s_claimDescription.Add(StreetAddress, "StreetAddressDescription");
		s_claimDescription.Add(Surname, "SurnameDescription");
		s_claimDescription.Add(PPID, "PPIDDescription");
		s_claimDescription.Add(Webpage, "WebPageDescription");
		s_defaultQuotas.set_MaxDepth(32);
		s_defaultQuotas.set_MaxStringContentLength(8192);
		s_defaultQuotas.set_MaxArrayLength(20971520);
		s_defaultQuotas.set_MaxBytesPerRead(4096);
		s_defaultQuotas.set_MaxNameTableCharCount(16384);
		s_maxMessageSize = 20971520;
		s_maxMexChainLength = 100;
		using (new SystemIdentity(throwIfAlreadySystem: false))
		{
			using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("software\\microsoft\\infocard", writable: false);
			if (registryKey != null)
			{
				object value = registryKey.GetValue("MaximumMessageSize", 20971520);
				if (value is int && (int)value > 0 && (int)value * 1024 > 0)
				{
					s_maxMessageSize = (int)value * 1024;
				}
				object value2 = registryKey.GetValue("MaximumMexChain", 100);
				if (value2 is int && (int)value2 > 0)
				{
					s_maxMexChainLength = (int)value2;
				}
			}
		}
		s_localTokenFactoryWhiteList.Add("http://schemas.xmlsoap.org/ws/2005/02/trust/SignatureAlgorithm");
		s_localTokenFactoryWhiteList.Add("http://schemas.xmlsoap.org/ws/2005/02/trust/EncryptionAlgorithm");
		s_localTokenFactoryWhiteList.Add("http://schemas.xmlsoap.org/ws/2005/02/trust/CanonicalizationAlgorithm");
		s_localTokenFactoryWhiteList.Add("http://schemas.xmlsoap.org/ws/2005/02/trust/SignWith");
		s_localTokenFactoryWhiteList.Add("http://schemas.xmlsoap.org/ws/2005/02/trust/Claims");
		s_localTokenFactoryWhiteList.Add("http://schemas.xmlsoap.org/ws/2005/02/trust/TokenType");
		s_localTokenFactoryWhiteList.Add("http://schemas.xmlsoap.org/ws/2005/02/trust/KeyType");
		s_localTokenFactoryWhiteList.Add("http://schemas.xmlsoap.org/ws/2005/02/trust/KeySize");
		s_localTokenFactoryWhiteList.Add("http://schemas.xmlsoap.org/ws/2005/02/trust/EncryptWith");
		s_localTokenFactoryWhiteList.Add("http://schemas.xmlsoap.org/ws/2005/02/trust/RequestType");
		s_localTokenFactoryWhiteList.Add("http://docs.oasis-open.org/ws-sx/ws-trust/200512/SignatureAlgorithm");
		s_localTokenFactoryWhiteList.Add("http://docs.oasis-open.org/ws-sx/ws-trust/200512/EncryptionAlgorithm");
		s_localTokenFactoryWhiteList.Add("http://docs.oasis-open.org/ws-sx/ws-trust/200512/CanonicalizationAlgorithm");
		s_localTokenFactoryWhiteList.Add("http://docs.oasis-open.org/ws-sx/ws-trust/200512/SignWith");
		s_localTokenFactoryWhiteList.Add("http://docs.oasis-open.org/ws-sx/ws-trust/200512/Claims");
		s_localTokenFactoryWhiteList.Add("http://docs.oasis-open.org/ws-sx/ws-trust/200512/TokenType");
		s_localTokenFactoryWhiteList.Add("http://docs.oasis-open.org/ws-sx/ws-trust/200512/KeyType");
		s_localTokenFactoryWhiteList.Add("http://docs.oasis-open.org/ws-sx/ws-trust/200512/KeySize");
		s_localTokenFactoryWhiteList.Add("http://docs.oasis-open.org/ws-sx/ws-trust/200512/EncryptWith");
		s_localTokenFactoryWhiteList.Add("http://docs.oasis-open.org/ws-sx/ws-trust/200512/RequestType");
		s_localTokenFactoryWhiteList.Add("http://docs.oasis-open.org/ws-sx/ws-trust/200512/SecondaryParameters");
		s_localTokenFactoryWhiteList.Add("http://docs.oasis-open.org/ws-sx/ws-trust/200512/KeyWrapAlgorithm");
		s_localTokenFactoryWhiteList.Add("http://schemas.xmlsoap.org/ws/2005/07/securitypolicy/RequestSecurityTokenTemplate");
		s_localTokenFactoryWhiteList.Add("http://docs.oasis-open.org/ws-sx/ws-securitypolicy/200512/RequestSecurityTokenTemplate");
		s_policyElementsToBeProcessed.AddRange(s_localTokenFactoryWhiteList);
		s_policyElementsToBeProcessed.Add("http://schemas.xmlsoap.org/ws/2004/09/policy/AppliesTo");
		s_policyElementsToBeProcessed.Add("http://www.w3.org/ns/ws-policy/AppliesTo");
	}
}
