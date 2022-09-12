using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaUserContextResponse
{
	[JsonProperty("start")]
	public int Start { get; set; }

	[JsonProperty("end")]
	public int End { get; set; }

	[JsonProperty("username")]
	public string Username { get; set; }
}
