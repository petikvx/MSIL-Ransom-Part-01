using System.Linq;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaCommentListConverter : IObjectConverter<InstaCommentList, InstaCommentListResponse>
{
	public InstaCommentListResponse SourceObject { get; set; }

	public InstaCommentList Convert()
	{
		InstaCommentList instaCommentList = new InstaCommentList
		{
			Caption = ((SourceObject.Caption != null) ? ConvertersFabric.Instance.GetCaptionConverter(SourceObject.Caption).Convert() : null),
			CanViewMorePreviewComments = SourceObject.CanViewMorePreviewComments,
			CaptionIsEdited = SourceObject.CaptionIsEdited,
			CommentsCount = SourceObject.CommentsCount,
			MoreCommentsAvailable = SourceObject.MoreCommentsAvailable,
			InitiateAtTop = SourceObject.InitiateAtTop,
			InsertNewCommentToTop = SourceObject.InsertNewCommentToTop,
			MediaHeaderDisplay = SourceObject.MediaHeaderDisplay,
			ThreadingEnabled = SourceObject.ThreadingEnabled,
			LikesEnabled = SourceObject.LikesEnabled,
			MoreHeadLoadAvailable = SourceObject.MoreHeadLoadAvailable,
			NextMaxId = SourceObject.NextMaxId,
			NextMinId = SourceObject.NextMinId
		};
		if (SourceObject.Comments != null)
		{
			InstaCommentListResponse sourceObject = SourceObject;
			if (sourceObject != null && sourceObject.Comments?.Count > 0)
			{
				foreach (InstaCommentResponse comment in SourceObject.Comments)
				{
					IObjectConverter<InstaComment, InstaCommentResponse> commentConverter = ConvertersFabric.Instance.GetCommentConverter(comment);
					instaCommentList.Comments.Add(commentConverter.Convert());
				}
				if (SourceObject.PreviewComments != null && SourceObject.PreviewComments.Any())
				{
					foreach (InstaCommentResponse previewComment in SourceObject.PreviewComments)
					{
						try
						{
							instaCommentList.PreviewComments.Add(ConvertersFabric.Instance.GetCommentConverter(previewComment).Convert());
						}
						catch
						{
						}
					}
					return instaCommentList;
				}
				return instaCommentList;
			}
		}
		return instaCommentList;
	}
}
