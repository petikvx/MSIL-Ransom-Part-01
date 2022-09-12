namespace InstagramApiSharp.Classes.Models;

public class InstaFullUserInfo
{
	public InstaUserInfo UserDetail { get; set; }

	internal string Status { get; set; }

	public InstaFullUserInfoUserFeed Feed { get; set; }

	public InstaFullUserInfoUserStoryReel ReelFeed { get; set; }

	public InstaFullUserInfoUserStory UserStory { get; set; }
}
