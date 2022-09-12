using System.Collections.Generic;
using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaPersistentSectionLayoutContentResponse
{
	[JsonProperty("related_style")]
	public string RelatedTtyle { get; set; }

	[JsonProperty("related")]
	public List<InstaRelatedHashtagResponse> Related { get; set; }
}
