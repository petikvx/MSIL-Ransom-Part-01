using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaBroadcastCommentEnableDisableResponse
{
	[JsonProperty("comment_muted")]
	public int CommentMuted { get; set; }

	[JsonProperty("status")]
	public string Status { get; set; }
}
