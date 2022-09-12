using System;
using System.Collections.Generic;
using System.Linq;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;
using InstagramApiSharp.Helpers;

namespace InstagramApiSharp.Converters;

internal class InstaCommentConverter : IObjectConverter<InstaComment, InstaCommentResponse>
{
	public InstaCommentResponse SourceObject { get; set; }

	public InstaComment Convert()
	{
		InstaComment instaComment = new InstaComment
		{
			BitFlags = SourceObject.BitFlags,
			ContentType = (InstaContentType)Enum.Parse(typeof(InstaContentType), SourceObject.ContentType, ignoreCase: true),
			CreatedAt = DateTimeHelper.UnixTimestampToDateTime(SourceObject.CreatedAt),
			CreatedAtUtc = DateTimeHelper.UnixTimestampToDateTime(SourceObject.CreatedAtUtc),
			LikesCount = SourceObject.LikesCount,
			Pk = SourceObject.Pk,
			Status = SourceObject.Status,
			Text = SourceObject.Text,
			Type = SourceObject.Type,
			UserId = SourceObject.UserId,
			User = ConvertersFabric.Instance.GetUserShortConverter(SourceObject.User).Convert(),
			DidReportAsSpam = SourceObject.DidReportAsSpam,
			ChildCommentCount = SourceObject.ChildCommentCount,
			HasLikedComment = SourceObject.HasLikedComment,
			HasMoreHeadChildComments = SourceObject.HasMoreHeadChildComments,
			HasMoreTailChildComments = SourceObject.HasMoreTailChildComments
		};
		if (SourceObject.OtherPreviewUsers != null && SourceObject.OtherPreviewUsers.Any())
		{
			if (instaComment.OtherPreviewUsers == null)
			{
				instaComment.OtherPreviewUsers = new List<InstaUserShort>();
			}
			foreach (InstaUserShortResponse otherPreviewUser in SourceObject.OtherPreviewUsers)
			{
				instaComment.OtherPreviewUsers.Add(ConvertersFabric.Instance.GetUserShortConverter(otherPreviewUser).Convert());
			}
		}
		if (SourceObject.PreviewChildComments != null && SourceObject.PreviewChildComments.Any())
		{
			if (instaComment.PreviewChildComments == null)
			{
				instaComment.PreviewChildComments = new List<InstaCommentShort>();
			}
			{
				foreach (InstaCommentShortResponse previewChildComment in SourceObject.PreviewChildComments)
				{
					instaComment.PreviewChildComments.Add(ConvertersFabric.Instance.GetCommentShortConverter(previewChildComment).Convert());
				}
				return instaComment;
			}
		}
		return instaComment;
	}
}
