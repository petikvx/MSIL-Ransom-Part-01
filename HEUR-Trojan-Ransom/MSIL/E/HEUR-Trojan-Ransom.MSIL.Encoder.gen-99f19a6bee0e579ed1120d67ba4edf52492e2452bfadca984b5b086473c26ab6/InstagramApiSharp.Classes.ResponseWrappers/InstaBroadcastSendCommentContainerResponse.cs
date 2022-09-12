using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaBroadcastSendCommentContainerResponse
{
	[JsonProperty("comment")]
	public InstaBroadcastSendCommentResponse Comment { get; set; }

	[JsonProperty("status")]
	public string Status { get; set; }

	[JsonProperty("message")]
	public string Message { get; set; }
}
