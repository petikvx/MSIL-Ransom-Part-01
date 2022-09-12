using System;
using System.Linq;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaHighlightShortListConverter : IObjectConverter<InstaHighlightShortList, InstaHighlightShortListResponse>
{
	public InstaHighlightShortListResponse SourceObject { get; set; }

	public InstaHighlightShortList Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaHighlightShortList instaHighlightShortList = new InstaHighlightShortList
		{
			MaxId = (SourceObject.MaxId ?? string.Empty),
			MoreAvailable = SourceObject.MoreAvailable,
			ResultsCount = SourceObject.ResultsCount
		};
		if (SourceObject.Items != null && SourceObject.Items.Any())
		{
			foreach (InstaHighlightShortResponse item in SourceObject.Items)
			{
				try
				{
					instaHighlightShortList.Items.Add(ConvertersFabric.Instance.GetSingleHighlightShortConverter(item).Convert());
				}
				catch
				{
				}
			}
			return instaHighlightShortList;
		}
		return instaHighlightShortList;
	}
}
