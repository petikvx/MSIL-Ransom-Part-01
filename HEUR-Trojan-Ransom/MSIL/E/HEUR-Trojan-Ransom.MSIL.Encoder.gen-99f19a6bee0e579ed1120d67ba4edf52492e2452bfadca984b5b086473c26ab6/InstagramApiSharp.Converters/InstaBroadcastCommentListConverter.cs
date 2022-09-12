using System;
using System.Collections.Generic;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaBroadcastCommentListConverter : IObjectConverter<InstaBroadcastCommentList, InstaBroadcastCommentListResponse>
{
	public InstaBroadcastCommentListResponse SourceObject { get; set; }

	public InstaBroadcastCommentList Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaBroadcastCommentList instaBroadcastCommentList = new InstaBroadcastCommentList
		{
			CaptionIsEdited = SourceObject.CaptionIsEdited.GetValueOrDefault(),
			CommentCount = SourceObject.CommentCount.GetValueOrDefault(),
			CommentLikesEnabled = SourceObject.CommentLikesEnabled.GetValueOrDefault(),
			CommentMuted = SourceObject.CommentMuted.GetValueOrDefault(),
			HasMoreComments = SourceObject.HasMoreComments.GetValueOrDefault(),
			HasMoreHeadloadComments = SourceObject.HasMoreHeadloadComments.GetValueOrDefault(),
			IsFirstFetch = SourceObject.IsFirstFetch,
			LiveSecondsPerComment = SourceObject.LiveSecondsPerComment.GetValueOrDefault(),
			MediaHeaderDisplay = SourceObject.MediaHeaderDisplay,
			SystemComments = SourceObject.SystemComments
		};
		if (SourceObject.Caption != null)
		{
			instaBroadcastCommentList.Caption = ConvertersFabric.Instance.GetCaptionConverter(SourceObject.Caption).Convert();
		}
		if (SourceObject.PinnedComment != null)
		{
			instaBroadcastCommentList.PinnedComment = ConvertersFabric.Instance.GetBroadcastCommentConverter(SourceObject.PinnedComment).Convert();
		}
		try
		{
			List<InstaBroadcastCommentResponse> comments = SourceObject.Comments;
			if (comments != null && comments.Count > 0)
			{
				foreach (InstaBroadcastCommentResponse comment in SourceObject.Comments)
				{
					instaBroadcastCommentList.Comments.Add(ConvertersFabric.Instance.GetBroadcastCommentConverter(comment).Convert());
				}
				return instaBroadcastCommentList;
			}
			return instaBroadcastCommentList;
		}
		catch
		{
			return instaBroadcastCommentList;
		}
	}
}
