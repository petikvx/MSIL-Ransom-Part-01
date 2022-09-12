using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.Models;

public class InstaUserEditContainer
{
	[JsonProperty("user")]
	public InstaUserEdit User { get; set; }

	[JsonProperty("status")]
	internal string Status { get; set; }
}
