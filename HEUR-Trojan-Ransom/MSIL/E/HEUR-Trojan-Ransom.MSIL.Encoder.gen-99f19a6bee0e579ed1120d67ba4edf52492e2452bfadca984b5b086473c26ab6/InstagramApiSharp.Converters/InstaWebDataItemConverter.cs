using System;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers.Web;
using InstagramApiSharp.Helpers;

namespace InstagramApiSharp.Converters;

internal class InstaWebDataItemConverter : IObjectConverter<InstaWebDataItem, InstaWebDataItemResponse>
{
	public InstaWebDataItemResponse SourceObject { get; set; }

	public InstaWebDataItem Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaWebDataItem instaWebDataItem = new InstaWebDataItem
		{
			Text = SourceObject.Text
		};
		if (SourceObject.Timestamp.HasValue)
		{
			instaWebDataItem.Time = SourceObject.Timestamp.Value.FromUnixTimeSeconds();
		}
		else
		{
			instaWebDataItem.Time = DateTime.MinValue;
		}
		return instaWebDataItem;
	}
}
