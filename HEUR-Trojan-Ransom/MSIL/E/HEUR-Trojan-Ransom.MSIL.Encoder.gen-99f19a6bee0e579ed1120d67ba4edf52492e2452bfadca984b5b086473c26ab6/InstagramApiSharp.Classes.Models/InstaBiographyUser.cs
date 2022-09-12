using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.Models;

public class InstaBiographyUser
{
	[JsonProperty("pk")]
	public long Pk { get; set; }

	[JsonProperty("biography")]
	public string Biography { get; set; }

	[JsonProperty("biography_with_entities")]
	public InstaBiographyEntities BiographyWithEntities { get; set; }
}
