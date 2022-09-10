namespace Microsoft.InfoCards;

internal class PolicyUtility
{
	public static bool IsSelfIssuedTokenType(string tokenType)
	{
		if (!("urn:oasis:names:tc:SAML:1.0:assertion" == tokenType) && !("urn:oasis:names:tc:SAML:1.0:assertion" == tokenType) && !("http://docs.oasis-open.org/wss/oasis-wss-saml-token-profile-1.1#SAMLV1.1" == tokenType))
		{
			return false;
		}
		return true;
	}

	public static bool IsSelfIssuedClaim(string claimType)
	{
		string[] selfIssuedClaimsUris = InfoCardConstants.SelfIssuedClaimsUris;
		int num = 0;
		while (true)
		{
			if (num < selfIssuedClaimsUris.Length)
			{
				string text = selfIssuedClaimsUris[num];
				if (text == claimType)
				{
					break;
				}
				num++;
				continue;
			}
			if (InfoCardConstants.PPIDClaimsUri == claimType)
			{
				return true;
			}
			return false;
		}
		return true;
	}
}
