using System;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers.Web;

namespace InstagramApiSharp.Converters;

internal class InstaWebDataConverter : IObjectConverter<InstaWebData, InstaWebSettingsPageResponse>
{
	public InstaWebSettingsPageResponse SourceObject { get; set; }

	public InstaWebData Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaWebData instaWebData = new InstaWebData();
		InstaWebDataListResponse data = SourceObject.Data;
		if (data != null && data.Data?.Count > 0)
		{
			foreach (InstaWebDataItemResponse datum in SourceObject.Data.Data)
			{
				instaWebData.Items.Add(ConvertersFabric.Instance.GetWebDataItemConverter(datum).Convert());
			}
			instaWebData.MaxId = SourceObject.Data.Cursor;
		}
		return instaWebData;
	}
}
