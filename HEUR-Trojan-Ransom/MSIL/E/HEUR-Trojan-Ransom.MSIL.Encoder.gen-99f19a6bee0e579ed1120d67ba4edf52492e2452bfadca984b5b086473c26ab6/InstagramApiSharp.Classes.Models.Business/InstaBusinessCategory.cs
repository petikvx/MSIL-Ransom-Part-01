using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.Models.Business;

public class InstaBusinessCategory
{
	[JsonProperty("category_name")]
	public string CategoryName { get; set; }

	[JsonProperty("category_id")]
	public string CategoryId { get; set; }
}
