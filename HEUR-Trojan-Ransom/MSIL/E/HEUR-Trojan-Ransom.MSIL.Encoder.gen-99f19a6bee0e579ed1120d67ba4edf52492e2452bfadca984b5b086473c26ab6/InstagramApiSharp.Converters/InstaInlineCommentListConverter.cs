using System.Linq;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaInlineCommentListConverter : IObjectConverter<InstaInlineCommentList, InstaInlineCommentListResponse>
{
	public InstaInlineCommentListResponse SourceObject { get; set; }

	public InstaInlineCommentList Convert()
	{
		if (SourceObject == null)
		{
			return null;
		}
		InstaInlineCommentList instaInlineCommentList = new InstaInlineCommentList
		{
			ChildCommentCount = SourceObject.ChildCommentCount,
			HasMoreHeadChildComments = SourceObject.HasMoreHeadChildComments,
			HasMoreTailChildComments = SourceObject.HasMoreTailChildComments,
			NumTailChildComments = SourceObject.NumTailChildComments,
			NextMaxId = SourceObject.NextMaxId,
			NextMinId = SourceObject.NextMinId
		};
		if (SourceObject.ParentComment != null)
		{
			try
			{
				instaInlineCommentList.ParentComment = ConvertersFabric.Instance.GetCommentConverter(SourceObject.ParentComment).Convert();
			}
			catch
			{
			}
		}
		if (SourceObject.ChildComments != null && SourceObject.ChildComments.Any())
		{
			foreach (InstaCommentResponse childComment in SourceObject.ChildComments)
			{
				try
				{
					instaInlineCommentList.ChildComments.Add(ConvertersFabric.Instance.GetCommentConverter(childComment).Convert());
				}
				catch
				{
				}
			}
			return instaInlineCommentList;
		}
		return instaInlineCommentList;
	}
}
