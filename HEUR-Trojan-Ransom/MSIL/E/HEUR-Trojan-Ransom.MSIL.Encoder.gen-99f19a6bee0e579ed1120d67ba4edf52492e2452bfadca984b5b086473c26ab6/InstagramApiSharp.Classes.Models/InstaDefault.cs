using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.Models;

public class InstaDefault
{
	[JsonProperty("status")]
	public string Status { get; set; }

	[JsonProperty("message")]
	public string Message { get; set; }
}
