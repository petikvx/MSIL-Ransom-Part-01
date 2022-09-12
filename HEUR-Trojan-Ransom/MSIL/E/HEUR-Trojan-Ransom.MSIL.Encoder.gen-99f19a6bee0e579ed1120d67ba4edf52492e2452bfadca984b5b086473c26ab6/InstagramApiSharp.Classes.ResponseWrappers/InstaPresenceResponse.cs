using InstagramApiSharp.Classes.Models;
using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaPresenceResponse : InstaDefault
{
	[JsonProperty("disabled")]
	public bool? Disabled { get; set; }

	[JsonProperty("thread_presence_disabled")]
	public bool? ThreadPresenceDisabled { get; set; }
}
