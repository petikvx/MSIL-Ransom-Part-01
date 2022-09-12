using System.Collections.Generic;
using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaContactUserListResponse
{
	[JsonProperty("status")]
	public string Status { get; set; }

	[JsonProperty("items")]
	public List<InstaContactUserResponse> Items { get; set; }
}
