using Newtonsoft.Json;

namespace InstagramApiSharp.Classes;

public class InstaChallengeRequireVerifyMethod
{
	[JsonProperty("step_name")]
	public string StepName { get; set; }

	[JsonProperty("step_data")]
	public InstaChallengeRequireStepData StepData { get; set; }

	[JsonProperty("user_id")]
	public long UserId { get; set; }

	[JsonProperty("nonce_code")]
	public string NonceCode { get; set; }

	[JsonProperty("status")]
	internal string Status { get; set; }

	[JsonProperty("message")]
	internal string Message { get; set; }

	public bool SubmitPhoneRequired => StepName == "submit_phone";
}
