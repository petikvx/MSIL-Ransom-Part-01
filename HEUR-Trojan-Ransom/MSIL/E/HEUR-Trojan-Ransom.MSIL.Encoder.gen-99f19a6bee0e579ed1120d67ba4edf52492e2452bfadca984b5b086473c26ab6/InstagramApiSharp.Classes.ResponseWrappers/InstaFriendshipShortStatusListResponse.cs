using System.Collections.Generic;
using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaFriendshipShortStatusListResponse : List<InstaFriendshipShortStatusResponse>
{
	[JsonProperty("status")]
	public string Status { get; set; }
}
