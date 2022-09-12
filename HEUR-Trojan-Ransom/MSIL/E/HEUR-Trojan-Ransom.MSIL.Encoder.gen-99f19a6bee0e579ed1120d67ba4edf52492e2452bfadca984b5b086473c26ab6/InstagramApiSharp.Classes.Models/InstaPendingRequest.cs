using InstagramApiSharp.Classes.ResponseWrappers;
using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.Models;

public class InstaPendingRequest
{
	[JsonProperty("big_list")]
	public bool BigList { get; set; }

	[JsonProperty("page_size")]
	public int PageSize { get; set; }

	[JsonProperty("status")]
	public string Status { get; set; }

	[JsonProperty("suggested_users")]
	public InstaPendingSuggestedUsers SuggestedUsers { get; set; }

	[JsonProperty("truncate_follow_requests_at_index")]
	public int TruncateFollowRequestsAtIndex { get; set; }

	[JsonProperty("users")]
	public InstaUserShortResponse[] Users { get; set; }
}
