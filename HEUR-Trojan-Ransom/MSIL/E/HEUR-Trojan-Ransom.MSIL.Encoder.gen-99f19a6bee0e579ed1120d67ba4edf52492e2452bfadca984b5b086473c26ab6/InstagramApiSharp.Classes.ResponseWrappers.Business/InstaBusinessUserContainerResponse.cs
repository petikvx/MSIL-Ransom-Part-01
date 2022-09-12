using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers.Business;

public class InstaBusinessUserContainerResponse
{
	[JsonProperty("user")]
	public InstaBusinessUserResponse User { get; set; }

	[JsonProperty("status")]
	public string Status { get; set; }
}
