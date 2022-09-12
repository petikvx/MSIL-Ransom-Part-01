using System.Collections.Generic;
using InstagramApiSharp.Classes.ResponseWrappers;
using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.Models;

public class InstaAccountBlockedReels
{
	[JsonProperty("users")]
	public List<InstaUserResponse> Users { get; set; }

	[JsonProperty("big_list")]
	public bool BigList { get; set; }

	[JsonProperty("page_size")]
	public int PageSize { get; set; }
}
