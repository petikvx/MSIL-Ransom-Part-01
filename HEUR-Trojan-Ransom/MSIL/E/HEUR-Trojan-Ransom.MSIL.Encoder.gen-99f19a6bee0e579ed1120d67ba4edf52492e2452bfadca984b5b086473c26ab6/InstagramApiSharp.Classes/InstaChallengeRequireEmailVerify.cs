using Newtonsoft.Json;

namespace InstagramApiSharp.Classes;

public class InstaChallengeRequireEmailVerify
{
	[JsonProperty("step_name")]
	public string StepName { get; set; }

	[JsonProperty("step_data")]
	public InstaChallengeRequireStepDataEmailVerify StepData { get; set; }

	[JsonProperty("user_id")]
	public long UserId { get; set; }

	[JsonProperty("nonce_code")]
	public string NonceCode { get; set; }

	[JsonProperty("status")]
	internal string Status { get; set; }

	[JsonProperty("message")]
	public string Message { get; set; }
}
