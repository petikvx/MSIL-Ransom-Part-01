using System;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaStoryTalliesItemConverter : IObjectConverter<InstaStoryTalliesItem, InstaStoryTalliesItemResponse>
{
	public InstaStoryTalliesItemResponse SourceObject { get; set; }

	public InstaStoryTalliesItem Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		return new InstaStoryTalliesItem
		{
			Count = SourceObject.Count,
			FontSize = SourceObject.FontSize,
			Text = SourceObject.Text
		};
	}
}
