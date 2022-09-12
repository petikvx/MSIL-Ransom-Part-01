using System.Collections.Generic;
using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaTVResponse
{
	[JsonProperty("channels")]
	public List<InstaTVChannelResponse> Channels { get; set; }

	[JsonProperty("my_channel")]
	public InstaTVSelfChannelResponse MyChannel { get; set; }

	[JsonProperty("status")]
	internal string Status { get; set; }
}
