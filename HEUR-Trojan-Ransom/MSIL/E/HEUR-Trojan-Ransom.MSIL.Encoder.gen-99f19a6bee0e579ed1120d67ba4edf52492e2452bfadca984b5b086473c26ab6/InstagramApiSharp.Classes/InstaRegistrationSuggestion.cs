using Newtonsoft.Json;

namespace InstagramApiSharp.Classes;

public class InstaRegistrationSuggestion
{
	[JsonProperty("username")]
	public string Username { get; set; }

	[JsonProperty("prototype")]
	public string Prototype { get; set; }
}
