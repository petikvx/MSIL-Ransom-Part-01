using InstagramApiSharp.Classes.ResponseWrappers;
using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.Models;

public class InstaPendingSuggestedSingleUser
{
	[JsonProperty("user")]
	public InstaUserShortResponse User { get; set; }
}
