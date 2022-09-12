using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaContactUserResponse
{
	[JsonProperty("user")]
	public InstaUserContactResponse User { get; set; }
}
