using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.Models.Business;

public class InstaBusinessCityLocation
{
	[JsonProperty("__typename")]
	internal string TypeName { get; set; }

	[JsonProperty("id")]
	public string Id { get; set; }

	[JsonProperty("name")]
	public string Name { get; set; }
}
