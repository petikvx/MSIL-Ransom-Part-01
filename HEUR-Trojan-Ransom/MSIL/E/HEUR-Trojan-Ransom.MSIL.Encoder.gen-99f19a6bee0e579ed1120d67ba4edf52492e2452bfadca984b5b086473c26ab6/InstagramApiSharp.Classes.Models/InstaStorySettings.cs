using InstagramApiSharp.Enums;
using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.Models;

public class InstaStorySettings
{
	[JsonIgnore]
	public InstaMessageRepliesType MessagePrefsType => MessagePrefs switch
	{
		"off" => InstaMessageRepliesType.Off, 
		"following" => InstaMessageRepliesType.Following, 
		_ => InstaMessageRepliesType.Everyone, 
	};

	[JsonProperty("message_prefs")]
	internal string MessagePrefs { get; set; }

	[JsonProperty("blocked_reels")]
	public InstaAccountBlockedReels BlockedReels { get; set; }

	[JsonProperty("besties")]
	public InstaAccountBesties Besties { get; set; }

	[JsonProperty("persist_stories_to_private_profile")]
	public bool PersistStoriesToPrivateProfile { get; set; }

	[JsonProperty("reel_auto_archive")]
	public string ReelAutoArchive { get; set; }

	[JsonProperty("allow_story_reshare")]
	public bool AllowStoryReshare { get; set; }

	[JsonProperty("save_to_camera_roll")]
	public bool SaveToCameraRoll { get; set; }

	[JsonProperty("status")]
	public string Status { get; set; }
}
