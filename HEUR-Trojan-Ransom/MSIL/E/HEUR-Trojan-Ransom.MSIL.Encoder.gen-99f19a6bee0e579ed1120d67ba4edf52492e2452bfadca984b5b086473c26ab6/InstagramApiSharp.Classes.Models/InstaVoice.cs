namespace InstagramApiSharp.Classes.Models;

public class InstaVoice
{
	public string Id { get; set; }

	public int MediaType { get; set; }

	public string ProductType { get; set; }

	public InstaAudio Audio { get; set; }

	public string OrganicTrackingToken { get; set; }

	public InstaFriendshipStatus FriendshipStatus { get; set; }
}
