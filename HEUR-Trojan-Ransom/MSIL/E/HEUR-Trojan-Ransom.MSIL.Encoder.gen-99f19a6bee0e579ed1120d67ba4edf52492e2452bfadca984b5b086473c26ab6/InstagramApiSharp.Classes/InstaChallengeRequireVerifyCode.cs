using InstagramApiSharp.Classes.ResponseWrappers;
using Newtonsoft.Json;

namespace InstagramApiSharp.Classes;

public class InstaChallengeRequireVerifyCode
{
	[JsonIgnore]
	public bool IsLoggedIn
	{
		get
		{
			if (LoggedInUser == null)
			{
				return Status.ToLower() == "ok";
			}
			return true;
		}
	}

	[JsonProperty("logged_in_user")]
	public InstaUserShortResponse LoggedInUser { get; set; }

	[JsonProperty("message")]
	public string Message { get; set; }

	[JsonProperty("status")]
	internal string Status { get; set; }

	[JsonProperty("action")]
	internal string Action { get; set; }
}
