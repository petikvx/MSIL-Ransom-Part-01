using System.Collections.Generic;
using InstagramApiSharp.Classes.Models;
using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaProductInfoResponse : InstaDefault
{
	[JsonProperty("product_item")]
	public InstaProductResponse Product { get; set; }

	[JsonProperty("other_product_items")]
	public List<InstaProductResponse> OtherProductItems { get; set; }

	[JsonProperty("user")]
	public InstaUserShortResponse User { get; set; }

	[JsonProperty("more_from_business")]
	public InstaProductMediaListResponse MoreFromBusiness { get; set; }
}
