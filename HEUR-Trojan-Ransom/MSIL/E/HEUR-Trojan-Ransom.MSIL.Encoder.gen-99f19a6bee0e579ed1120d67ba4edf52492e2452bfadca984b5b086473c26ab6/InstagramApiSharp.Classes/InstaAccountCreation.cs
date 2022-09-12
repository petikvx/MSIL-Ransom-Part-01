using InstagramApiSharp.Classes.ResponseWrappers;
using Newtonsoft.Json;

namespace InstagramApiSharp.Classes;

public class InstaAccountCreation
{
	[JsonProperty("status")]
	public string Status { get; set; }

	[JsonProperty("account_created")]
	public bool AccountCreated { get; set; }

	[JsonProperty("created_user")]
	public InstaUserShortResponse CreatedUser { get; set; }
}
