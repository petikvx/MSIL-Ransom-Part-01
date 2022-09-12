using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.Models;

public class InstaBiograpyEntity
{
	[JsonProperty("hashtag")]
	public InstaBiographyItem Hashtag { get; set; }

	[JsonProperty("user")]
	public InstaBiographyItem User { get; set; }
}
