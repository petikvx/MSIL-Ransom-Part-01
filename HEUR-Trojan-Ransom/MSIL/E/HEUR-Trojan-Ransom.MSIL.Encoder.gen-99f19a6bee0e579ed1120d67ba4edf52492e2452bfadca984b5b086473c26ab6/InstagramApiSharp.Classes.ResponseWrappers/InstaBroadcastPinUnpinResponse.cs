using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaBroadcastPinUnpinResponse
{
	[JsonProperty("comment_id")]
	public long CommentId { get; set; }

	[JsonProperty("status")]
	public string Status { get; set; }
}
