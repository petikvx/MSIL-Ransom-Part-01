using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.Models;

public class InstaSharingPayload
{
	[JsonProperty("thread_id")]
	public string ThreadId { get; set; }

	[JsonProperty("item_id")]
	public string ItemId { get; set; }

	[JsonProperty("participant_ids")]
	public long[] ParticipantIds { get; set; }

	[JsonProperty("timestamp")]
	public string Timestamp { get; set; }

	[JsonProperty("client_context")]
	public object ClientContext { get; set; }

	[JsonProperty("canonical")]
	public bool Cnonical { get; set; }
}
