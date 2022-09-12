using InstagramApiSharp.Classes.Models;
using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaHighlightReelResponse : InstaDefault
{
	[JsonIgnore]
	public InstaHighlightSingleFeedResponse Reel { get; set; }
}
