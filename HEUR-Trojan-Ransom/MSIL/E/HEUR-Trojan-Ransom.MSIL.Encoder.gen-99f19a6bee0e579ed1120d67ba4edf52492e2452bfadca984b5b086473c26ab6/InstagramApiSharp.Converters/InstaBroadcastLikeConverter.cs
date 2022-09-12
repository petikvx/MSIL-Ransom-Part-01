using System;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;
using InstagramApiSharp.Helpers;

namespace InstagramApiSharp.Converters;

internal class InstaBroadcastLikeConverter : IObjectConverter<InstaBroadcastLike, InstaBroadcastLikeResponse>
{
	public InstaBroadcastLikeResponse SourceObject { get; set; }

	public InstaBroadcastLike Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		return new InstaBroadcastLike
		{
			BurstLikes = SourceObject.BurstLikes,
			Likes = SourceObject.Likes,
			LikeTime = (SourceObject.LikeTs ?? DateTime.Now.ToUnixTime()).FromUnixTimeSeconds()
		};
	}
}
