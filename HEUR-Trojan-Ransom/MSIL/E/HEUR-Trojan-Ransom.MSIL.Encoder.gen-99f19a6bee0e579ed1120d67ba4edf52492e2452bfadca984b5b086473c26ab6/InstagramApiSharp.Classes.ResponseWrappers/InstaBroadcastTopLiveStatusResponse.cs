using System.Collections.Generic;
using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaBroadcastTopLiveStatusResponse
{
	[JsonProperty("broadcast_status_items")]
	public List<InstaBroadcastStatusItemResponse> BroadcastStatusItems { get; set; }

	[JsonProperty("status")]
	public string Status { get; set; }
}
