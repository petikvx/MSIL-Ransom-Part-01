using InstagramApiSharp.Classes.Models;
using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaUserContainerResponse : InstaDefault
{
	[JsonProperty("user")]
	public InstaUserResponse User { get; set; }
}
