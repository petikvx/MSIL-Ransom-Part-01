using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaUserContactResponse : InstaUserShortResponse
{
	[JsonProperty("extra_display_name")]
	public string ExtraDisplayName { get; set; }
}
