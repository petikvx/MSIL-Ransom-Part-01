using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.Models;

public class InstaAccountCheck
{
	[JsonProperty("username")]
	public string Username { get; set; }

	[JsonProperty("available")]
	public bool Available { get; set; }

	[JsonProperty("error")]
	public string Error { get; set; }

	[JsonProperty("status")]
	internal string Status { get; set; }

	[JsonProperty("error_type")]
	internal string ErrorType { get; set; }
}
