using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaBroadcastCommentResponse : InstaBroadcastSendCommentResponse
{
	[JsonProperty("user_id")]
	public long UserId { get; set; }

	[JsonProperty("bit_flags")]
	public int BitFlags { get; set; }

	[JsonProperty("did_report_as_spam")]
	public bool DidReportAsSpam { get; set; }

	[JsonProperty("inline_composer_display_condition")]
	public string InlineComposerDisplayCondition { get; set; }
}
