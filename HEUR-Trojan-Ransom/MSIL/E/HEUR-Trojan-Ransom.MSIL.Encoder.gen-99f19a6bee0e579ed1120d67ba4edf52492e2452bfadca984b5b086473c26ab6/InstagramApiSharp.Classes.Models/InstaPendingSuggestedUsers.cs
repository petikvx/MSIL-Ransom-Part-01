using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.Models;

public class InstaPendingSuggestedUsers
{
	[JsonProperty("netego_type")]
	public string NetegoType { get; set; }

	[JsonProperty("suggestions")]
	public InstaPendingSuggestedSingleUser[] Suggestions { get; set; }
}
