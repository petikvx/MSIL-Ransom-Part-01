using DevDefined.OAuth.Framework;

namespace DevDefined.OAuth.Provider;

public class AccessOutcome
{
	public bool Granted { get; set; }

	public string AdditionalInfo { get; set; }

	public IOAuthContext Context { get; set; }
}
