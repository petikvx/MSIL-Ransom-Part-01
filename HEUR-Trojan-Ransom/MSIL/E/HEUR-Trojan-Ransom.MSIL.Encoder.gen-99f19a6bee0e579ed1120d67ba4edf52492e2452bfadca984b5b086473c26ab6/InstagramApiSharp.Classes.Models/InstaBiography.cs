using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.Models;

public class InstaBiography
{
	[JsonProperty("user")]
	public InstaBiographyUser User { get; set; }

	[JsonProperty("status")]
	public string Status { get; set; }
}
