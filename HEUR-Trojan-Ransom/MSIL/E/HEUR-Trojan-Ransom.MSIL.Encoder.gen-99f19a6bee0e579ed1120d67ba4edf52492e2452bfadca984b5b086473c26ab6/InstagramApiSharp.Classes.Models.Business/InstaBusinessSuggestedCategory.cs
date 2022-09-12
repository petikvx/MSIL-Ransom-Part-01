using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.Models.Business;

public class InstaBusinessSuggestedCategory : InstaBusinessCategory
{
	[JsonProperty("super_cat_name")]
	public string SuperCatName { get; set; }

	[JsonProperty("super_cat_id")]
	public string SuperCatIid { get; set; }
}
