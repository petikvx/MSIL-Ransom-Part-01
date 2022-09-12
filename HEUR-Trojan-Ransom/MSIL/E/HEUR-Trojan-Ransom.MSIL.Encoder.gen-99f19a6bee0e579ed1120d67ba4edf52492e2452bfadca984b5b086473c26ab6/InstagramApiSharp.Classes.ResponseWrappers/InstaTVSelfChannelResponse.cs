using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaTVSelfChannelResponse : InstaTVChannelResponse
{
	[JsonProperty("user_dict")]
	public InstaTVUserResponse User { get; set; }
}
