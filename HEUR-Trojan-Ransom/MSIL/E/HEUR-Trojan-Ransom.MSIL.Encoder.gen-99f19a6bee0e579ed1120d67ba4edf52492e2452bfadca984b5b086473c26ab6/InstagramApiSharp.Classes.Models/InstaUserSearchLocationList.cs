using InstagramApiSharp.Classes.ResponseWrappers;
using InstagramApiSharp.Enums;
using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.Models;

public class InstaUserSearchLocationList
{
	[JsonProperty("position")]
	public int Position { get; set; }

	[JsonProperty("user")]
	public InstaUserShortFriendshipResponse User { get; set; }

	[JsonProperty("hashtag")]
	public InstaHashtagResponse Hashtag { get; set; }

	[JsonProperty("place")]
	public InstaPlaceResponse Place { get; set; }

	[JsonIgnore]
	public InstaSearchType Type
	{
		get
		{
			if (User != null)
			{
				return InstaSearchType.User;
			}
			if (Hashtag != null)
			{
				return InstaSearchType.Hashtag;
			}
			if (Place != null)
			{
				return InstaSearchType.Place;
			}
			return InstaSearchType.Unknown;
		}
	}
}
