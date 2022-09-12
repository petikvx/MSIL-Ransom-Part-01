using System;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaBroadcastCommentEnableDisableConverter : IObjectConverter<InstaBroadcastCommentEnableDisable, InstaBroadcastCommentEnableDisableResponse>
{
	public InstaBroadcastCommentEnableDisableResponse SourceObject { get; set; }

	public InstaBroadcastCommentEnableDisable Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		return new InstaBroadcastCommentEnableDisable
		{
			CommentMuted = SourceObject.CommentMuted
		};
	}
}
