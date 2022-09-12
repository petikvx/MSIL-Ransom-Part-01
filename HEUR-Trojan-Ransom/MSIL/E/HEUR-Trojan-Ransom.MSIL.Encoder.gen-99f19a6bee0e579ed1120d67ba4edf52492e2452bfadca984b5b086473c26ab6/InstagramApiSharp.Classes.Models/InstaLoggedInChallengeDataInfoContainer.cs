using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.Models;

internal class InstaLoggedInChallengeDataInfoContainer
{
	[JsonProperty("step_name")]
	public string StepName { get; set; }

	[JsonProperty("step_data")]
	public InstaLoggedInChallengeDataInfo StepData { get; set; }

	[JsonProperty("status")]
	public string Status { get; set; }
}
