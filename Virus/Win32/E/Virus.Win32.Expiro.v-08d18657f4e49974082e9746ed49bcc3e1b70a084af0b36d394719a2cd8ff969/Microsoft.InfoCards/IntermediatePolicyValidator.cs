namespace Microsoft.InfoCards;

internal class IntermediatePolicyValidator : PolicyValidator
{
	public IntermediatePolicyValidator(InfoCardPolicy policy)
		: base(policy)
	{
	}

	public override void Validate()
	{
		ValidateAppliesTo();
	}
}
