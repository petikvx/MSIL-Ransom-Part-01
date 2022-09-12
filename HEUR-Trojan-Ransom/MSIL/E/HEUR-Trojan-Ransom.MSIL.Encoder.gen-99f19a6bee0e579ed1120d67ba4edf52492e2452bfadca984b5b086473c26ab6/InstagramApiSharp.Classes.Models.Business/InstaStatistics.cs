namespace InstagramApiSharp.Classes.Models.Business;

public class InstaStatistics
{
	public string BusinessProfileId { get; set; }

	public InstaStatisticsBusinessManager BusinessManager { get; set; }

	public string Username { get; set; }

	public string ProfilePicture { get; set; }

	public string UserId { get; set; }

	public int FollowersCount { get; set; }

	public string Id { get; set; }
}
