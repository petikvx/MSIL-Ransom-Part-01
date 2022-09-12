using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaStoryFriendshipStatusShortResponse
{
	[JsonProperty("following")]
	public bool Following { get; set; }

	[JsonProperty("muting")]
	public bool? Muting { get; set; }

	[JsonProperty("outgoing_request")]
	public bool? OutgoingRequest { get; set; }

	[JsonProperty("is_muting_reel")]
	public bool? IsMutingReel { get; set; }
}
