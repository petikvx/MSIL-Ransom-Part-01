using System;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaStoryTrayConverter : IObjectConverter<InstaStoryTray, InstaStoryTrayResponse>
{
	public InstaStoryTrayResponse SourceObject { get; set; }

	public InstaStoryTray Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaStoryTray instaStoryTray = new InstaStoryTray
		{
			Id = SourceObject.Id,
			IsPortrait = SourceObject.IsPortrait,
			TopLive = ConvertersFabric.Instance.GetTopLiveConverter(SourceObject.TopLive).Convert()
		};
		if (SourceObject.Tray != null)
		{
			foreach (InstaStoryResponse item2 in SourceObject.Tray)
			{
				InstaStory item = ConvertersFabric.Instance.GetStoryConverter(item2).Convert();
				instaStoryTray.Tray.Add(item);
			}
			return instaStoryTray;
		}
		return instaStoryTray;
	}
}
