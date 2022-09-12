using System.Collections.Generic;
using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaSectionMediaListResponse
{
	[JsonProperty("sections")]
	public List<InstaSectionMediaResponse> Sections { get; set; } = new List<InstaSectionMediaResponse>();


	[JsonProperty("persistent_sections")]
	public List<InstaPersistentSectionResponse> PersistentSections { get; set; } = new List<InstaPersistentSectionResponse>();


	[JsonProperty("more_available")]
	public bool MoreAvailable { get; set; }

	[JsonProperty("next_max_id")]
	public string NextMaxId { get; set; }

	[JsonProperty("next_page")]
	public int? NextPage { get; set; }

	[JsonProperty("next_media_ids")]
	public List<long> NextMediaIds { get; set; }

	[JsonProperty("auto_load_more_enabled")]
	public bool? AutoLoadMoreEnabled { get; set; }

	[JsonProperty("status")]
	public string Status { get; set; }
}
