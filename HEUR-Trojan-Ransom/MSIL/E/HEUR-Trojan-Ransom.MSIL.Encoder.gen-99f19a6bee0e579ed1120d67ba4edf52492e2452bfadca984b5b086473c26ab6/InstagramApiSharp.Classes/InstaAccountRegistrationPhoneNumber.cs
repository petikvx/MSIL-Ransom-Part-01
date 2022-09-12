using Newtonsoft.Json;

namespace InstagramApiSharp.Classes;

internal class InstaAccountRegistrationPhoneNumber
{
	[JsonProperty("message")]
	internal InstaAccountRegistrationPhoneNumberMessage Message { get; set; }

	[JsonProperty("error_source")]
	internal string ErrorSource { get; set; }

	[JsonProperty("status")]
	internal string Status { get; set; }

	[JsonProperty("error_type")]
	internal string ErrorType { get; set; }

	[JsonProperty("tos_version")]
	public string TosVersion { get; set; }

	[JsonProperty("gdpr_required")]
	public bool GdprRequired { get; set; }

	[JsonIgnore]
	public bool Succeed
	{
		get
		{
			if (!(Status.ToLower() == "ok"))
			{
				return false;
			}
			return true;
		}
	}
}
