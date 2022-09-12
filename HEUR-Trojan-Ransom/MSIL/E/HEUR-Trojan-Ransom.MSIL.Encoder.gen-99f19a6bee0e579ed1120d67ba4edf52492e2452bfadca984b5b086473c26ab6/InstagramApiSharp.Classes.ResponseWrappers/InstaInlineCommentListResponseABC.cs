using System.Collections.Generic;
using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

internal class InstaInlineCommentListResponseABC
{
	[JsonProperty("comment_likes_enabled")]
	public bool CommentLikesEnabled { get; set; }

	[JsonProperty("comments")]
	public List<InstaCommentResponse> Comments { get; set; }

	[JsonProperty("comment_count")]
	public int CommentCount { get; set; }

	[JsonProperty("caption")]
	public InstaCaptionResponse Caption { get; set; }

	[JsonProperty("caption_is_edited")]
	public bool CaptionIsEdited { get; set; }

	[JsonProperty("has_more_comments")]
	public bool HasMoreComments { get; set; }

	[JsonProperty("has_more_headload_comments")]
	public bool HasMoreHeadloadComments { get; set; }

	[JsonProperty("threading_enabled")]
	public bool ThreadingEnabled { get; set; }

	[JsonProperty("media_header_display")]
	public string MediaHeaderDisplay { get; set; }

	[JsonProperty("initiate_at_top")]
	public bool InitiateAtTop { get; set; }

	[JsonProperty("insert_new_comment_to_top")]
	public bool InsertNewCommentToTop { get; set; }

	[JsonProperty("preview_comments")]
	public List<InstaCommentResponse> PreviewComments { get; set; }

	[JsonProperty("can_view_more_preview_comments")]
	public bool CanViewMorePreviewComments { get; set; }

	[JsonProperty("next_min_id")]
	public string NextMinId { get; set; }

	[JsonProperty("status")]
	internal string Status { get; set; }

	[JsonProperty("next_max_id")]
	public string NextMaxId { get; set; }
}
