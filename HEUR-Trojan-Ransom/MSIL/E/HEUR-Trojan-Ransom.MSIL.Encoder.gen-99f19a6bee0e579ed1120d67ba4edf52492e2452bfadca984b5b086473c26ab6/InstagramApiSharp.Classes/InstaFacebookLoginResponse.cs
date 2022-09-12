using InstagramApiSharp.Classes.ResponseWrappers;
using Newtonsoft.Json;

namespace InstagramApiSharp.Classes;

internal class InstaFacebookLoginResponse
{
	[JsonProperty("logged_in_user")]
	public InstaUserShortResponse LoggedInUser { get; set; }

	[JsonProperty("code")]
	public int? Code { get; set; }

	[JsonProperty("fb_user_id")]
	public string FbUserId { get; set; }

	[JsonProperty("status")]
	public string Status { get; set; }

	[JsonProperty("created_user")]
	public InstaUserShortResponse CreatedUser { get; set; }

	[JsonProperty("multiple_users_on_device")]
	public bool? MultipleUsersOnDevice { get; set; }
}
