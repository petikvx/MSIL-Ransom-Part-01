using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaUserPresenceResponse
{
	[JsonProperty("is_active")]
	public bool? IsActive { get; set; }

	[JsonProperty("last_activity_at_ms")]
	public long? LastActivityAtMs { get; set; }

	[JsonIgnore]
	public long Pk { get; set; }
}
