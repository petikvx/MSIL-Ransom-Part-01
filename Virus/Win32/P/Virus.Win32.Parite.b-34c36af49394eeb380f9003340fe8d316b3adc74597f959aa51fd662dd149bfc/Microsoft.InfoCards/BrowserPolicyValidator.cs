namespace Microsoft.InfoCards;

internal class BrowserPolicyValidator : PolicyValidator
{
	public BrowserPolicyValidator(InfoCardPolicy policy)
		: base(policy)
	{
	}

	public override void Validate()
	{
		ValidateClaims();
		ValidateNonWhiteListElements();
		ValidateRequestType();
		ValidateTokenType();
		ValidatePrivacyVersion();
		ValidateRecipients();
	}
}
