using System;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;
using InstagramApiSharp.Helpers;

namespace InstagramApiSharp.Converters;

internal class InstaBroadcastSendCommentConverter : IObjectConverter<InstaBroadcastSendComment, InstaBroadcastSendCommentResponse>
{
	public InstaBroadcastSendCommentResponse SourceObject { get; set; }

	public InstaBroadcastSendComment Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaBroadcastSendComment instaBroadcastSendComment = new InstaBroadcastSendComment
		{
			MediaId = SourceObject.MediaId,
			ContentType = SourceObject.ContentType,
			CreatedAt = (SourceObject.CreatedAt ?? DateTime.Now.ToUnixTime()).FromUnixTimeSeconds(),
			CreatedAtUtc = (SourceObject.CreatedAtUtc ?? DateTime.UtcNow.ToUnixTime()).FromUnixTimeSeconds(),
			Pk = SourceObject.Pk,
			Text = SourceObject.Text,
			Type = SourceObject.Type
		};
		if (SourceObject.User != null)
		{
			instaBroadcastSendComment.User = ConvertersFabric.Instance.GetUserShortFriendshipFullConverter(SourceObject.User).Convert();
		}
		return instaBroadcastSendComment;
	}
}
