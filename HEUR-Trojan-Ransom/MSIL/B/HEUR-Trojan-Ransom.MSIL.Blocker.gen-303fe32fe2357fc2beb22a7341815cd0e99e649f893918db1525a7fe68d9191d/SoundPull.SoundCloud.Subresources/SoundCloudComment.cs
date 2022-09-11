namespace SoundPull.SoundCloud.Subresources;

public class SoundCloudComment
{
	private readonly string kind = "comment";

	public int id { get; set; }

	public string created_at { get; set; }

	public int user_id { get; set; }

	public int track_id { get; set; }

	public int timestamp { get; set; }

	public string body { get; set; }

	public string uri { get; set; }

	public SoundCloudUser user { get; set; }

	public bool IsAReply()
	{
		if (body.StartsWith("@"))
		{
			return true;
		}
		return false;
	}
}
