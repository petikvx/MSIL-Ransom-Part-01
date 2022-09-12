using System;
using System.Collections.Generic;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers.Web;

namespace InstagramApiSharp.Converters;

internal class InstaWebTextDataConverter : IObjectConverter<InstaWebTextData, InstaWebSettingsPageResponse>
{
	public InstaWebSettingsPageResponse SourceObject { get; set; }

	public InstaWebTextData Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaWebTextData instaWebTextData = new InstaWebTextData();
		List<InstaWebDataItemResponse> data = SourceObject.Data.Data;
		if (data != null && data.Count > 0)
		{
			foreach (InstaWebDataItemResponse datum in SourceObject.Data.Data)
			{
				if (datum.Text.IsNotEmpty())
				{
					instaWebTextData.Items.Add(datum.Text);
				}
			}
			instaWebTextData.MaxId = SourceObject.Data.Cursor;
		}
		return instaWebTextData;
	}
}
