using Newtonsoft.Json;

namespace InstagramApiSharp.Classes;

public class InstaAccountCreationErrors
{
	[JsonProperty("username")]
	public string[] Username { get; set; }
}
