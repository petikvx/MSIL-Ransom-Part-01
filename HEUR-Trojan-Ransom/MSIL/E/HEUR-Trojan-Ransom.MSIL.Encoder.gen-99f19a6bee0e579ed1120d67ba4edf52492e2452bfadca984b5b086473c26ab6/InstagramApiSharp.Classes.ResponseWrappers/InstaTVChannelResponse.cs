using System.Collections.Generic;
using InstagramApiSharp.Enums;
using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaTVChannelResponse
{
	[JsonIgnore]
	public InstaTVChannelType Type => PrivateType.GetChannelType();

	[JsonProperty("type")]
	internal string PrivateType { get; set; }

	[JsonProperty("title")]
	public string Title { get; set; }

	[JsonProperty("id")]
	public string Id { get; set; }

	[JsonProperty("items")]
	public List<InstaMediaItemResponse> Items { get; set; }

	[JsonProperty("more_available")]
	public bool HasMoreAvailable { get; set; }

	[JsonProperty("max_id")]
	public string MaxId { get; set; }

	[JsonProperty("user_dict")]
	public InstaTVUserResponse UserDetail { get; set; }
}
