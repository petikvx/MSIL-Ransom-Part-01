using System.Collections.Generic;
using InstagramApiSharp.Classes.Models;
using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaBlockedUsersResponse : InstaDefault
{
	[JsonProperty("blocked_list")]
	public List<InstaBlockedUserInfoResponse> BlockedList { get; set; }

	[JsonProperty("big_list")]
	public bool? BigList { get; set; }

	[JsonProperty("page_size")]
	public int? PageSize { get; set; }

	[JsonProperty("max_id")]
	public string MaxId { get; set; }
}
