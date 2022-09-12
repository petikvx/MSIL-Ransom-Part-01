using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

internal class InstaInlineCommentNextIdResponse
{
	[JsonProperty("cached_comments_cursor")]
	public string CachedCommentsCursor { get; set; }

	[JsonProperty("bifilter_token")]
	public string BifilterToken { get; set; }

	[JsonProperty("server_cursor")]
	public string ServerCursor { get; set; }
}
