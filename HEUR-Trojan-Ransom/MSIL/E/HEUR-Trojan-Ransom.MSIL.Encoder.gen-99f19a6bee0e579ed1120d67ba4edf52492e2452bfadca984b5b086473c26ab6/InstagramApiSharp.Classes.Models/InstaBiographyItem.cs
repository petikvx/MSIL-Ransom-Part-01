using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.Models;

public class InstaBiographyItem
{
	[JsonProperty("id")]
	public long Id { get; set; }

	[JsonProperty("name")]
	public string Name { get; set; }
}
