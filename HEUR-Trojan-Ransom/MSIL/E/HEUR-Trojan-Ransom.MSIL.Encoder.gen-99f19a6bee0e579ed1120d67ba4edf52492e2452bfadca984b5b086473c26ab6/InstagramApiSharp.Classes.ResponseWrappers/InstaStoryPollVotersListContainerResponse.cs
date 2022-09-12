using InstagramApiSharp.Classes.Models;
using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaStoryPollVotersListContainerResponse : InstaDefault
{
	[JsonProperty("voter_info")]
	public InstaStoryPollVotersListResponse VoterInfo { get; set; }
}
