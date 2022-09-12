using InstagramApiSharp.Enums;

namespace InstagramApiSharp.Classes.Models;

public class InstaUserLookup
{
	public bool MultipleUsersFound { get; set; }

	public bool EmailSent { get; set; }

	public bool SmsSent { get; set; }

	public InstaLookupType LookupSourceType { get; set; }

	public string CorrectedInput { get; set; }

	public InstaUserShort User { get; set; }

	public bool HasValidPhone { get; set; }

	public bool CanEmailReset { get; set; }

	public bool CanSmsReset { get; set; }

	public bool CanWaReset { get; set; }

	public string Email { get; set; }

	public string PhoneNumber { get; set; }
}
