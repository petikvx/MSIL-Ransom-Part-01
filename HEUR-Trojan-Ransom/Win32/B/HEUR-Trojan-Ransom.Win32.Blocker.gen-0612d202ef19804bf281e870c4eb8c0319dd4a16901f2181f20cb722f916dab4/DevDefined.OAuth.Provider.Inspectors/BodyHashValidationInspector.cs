using DevDefined.OAuth.Framework;
using DevDefined.OAuth.Utility;

namespace DevDefined.OAuth.Provider.Inspectors;

public class BodyHashValidationInspector : IContextInspector
{
	public void InspectContext(ProviderPhase phase, IOAuthContext context)
	{
		if (!(context.SignatureMethod == "PLAINTEXT") && !string.IsNullOrEmpty(context.BodyHash))
		{
			if (!string.IsNullOrEmpty(context.BodyHash) && context.FormEncodedParameters.Count > 0)
			{
				throw Error.EncounteredUnexpectedBodyHashInFormEncodedRequest(context);
			}
			if (!context.BodyHash.EqualsInConstantTime(context.GenerateBodyHash()))
			{
				throw Error.FailedToValidateBodyHash(context);
			}
		}
	}
}
